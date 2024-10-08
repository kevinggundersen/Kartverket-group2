// Initialize the map
var map = L.map('map', { zoomControl: false }).setView([58.1599, 8.0182], 13);



// Add map tilelayers (Map images)
var osmLayer = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '© OpenStreetMap contributors'
});
var satelliteLayer = L.tileLayer('https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}', {
    attribution: 'Tiles &copy; Esri &mdash; Source: Esri, i-cubed, USDA, USGS, AEX, GeoEye, Getmapping, Aerogrid, IGN, IGP, UPR-EGP, and the GIS User Community'
});
var topoLayer = L.tileLayer('https://{s}.tile.opentopomap.org/{z}/{x}/{y}.png', {
    attribution: 'Map data: © OpenStreetMap contributors, SRTM | Map style: © OpenTopoMap (CC-BY-SA)'
});

// Create a layer control object
var baseLayers = {
    "Standard": osmLayer,
    "Satellittbilde": satelliteLayer,
    "Topografisk": topoLayer
};

// Add the layer control to the map with a custom position
var layerControl = L.control.layers(baseLayers, null, { position: 'topleft' }).addTo(map);

// Add a custom CSS class to the layer control
L.DomUtil.addClass(layerControl.getContainer(), 'custom-layer-control');
L.DomUtil.addClass(layerControl.getContainer(), 'custom-fa-icon');

// Add the Font Awesome icon
var toggleButton = layerControl.getContainer().querySelector('.leaflet-control-layers-toggle');
var icon = document.createElement('i');
icon.className = 'fa-solid fa-layer-group';
toggleButton.appendChild(icon);

// Add header to list of layers
var toggleButtons = layerControl.getContainer().querySelector('.custom-layer-control .leaflet-control-layers-list');
var header = document.createElement('h4');
header.classList.add("Kartgrunnlagheader");
header.innerHTML = 'Kartgrunnlag';
toggleButtons.prepend(header);

// Set the default layer
map.addLayer(osmLayer);

// Initialize the FeatureGroup to store editable layers
var drawnItems = new L.FeatureGroup();
map.addLayer(drawnItems);

// Variable to track whether user is editing or creating a new shape
var isEditing = false;

// Variable to store the current drawing mode
var currentMode = null;

// Initialize GeoJSON object to store shape information
var geoJsonData = {
    type: "FeatureCollection",
    features: []
};

// Function to toggle the shapes list
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

// Event listener for the toggle button
document.getElementById('toggle-shapes-list').addEventListener('click', toggleShapesList);

// Create a modal dialog for comments
var commentModal = document.getElementById('comment-modal');
var currentLayer;

// Function to get current timestamp
function getCurrentTimestamp() {
    return new Date().toISOString();
}

// Function to format timestamps
function formatTimestamp(isoString) {
    const date = new Date(isoString);
    const dateOptions = { year: 'numeric', month: 'short', day: 'numeric' };
    const timeOptions = { hour: '2-digit', minute: '2-digit', second: '2-digit', hour12: false };
    return `${date.toLocaleDateString('nb-NO', dateOptions)} ${date.toLocaleTimeString('nb-NO', timeOptions)}`;
}

// Function to show the comment modal
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

// Attach event listeners to modal buttons
document.getElementById('cancel-comment').addEventListener('click', function () {
    hideCommentModal(true); // Pass true to remove the layer on cancel
});

// Function to show the modal for editing a comment
function showEditCommentModal(layer, existingComment) {
    showCommentModal(layer, existingComment);
}

// Edit the existing marker's comment
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

