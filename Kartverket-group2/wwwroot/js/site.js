// Initialize the Leaflet map centered on coordinates [58.1599, 8.0182] with zoom level 13
// Disable default zoom control as we'll add custom controls later
var map = L.map('map', { zoomControl: false }).setView([58.1599, 8.0182], 13);

// Define different map tile layers with their respective URLs and attribution
// These provide different visual styles for the map (standard, satellite, topographic, etc.)
var osmLayer = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '© OpenStreetMap contributors'
});
var satelliteLayer = L.tileLayer('https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}', {
    attribution: 'Tiles &copy; Esri &mdash; Source: Esri, i-cubed, USDA, USGS, AEX, GeoEye, Getmapping, Aerogrid, IGN, IGP, UPR-EGP, and the GIS User Community'
});
var topoLayer = L.tileLayer('https://{s}.tile.opentopomap.org/{z}/{x}/{y}.png', {
    attribution: 'Map data: © OpenStreetMap contributors, SRTM | Map style: © OpenTopoMap (CC-BY-SA)'
});
var turLayer = L.tileLayer('https://cache.kartverket.no/v1/wmts/1.0.0/toporaster/default/webmercator/{z}/{y}/{x}.png', {
    attribution: '&copy; <a href="http://www.kartverket.no/">Kartverket</a>'
})

var sjoLayer = L.tileLayer('https://cache.kartverket.no/v1/wmts/1.0.0/sjokartraster/default/webmercator/{z}/{y}/{x}.png', {
    attribution: '&copy; <a href="http://www.kartverket.no/">Kartverket</a>'
})


// Create an object to store all available base layers for the layer control
var baseLayers = {
    "Standard": osmLayer,
    "Satellittbilde": satelliteLayer,
    "Topografisk": topoLayer,
    "Turkart": turLayer,
    "Sjøkart": sjoLayer
};

// Track which tile layer is currently active, default to "Standard"
var activeTileLayer = "Standard"; // Default layer

// Event listener to update the active tile layer when user switches layers
map.on('baselayerchange', function (event) {
    activeTileLayer = event.name;
});

// Getter function to retrieve the currently active tile layer
function getActiveTileLayer() {
    return activeTileLayer;
}

// Add layer control to the map in top-left position
var layerControl = L.control.layers(baseLayers, null, { position: 'topleft' }).addTo(map);

// Apply custom CSS classes to the layer control for styling
L.DomUtil.addClass(layerControl.getContainer(), 'custom-layer-control');
L.DomUtil.addClass(layerControl.getContainer(), 'custom-fa-icon');

// Get the toggle button from the layer control
var toggleButton = layerControl.getContainer().querySelector('.leaflet-control-layers-toggle');


// Add a header to the layers list
var toggleButtons = layerControl.getContainer().querySelector('.custom-layer-control .leaflet-control-layers-list');
var header = document.createElement('h4');
header.classList.add("Kartgrunnlagheader");
header.innerHTML = 'Kartgrunnlag';
toggleButtons.prepend(header);

// Set the default map layer
map.addLayer(osmLayer);

// Initialize a FeatureGroup to store all editable layers (shapes, markers, etc.)
var drawnItems = new L.FeatureGroup();
map.addLayer(drawnItems);

// Flags to track editing state and current drawing mode
var isEditing = false;
var currentMode = null;

// Initialize GeoJSON object to store all shape data
var geoJsonData = {
    type: "FeatureCollection",
    features: []
};

// Function to toggle the visibility of the shapes list panel
function toggleShapesList() {
    var shapesList = document.getElementById('shapes-list-scroll');
    var toggleButton = document.getElementById('toggle-shapes-list');
    var icon = toggleButton.querySelector('i');

    if (shapesList.style.display === 'none' || shapesList.style.display === '') {
        shapesList.style.display = 'block';
        icon.className = 'fa-solid fa-chevron-down';
    } else {
        shapesList.style.display = 'none';
        icon.className = 'fa-solid fa-chevron-up';
    }
}

// Add click event listener for the shapes list toggle button
document.getElementById('toggle-shapes-list').addEventListener('click', toggleShapesList);