// Creation of the GeoJSON feature
document.getElementById('submit-comment').addEventListener('click', function () {
    var comment = document.getElementById('comment-input').value.trim();
    if (comment) {
        var timestamp = getCurrentTimestamp();
        var formattedTimestamp = formatTimestamp(timestamp);

        if (isEditing) {
            // Update existing feature
            var feature = geoJsonData.features.find(f => f.properties.id === L.stamp(currentLayer));
            if (feature) {
                feature.properties.comment = comment;
                feature.properties.lastEdited = formattedTimestamp;
            }
        } else {
            // Update the comment for the new feature
            var feature = geoJsonData.features.find(f => f.properties.id === L.stamp(currentLayer));
            if (feature) {
                feature.properties.comment = comment;
            }
        }

        var popupContent = `<strong>ID: ${L.stamp(currentLayer)}</strong><br>${comment}<br><small>Sist endret: ${formattedTimestamp}</small>`;
        currentLayer.bindPopup(popupContent, { className: 'wrapped-popup' });

        updateShapesList(); // Refresh the shapes list
        hideCommentModal(); // Hide the modal after submitting
    }
});

// Function to show shape selection popup
function showShapeSelectionPopup(latlng) {
    var popupContent = L.DomUtil.create('div', 'shape-selection-popup');
    popupContent.innerHTML = `
        <button class="shape-button" id="markershapebutton"   data-shape="Marker">      <i class="fa-solid fa-location-dot"></i> Markør  </button>
        <button class="shape-button" id="circleshapebutton"   data-shape="Circle">      <i class="fa-regular fa-circle"></i>     Sirkel  </button>
        <button class="shape-button" id="polylineshapebutton" data-shape="Polyline">    <i class="fa-solid fa-minus"></i>        Linje   </button>
        <button class="shape-button" id="polygonshapebutton"  data-shape="Polygon">     <i class="fa-solid fa-diamond"></i>      Polygon </button>
    `;

    // Add click event listeners to buttons
    var buttons = popupContent.querySelectorAll('.shape-button');
    buttons.forEach(function (button) {
        L.DomEvent.on(button, 'click', function (e) {
            L.DomEvent.stopPropagation(e);
            selectShape(this.getAttribute('data-shape'), latlng);
        });
    });

    var popup = L.popup()
        .setLatLng(latlng)
        .setContent(popupContent)
        .openOn(map);
}

// Function to select shape and start drawing
function selectShape(shapeType, latlng) {
    map.closePopup();

    var drawOptions = {
        marker: shapeType === 'Marker' ? { startingPoint: latlng } : false,
        circle: shapeType === 'Circle',
        polyline: shapeType === 'Polyline',
        polygon: shapeType === 'Polygon',
        rectangle: false,
        circlemarker: false
    };

    var shape = new L.Draw[shapeType](map, drawOptions[shapeType.toLowerCase()]);
    shape.enable();

    currentMode = shapeType;

    // Add timeout to reset currentMode if drawing doesn't start
    setTimeout(function () {
        if (currentMode === shapeType) {
            currentMode = null;
        }
    }, 500);
}

// Event handler for map clicks
map.on('click', function (e) {
    if (!currentMode) {
        showShapeSelectionPopup(e.latlng);
    }
});

// Event handler for when a shape is created
map.on(L.Draw.Event.CREATED, function (event) {
    var layer = event.layer;
    var type = event.layerType;
    var feature = layer.toGeoJSON();
    var shapeId = L.stamp(layer);

    // Set common properties
    feature.properties = {
        id: shapeId,
        type: type,
        addedAt: formatTimestamp(getCurrentTimestamp()),
        lastEdited: formatTimestamp(getCurrentTimestamp())
    };

    // Handle specific shape types
    switch (type) {
        case 'circle':
            feature.properties.radius = layer.getRadius();
            feature.geometry.type = "Point";
            feature.geometry.coordinates = [layer.getLatLng().lng, layer.getLatLng().lat];
            break;
        case 'marker':
            feature.properties.type = 'point';
            break;
        // Add cases for other shape types if needed
    }

    drawnItems.addLayer(layer);
    geoJsonData.features.push(feature);

    // Show the custom comment modal
    showCommentModal(layer);

    // Reset the drawing mode
    currentMode = null;
});

// Event handler when drawing starts
map.on(L.Draw.Event.DRAWSTART, function (event) {
    // No need to store the draw control
});

// Event handler when drawing stops
map.on('draw:drawstop', function () {
    currentMode = null;
});

// Function to delete a correction
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

// Add event listener for editingshapes
map.on(L.Draw.Event.EDITED, function (e) {
    var layers = e.layers;
    layers.eachLayer(function (layer) {
        var id = L.stamp(layer);
        var feature = geoJsonData.features.find(f => f.properties.id === id);
        if (feature) {
            // Update the geometry of the feature
            feature.geometry = layer.toGeoJSON().geometry;
            // Prompt for comment update
            var newComment = prompt("Oppdater kommentar for denne formen:", feature.properties.comment);
            if (newComment) {
                feature.properties.comment = newComment;
                feature.properties.lastEdited = formatTimestamp(getCurrentTimestamp());
                // Update popup
                var popupContent = `<strong>ID: ${id}</strong><br>${newComment}<br><small>Sist endret: ${feature.properties.lastEdited}</small>`;
                layer.bindPopup(popupContent, { className: 'wrapped-popup' });
            }
        }
    });
    updateShapesList();
});

map.on(L.Draw.Event.DELETED, function (e) {
    var layers = e.layers;
    layers.eachLayer(function (layer) {
        var id = L.stamp(layer);
        geoJsonData.features = geoJsonData.features.filter(f => f.properties.id !== id);
    });
    updateShapesList();
});

// Remove overlay when button pressed
document.addEventListener('DOMContentLoaded', function () {
    const button = document.querySelector('#welcometext button');
    button.addEventListener('click', function () {
        const overlay = document.getElementById('startupoverlay');
        overlay.remove();
    });

    // Initialize the shapes list
    updateShapesList();

    // Initially hide the shapes list and set the correct icon
    var shapesList = document.getElementById('shapes-list-scroll');
    var toggleButton = document.getElementById('toggle-shapes-list');
    var icon = toggleButton.querySelector('i');

    shapesList.style.display = 'none';
    icon.className = 'fa-solid fa-chevron-up';
});

document.getElementById('toggle-shapes-list').addEventListener('click', toggleShapesList);