// Get reference to the comment modal
var commentModal = document.getElementById('comment-modal');
var currentLayer;

// Function to display the comment modal for adding/editing shape comments
function showCommentModal(layer, existingComment = null) {
    currentLayer = layer;
    commentModal.style.display = 'flex'; // Show the modal
    var commentInput = document.getElementById('comment-input');
    if (existingComment) {
        commentInput.value = existingComment;
        isEditing = true;
    } else {
        commentInput.value = '';
        isEditing = false;
    }
    commentInput.focus(); // Focus on the input field
}

// Function to hide the comment modal
function hideCommentModal(removeLayer = false) {
    commentModal.style.display = 'none'; // Hide the modal
    document.getElementById('comment-input').value = ''; // Clear the input field

    // Remove the layer if specified (for cancel action) and not editing
    if (removeLayer && !isEditing && currentLayer) {
        drawnItems.removeLayer(currentLayer);
    }

    currentLayer = null; // Reset currentLayer
    isEditing = false; // Reset editing state
}

// Event handlers for the comment modal buttons
document.getElementById('cancel-comment').addEventListener('click', function () {
    hideCommentModal(true); // Pass true to remove the layer on cancel
});

// Function to show the modal for editing an existing comment
function showEditCommentModal(layer, existingComment) {
    showCommentModal(layer, existingComment);
}

// Function to handle editing an existing correction
function editCorrection(id) {
    var feature = geoJsonData.features.find(f => f.properties.id === id);
    if (feature) {
        var layer = drawnItems.getLayer(id);
        if (layer) {
            // Show the modal for editing the current comment
            showEditCommentModal(layer, feature.properties.comment);
        }
    }
}

// Attach event listeners to modal buttons
document.getElementById('cancel-comment').addEventListener('click', function () {
    hideCommentModal(!isEditing); // Only remove layer if not editing
});

// Add event listener for comment submission
document.getElementById('submit-comment').addEventListener('click', function () {
    var comment = document.getElementById('comment-input').value.trim();
    if (comment) {
        var timestamp = getCurrentTimestamp();


        if (isEditing) {
            // Update existing feature
            var feature = geoJsonData.features.find(f => f.properties.id === L.stamp(currentLayer));
            if (feature) {
                feature.properties.comment = comment;
                feature.properties.lastEdited = timestamp;
            }
        } else {
            // Create new feature
            var feature = geoJsonData.features.find(f => f.properties.id === L.stamp(currentLayer));
            if (feature) {
                feature.properties.comment = comment;
            }
        }

        // Update the popup content for the layer
        var popupContent = `<strong>ID: ${L.stamp(currentLayer)}</strong><br>${comment}<br><small>Sist endret: ${timestamp}</small>`;
        currentLayer.bindPopup(popupContent, { className: 'wrapped-popup' });

        updateShapesList(); // Refresh the shapes list
        hideCommentModal(); // Hide the modal after submitting
    }
});

// Function to display the shape selection popup when user clicks on map
function showShapeSelectionPopup(latlng) {
    var popupContent = L.DomUtil.create('div', 'shape-selection-popup');
    // Create buttons for different shape types with icons and tooltips
    popupContent.innerHTML = `
        <button class="shape-button" id="markershapebutton"   data-shape="Marker" title="Best for å vise nøyaktig punkt">      <i class="fa-solid fa-location-dot"></i> Markør  </button>
        <button class="shape-button" id="circleshapebutton"   data-shape="Circle" title="Best for å vise ngenerelt område">      <i class="fa-regular fa-circle"></i>     Sirkel  </button>
        <button class="shape-button" id="polylineshapebutton" data-shape="Polyline" title="Best for å vise ">    <i class="fa-solid fa-minus"></i>        Linje   </button>
        <button class="shape-button" id="polygonshapebutton"  data-shape="Polygon" title="Best for å markere grensene for feilen">     <i class="fa-solid fa-diamond"></i>      Polygon </button>
    `;

    // Add click event listeners to each shape button
    var buttons = popupContent.querySelectorAll('.shape-button');
    buttons.forEach(function (button) {
        L.DomEvent.on(button, 'click', function (e) {
            L.DomEvent.stopPropagation(e);
            selectShape(this.getAttribute('data-shape'), latlng);
        });
    });

    // Show the popup at the clicked location
    var popup = L.popup()
        .setLatLng(latlng)
        .setContent(popupContent)
        .openOn(map);
}

// Function to initialize drawing mode for the selected shape type
function selectShape(shapeType, latlng) {
    map.closePopup();

    // Configure drawing options based on shape type
    var drawOptions = {
        marker: shapeType === 'Marker' ? { startingPoint: latlng } : false,
        circle: shapeType === 'Circle',
        polyline: shapeType === 'Polyline',
        polygon: shapeType === 'Polygon',
        rectangle: false,
        circlemarker: false
    };

    // Enable drawing mode for the selected shape type
    var shape = new L.Draw[shapeType](map, drawOptions[shapeType.toLowerCase()]);
    shape.enable();

    currentMode = shapeType;

    // Reset currentMode if drawing doesn't start within 500ms
    setTimeout(function () {
        if (currentMode === shapeType) {
            currentMode = null;
        }
    }, 500);
}

// Show shape selection popup when clicking on the map (if not already drawing)
map.on('click', function (e) {
    if (!currentMode) {
        showShapeSelectionPopup(e.latlng);
    }
});

// Handle newly created shapes
map.on(L.Draw.Event.CREATED, function (event) {
    var layer = event.layer;
    var type = event.layerType;
    var feature = layer.toGeoJSON();
    var shapeId = L.stamp(layer);

    // Set common properties for the new feature
    feature.properties = {
        id: shapeId,
        type: type,
        addedAt: getCurrentFormattedTimestamp(),
        lastEdited: getCurrentFormattedTimestamp()
    };

    // Handle specific properties for different shape types
    switch (type) {
        case 'circle':
            feature.properties.radius = layer.getRadius();
            feature.geometry.type = "Point";
            feature.geometry.coordinates = [layer.getLatLng().lng, layer.getLatLng().lat];
            break;
        case 'marker':
            feature.properties.type = 'point';
            break;
    }

    // Add the new shape to the drawing layer and GeoJSON data
    drawnItems.addLayer(layer);
    geoJsonData.features.push(feature);

    // Prompt for comment
    showCommentModal(layer);

    // Reset drawing mode
    currentMode = null;
});

// Reset drawing mode when drawing starts
map.on(L.Draw.Event.DRAWSTART, function (event) {
    // Drawing started - no specific action needed
});

// Reset drawing mode when drawing stops
map.on('draw:drawstop', function () {
    currentMode = null;
});

// Function to remove a shape and its data
function deleteCorrection(id) {
    var featureIndex = geoJsonData.features.findIndex(f => f.properties.id === id);
    if (featureIndex !== -1) {
        var layer = drawnItems.getLayer(id);
        if (layer) {
            drawnItems.removeLayer(layer);
        }
        geoJsonData.features.splice(featureIndex, 1);
        updateShapesList();
    }
}

// Handle edited shapes
map.on(L.Draw.Event.EDITED, function (e) {
    var layers = e.layers;
    layers.eachLayer(function (layer) {
        var id = L.stamp(layer);
        var feature = geoJsonData.features.find(f => f.properties.id === id);
        if (feature) {
            // Update the geometry
            feature.geometry = layer.toGeoJSON().geometry;
            // Prompt for updated comment
            var newComment = prompt("Oppdater kommentar for denne formen:", feature.properties.comment);
            if (newComment) {
                feature.properties.comment = newComment;
                feature.properties.lastEdited = getCurrentTimestamp();
                // Update the popup
                var popupContent = `<strong>ID: ${id}</strong><br>${newComment}<br><small>Sist endret: ${feature.properties.lastEdited}</small>`;
                layer.bindPopup(popupContent, { className: 'wrapped-popup' });
            }
        }
    });
    updateShapesList();
});

// Handle deleted shapes
map.on(L.Draw.Event.DELETED, function (e) {
    var layers = e.layers;
    layers.eachLayer(function (layer) {
        var id = L.stamp(layer);
        // Remove the feature from GeoJSON data
        geoJsonData.features = geoJsonData.features.filter(f => f.properties.id !== id);
    });
    updateShapesList();
});