// Function to update the shapes list display
function updateShapesList() {
    var listContainer = document.getElementById('shapes-list');
    var toggleButton = document.getElementById('toggle-shapes-list');
    var icon = toggleButton.querySelector('i');
    listContainer.innerHTML = '';
    if (geoJsonData.features.length === 0) {
        listContainer.innerHTML = '<p class="shapes-list-empty">Ingen kommentarer enda. <br> Trykk på kartet for å starte</p>';
    } else {
        var ul = document.createElement('ul');
        ul.className = 'shapes-list-ul';
        ul.style.listStyleType = 'none';
        ul.style.padding = '0';
        geoJsonData.features.forEach(function (feature) {
            var li = document.createElement('li');
            li.className = 'shapes-list-item';
            var shapeType = feature.properties.type;
            var shapeInfo = '';

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
            // Pan to shape when clicked in list
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

    // Update the hidden input field with the current shape data
    document.getElementById('shapeData').value = JSON.stringify(geoJsonData);

    console.log("Updated GeoJSON data:", geoJsonData);

    // Show the shapes list after updating
    document.getElementById('shapes-list-scroll').style.display = 'block';
    document.getElementById('toggle-shapes-list').querySelector('i').className = 'fa-solid fa-chevron-down';
}

// Add event listener for form submission
document.getElementById('shapeForm').addEventListener('submit', function (e) {
    e.preventDefault(); // Prevent default form submission

    // Ensure shapeData is not empty before submitting
    if (geoJsonData.features.length > 0) {
        // Prompt user for a submission comment
        var submissionComment = prompt("Please enter a comment for this submission:");
        if (submissionComment === null) {
            // User cancelled the prompt
            return;
        }

        // Create the submission object
        submission.id = Date.now(); // Use timestamp as ID
        submission.comment = submissionComment;
        submission.timestamp = new Date().toISOString();
        submission.geoJsonData = geoJsonData;

        // Update the hidden input field with the submission data
        document.getElementById('shapeData').value = JSON.stringify(submission);

        this.submit(); // Submit the form
    } else {
        alert('Ingen figurer å lagre. Legg til en figur før du fortsetter.');
    }
});


// Function to get GeoJSON type from layer
function getGeoJSONType(layer) {
    if (layer instanceof L.Marker) {
        return "Point";
    } else if (layer instanceof L.Circle) {
        return "Point"; // We'll treat circles as points with a radius property
    } else if (layer instanceof L.Polygon) {
        return "Polygon";
    } else if (layer instanceof L.Polyline) {
        return "LineString";
    }
    return "Unknown";
}


var submission = {
    id: null,
    comment: '',
    timestamp: null,
    geoJsonData: {
        type: "FeatureCollection",
        features: []
    }
};

// Add event listeners to custom zoom buttons
document.getElementById('zoom-in').onclick = function () {
    map.zoomIn();
};
document.getElementById('zoom-in').title = "Zoom inn";
document.getElementById('zoom-out').onclick = function () {
    map.zoomOut();
};
document.getElementById('zoom-out').title = "Zoom ut";

// Add a button to center on user's location
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

        this._loadingIndicator = L.DomUtil.create('div', 'loading-indicator', container);
        this._loadingIndicator.innerHTML = '<i class="fa-solid fa-spinner fa-spin"></i>'; // Font Awesome spinner icon
        this._loadingIndicator.style.display = 'none'; // Hide by default

        L.DomEvent.on(this._button, 'click', function (e) {
            L.DomEvent.stop(e);  // This stops propagation and prevents default behavior
            self._button.style.display = 'none'; // Hide the button
            self._loadingIndicator.style.display = 'flex'; // Show the loading indicator
            map.locate({ setView: true, maxZoom: 16 });
        });

        // Event handlers for location found and error
        map.on('locationfound', function (e) {
            self._button.style.display = 'flex'; // Show the button again
            self._loadingIndicator.style.display = 'none'; // Hide the loading indicator

            // Create or update the location marker and circle
            if (userLocMarker) {
                map.removeLayer(userLocMarker);
            }
            if (userLocCircle) {
                map.removeLayer(userLocCircle);
            }
            var radius = e.accuracy / 2;
            userLocMarker = L.marker(e.latlng, { icon: userLocIcon }).addTo(map)
                .bindPopup("Du er innen " + radius + " meter fra dette punktet").openPopup();
            userLocCircle = L.circle(e.latlng, radius).addTo(map);
        });

        map.on('locationerror', function (e) {
            self._button.style.display = 'flex'; // Show the button again
            self._loadingIndicator.style.display = 'none'; // Hide the loading indicator
            alert("Lokasjon tillatelser nektet, eller ikke tilgjengelige.");
        });

        return container;
    }
});

map.addControl(new L.Control.LocateButton());

// Add a button to center on user's location
var userLocMarker;
var userLocCircle;

//Custom icon to distinguish user location from other markers
const userLocIcon = L.divIcon({
    html: '<i class="fa-solid fa-location-dot fa-2xl" style="color: #28a745;"></i>',
    className: 'userLocIcon',
    iconSize: [27, 36],
    popupAnchor: [0, -20],
});

// Add the geocoder control (Search function)
var geocoder = L.Control.geocoder({
    defaultMarkGeocode: false, // Prevent default marker to allow custom behavior
    placeholder: "Søk..."
}).addTo(map);

geocoder.getContainer().setAttribute('title', 'Søk etter steder'); // Add text when hovering over button

geocoder.on('markgeocode', function (e) {
    var latlng = e.geocode.center;
    map.setView(latlng, 16); // Set the map view to the selected location
    L.marker(latlng).addTo(map) // Add a marker at the selected location
        .bindPopup(e.geocode.name)
        .openPopup();
});