// Initialize the page when DOM is loaded
document.addEventListener('DOMContentLoaded', function () {
    // Remove welcome overlay when button is clicked
    const button = document.querySelector('#welcometext button');
    button.addEventListener('click', function () {
        const overlay = document.getElementById('startupoverlay');
        overlay.remove();
    });

    // Initialize the shapes list
    updateShapesList();

    // Set initial state of shapes list (hidden) and toggle button
    var shapesList = document.getElementById('shapes-list-scroll');
    var toggleButton = document.getElementById('toggle-shapes-list');
    var icon = toggleButton.querySelector('i');

    shapesList.style.display = 'none';
    icon.className = 'fa-solid fa-chevron-up';
});

// Add click event listener for shapes list toggle
document.getElementById('toggle-shapes-list').addEventListener('click', toggleShapesList);

// Function to update the list of shapes displayed in the UI
function updateShapesList() {
    var listContainer = document.getElementById('shapes-list');
    var toggleButton = document.getElementById('toggle-shapes-list');
    var icon = toggleButton.querySelector('i');
    listContainer.innerHTML = '';

    // Show message if no shapes exist
    if (geoJsonData.features.length === 0) {
        listContainer.innerHTML = '<p class="shapes-list-empty">Ingen kommentarer enda. <br> Trykk på kartet for å starte</p>';
    } else {
        // Create list of shapes with their properties
        var ul = document.createElement('ul');
        ul.className = 'shapes-list-ul';
        ul.style.listStyleType = 'none';
        ul.style.padding = '0';
        geoJsonData.features.forEach(function (feature) {
            var li = document.createElement('li');
            li.className = 'shapes-list-item';
            var shapeType = feature.properties.type;
            var shapeInfo = '';

            // Translate shape types to Norwegian
            switch (shapeType) {
                case 'circle':
                    shapeType = 'Sirkel';
                    shapeInfo = `Radius: ${feature.properties.radius} meter`;
                    break;
                case 'marker':
                case 'p oint':
                    shapeType = 'Markør';
                    break;
                case 'polyline':
                    shapeType = 'Linje';
                    break;
                case 'polygon':
                    shapeType = 'Polygon';
                    break;
            }

            // Create HTML for shape list item
            li.innerHTML = `
            <div class="shapes-list-type"><strong>${shapeType}</strong> (ID: ${feature.properties.id})</div>
            <div class="shapes-list-comment">${feature.properties.comment || 'No comment'}</div>
            ${shapeInfo ? `<div class="shapes-list-info">${shapeInfo}</div>` : ''}
            <div class="shapes-list-timestamp"><small>Lagt til: ${feature.properties.addedAt}</small></div>
            <div class="shapes-list-timestamp"><small>Sist endret: ${feature.properties.lastEdited}</small></div>
            <div class="shapes-list-buttons">
                <button class="shapes-list-button" onclick="editCorrection(${feature.properties.id})">Rediger</button>
                <button class="shapes-list-button" onclick="deleteCorrection(${feature.properties.id})">Slett</button>
            </div>
        `;
            // Add click handler to pan to shape location
            li.onclick = function (e) {
                if (e.target.tagName !== 'BUTTON') {
                    var layer = drawnItems.getLayer(feature.properties.id);
                    if (layer) {
                        if (layer.getBounds) {
                            map.fitBounds(layer.getBounds());
                        } else if (layer.getLatLng) {
                            map.setView(layer.getLatLng(), 16);
                        }
                        if (layer.getPopup()) layer.openPopup();
                    }
                }
            };
            ul.appendChild(li);
        });
        listContainer.appendChild(ul);
    }

    // Update hidden input with current shape data
    document.getElementById('shapeData').value = JSON.stringify(geoJsonData);

    // Log updated data for debugging
    console.log("Updated GeoJSON data:", geoJsonData);

    // Show shapes list and update toggle button
    document.getElementById('shapes-list-scroll').style.display = 'block';
    document.getElementById('toggle-shapes-list').querySelector('i').className = 'fa-solid fa-chevron-down';
}

// Custom prompt modal function for better user experience
function customPrompt(message, callback) {
    // Display the modal and set the message
    const modal = document.getElementById("customPromptModal");
    const messageElement = document.getElementById("customPromptMessage");
    messageElement.innerText = message;

    // Clear previous input
    const input = document.getElementById("customPromptInput");
    input.value = "";

    // Show the modal
    modal.style.display = "flex";

    // Handle OK button click
    document.getElementById("customPromptOkButton").onclick = function () {
        modal.style.display = "none";
        callback(input.value);
    };

    // Handle Cancel button click
    document.getElementById("customPromptCancelButton").onclick = function () {
        modal.style.display = "none";
        callback(null);
    };
}

// Handle form submission for saving shapes
document.getElementById('shapeForm').addEventListener('submit', function (e) {
    e.preventDefault();

    if (geoJsonData.features.length > 0) {
        // Prompt for submission name
        customPrompt("Gi innmeldingen et navn:", function (submissionComment) {
            if (submissionComment === null) {
                // User cancelled
                return;
            }

            // Get active tile layer and prepare submission data
            var activeTileLayer = getActiveTileLayer();
            geoJsonData.activeTileLayer = activeTileLayer;

            submission.id = Date.now();
            submission.comment = submissionComment;
            submission.timestamp = getCurrentTimestamp();
            submission.geoJsonData = geoJsonData;

            // Update form data and submit
            document.getElementById('shapeData').value = JSON.stringify(submission);
            document.getElementById('shapeForm').submit();
        });
    } else {
        alert('Ingen figurer å lagre. Legg til en figur før du fortsetter.');
    }
});

/** 
// Add event listener for form submission
document.getElementById('shapeForm').addEventListener('submit', function (e) {
    e.preventDefault(); // Prevent default form submission

    // Ensure shapeData is not empty before submitting
    if (geoJsonData.features.length > 0) {
        // Prompt user for a submission comment
        var submissionComment = prompt("Gi innmeldingen et navn:");
        if (submissionComment === null) {
            // User cancelled the prompt
            return;
        }

        // Get the active tile layer
        var activeTileLayer = getActiveTileLayer();

        // Add the active tile layer to the geoJsonData
        geoJsonData.activeTileLayer = activeTileLayer;

        // Create the submission object
        submission.id = Date.now(); // Use timestamp as ID
        submission.comment = submissionComment;
        submission.timestamp = formatTimestamp(new Date().toISOString());
        submission.geoJsonData = geoJsonData;

        // Update the hidden input field with the submission data
        document.getElementById('shapeData').value = JSON.stringify(submission);

        this.submit(); // Submit the form
    } else {
        alert('Ingen figurer å lagre. Legg til en figur før du fortsetter.');
    }
});

*/

// Helper function to get GeoJSON type from layer
function getGeoJSONType(layer) {
    if (layer instanceof L.Marker) {
        return "Point";
    } else if (layer instanceof L.Circle) {
        return "Point"; // Circles are treated as points with radius
    } else if (layer instanceof L.Polygon) {
        return "Polygon";
    } else if (layer instanceof L.Polyline) {
        return "LineString";
    }
    return "Unknown";
}

// Initialize submission object structure
var submission = {
    id: null,
    comment: '',
    timestamp: null,
    geoJsonData: {
        type: "FeatureCollection",
        features: []
    }
};



// Add custom zoom control buttons
document.getElementById('zoom-in').onclick = function () {
    map.zoomIn();
};
document.getElementById('zoom-in').title = "Zoom inn";
document.getElementById('zoom-out').onclick = function () {
    map.zoomOut();
};
document.getElementById('zoom-out').title = "Zoom ut";

// Custom locate control for finding user's location
L.Control.LocateButton = L.Control.extend({
    options: {
        position: 'bottomright'
    },

    onAdd: function (map) {
        var self = this;
        var container = L.DomUtil.create('div', 'leaflet-bar leaflet-control leaflet-control-locate');
        this._button = L.DomUtil.create('a', 'locate-button', container);
        this._button.innerHTML = '<i class="fa-solid fa-location-crosshairs"></i>'; // Font Awesome icon
        this._button.href = '#';
        this._button.title = 'Sentrer på min plassering';

        // Add loading indicator
        this._loadingIndicator = L.DomUtil.create('div', 'loading-indicator', container);
        this._loadingIndicator.innerHTML = '<i class="fa-solid fa-spinner fa-spin"></i>'; // Font Awesome spinner icon
        this._loadingIndicator.style.display = 'none'; // Hide by default

        // Handle locate button click
        L.DomEvent.on(this._button, 'click', function (e) {
            L.DomEvent.stop(e);  // Stops propagation to prevent clicking map
            self._button.style.display = 'none';
            self._loadingIndicator.style.display = 'flex';
            map.locate({ setView: true, maxZoom: 16 });
        });

        // Handle successful location found
        map.on('locationfound', function (e) {
            self._button.style.display = 'flex';
            self._loadingIndicator.style.display = 'none';

            // Update location marker and accuracy circle
            if (userLocMarker) {
                map.removeLayer(userLocMarker);
            }
            if (userLocCircle) {
                map.removeLayer(userLocCircle);
            }

            // Calculate accuracy radius and add location marker with circle
            var radius = e.accuracy / 2;
            userLocMarker = L.marker(e.latlng, { icon: userLocIcon }).addTo(map)
                .bindPopup("Du er innen " + radius + " meter fra dette punktet").openPopup();
            userLocCircle = L.circle(e.latlng, radius).addTo(map);
        });

        // Handle location error
        map.on('locationerror', function (e) {
            self._button.style.display = 'flex';
            self._loadingIndicator.style.display = 'none';
            alert("Lokasjon tillatelser nektet, eller ikke tilgjengelige.");
        });

        return container;
    }
});

// Add the location control to the map
map.addControl(new L.Control.LocateButton());

// Variables to store user location marker and accuracy circle
var userLocMarker;
var userLocCircle;

// Custom icon for user location marker
const userLocIcon = L.divIcon({
    html: '<i class="fa-solid fa-location-dot fa-2xl" style="color: #28a745;"></i>',
    className: 'userLocIcon',
    iconSize: [27, 36],
    popupAnchor: [0, -20],
});

// Add geocoder control for location search functionality
var geocoder = L.Control.geocoder({
    defaultMarkGeocode: false, // Disable default marker
    placeholder: "Søk..."
}).addTo(map);

// Add tooltip to geocoder control
geocoder.getContainer().setAttribute('title', 'Søk etter steder');

// Handle geocoding results
geocoder.on('markgeocode', function (e) {
    var latlng = e.geocode.center;
    map.setView(latlng, 16); // Zoom to location
    L.marker(latlng).addTo(map) // Add marker
        .bindPopup(e.geocode.name)
        .openPopup();
});


// Function to get current timestamp in ISO format
function getCurrentTimestamp() {
    const now = new Date();
    console.log("Fetched current datetime:", now);
    return now.toISOString();
}

// Function to format timestamps for display
function formatTimestamp(isoString) {
    // If no timestamp provided, use current time
    if (!isoString) {
        const now = new Date();
        return now.toLocaleString('en-US', {
            year: 'numeric',
            month: '2-digit',
            day: '2-digit',
            hour: '2-digit',
            minute: '2-digit',
            second: '2-digit',
            hour12: false
        }).replace(/(\d+)\/(\d+)\/(\d+)/, '$2/$1/$3'); // Convert from MM/DD/YYYY to DD/MM/YYYY
    }

    // Format provided timestamp
    const date = new Date(isoString);
    return date.toLocaleString('en-US', {
        year: 'numeric',
        month: '2-digit',
        day: '2-digit',
        hour: '2-digit',
        minute: '2-digit',
        second: '2-digit',
        hour12: false
    }).replace(/(\d+)\/(\d+)\/(\d+)/, '$2/$1/$3'); // Convert from MM/DD/YYYY to DD/MM/YYYY
}

// Helper function to get current formatted timestamp
function getCurrentFormattedTimestamp() {
    return formatTimestamp(new Date().toISOString());
}