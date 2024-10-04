// Initialize the map
var map = L.map('map', { zoomControl: false }).setView([58.1599, 8.0182], 13);

// Add event listeners to custom zoom buttons
document.getElementById('zoom-in').onclick = function () {
    map.zoomIn();
};
document.getElementById('zoom-in').title = "Zoom inn";
document.getElementById('zoom-out').onclick = function () {
    map.zoomOut();
};
document.getElementById('zoom-out').title = "Zoom ut";

//Add map tilelayer (Map image)
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '© OpenStreetMap contributors'
}).addTo(map);

// Initialize the FeatureGroup to store editable layers
var drawnItems = new L.FeatureGroup();
map.addLayer(drawnItems);

// Variable to store the current drawing mode
var currentMode = null;

// Initialize an array to store shape information
var shapesList = [];

// Create a modal dialog for comments
var commentModal = document.getElementById('comment-modal');
var currentLayer;

// Function to get current timestamp
function getCurrentTimestamp() {
    return new Date().toISOString();
}

// Function to show the comment modal
function showCommentModal(layer) {
    currentLayer = layer;
    commentModal.style.display = 'flex'; // Show the modal
    document.getElementById('comment-input').focus(); // Focus on the input field
}

// Function to hide the comment modal
function hideCommentModal(removeLayer = false) {
    commentModal.style.display = 'none'; // Hide the modal
    document.getElementById('comment-input').value = ''; // Clear the input field

    // Remove the layer if specified (for cancel action)
    if (removeLayer && currentLayer) {
        drawnItems.removeLayer(currentLayer);
    }

    currentLayer = null; // Reset currentLayer
}

// Attach event listeners to modal buttons
document.getElementById('cancel-comment').addEventListener('click', function () {
    hideCommentModal(true); // Pass true to remove the layer on cancel
});

// Function to show the modal for editing a comment
function showEditCommentModal(layer, existingComment) {
    currentLayer = layer;
    document.getElementById('comment-input').value = existingComment; // Populate with existing comment
    commentModal.style.display = 'flex'; // Show the modal
    document.getElementById('comment-input').focus(); // Focus on the input field
}

// Edit the existing marker's comment
function editCorrection(id) {
    var shapeIndex = shapesList.findIndex(shape => shape.id === id);
    if (shapeIndex !== -1) {
        var shape = shapesList[shapeIndex];
        var layer = drawnItems.getLayer(id);
        if (layer) {
            // Show the modal for editing the current comment
            showEditCommentModal(layer, shape.comment);
        }
    }
}

// Attach event listeners to modal buttons
document.getElementById('cancel-comment').addEventListener('click', function () {
    hideCommentModal(true); // Remove the marker/shape on cancel
});

document.getElementById('submit-comment').addEventListener('click', function () {
    var comment = document.getElementById('comment-input').value.trim();
    if (comment) {
        var shapeId = L.stamp(currentLayer);
        var timestamp = getCurrentTimestamp();
        var popupContent = `<strong>ID: ${shapeId}</strong><br>${comment}<br><small>Last edited: ${timestamp}</small>`;
        currentLayer.bindPopup(popupContent, { className: 'wrapped-popup' });

        var shapeIndex = shapesList.findIndex(shape => shape.id === shapeId);

        if (shapeIndex !== -1) {
            // Update existing shape comment
            shapesList[shapeIndex].comment = comment;
            shapesList[shapeIndex].lastEdited = timestamp;
        } else {
            // If the shape is new, add it to the shapesList
            shapesList.push({
                id: shapeId,
                type: currentLayer instanceof L.Marker ? 'Markør' :
                    currentLayer instanceof L.Circle ? 'Sirkel' :
                        currentLayer instanceof L.Polygon ? 'Polygon' :
                            currentLayer instanceof L.Polyline ? 'Linje' : 'Unknown',
                coordinates: getCoordinates(currentLayer),
                comment: comment,
                addedAt: timestamp,
                lastEdited: timestamp
            });
        }

        updateShapesList(); // Refresh the shapes list
        hideCommentModal(); // Hide the modal after submitting
    }
});

// Function to show shape selection popup
function showShapeSelectionPopup(latlng) {
    var popupContent = L.DomUtil.create('div', 'shape-selection-popup');
    popupContent.innerHTML = `
        <button class="shape-button" id="markershapebutton"   data-shape="Marker">  <i class="fa-solid fa-location-dot"></i> Markør  </button>
        <button class="shape-button" id="circleshapebutton"   data-shape="Circle">  <i class="fa-regular fa-circle"></i>     Sirkel  </button>
        <button class="shape-button" id="polylineshapebutton" data-shape="Polyline">    <i class="fa-solid fa-minus"></i>    Linje   </button>
        <button class="shape-button" id="polygonshapebutton"  data-shape="Polygon"> <i class="fa-solid fa-diamond"></i>      Polygon </button>
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
    drawnItems.addLayer(layer);

    // Show the custom comment modal instead of using prompt()
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

// Function to delete a correction
function deleteCorrection(id) {
    var shapeIndex = shapesList.findIndex(shape => shape.id === id);
    if (shapeIndex !== -1) {
        var layer = drawnItems.getLayer(id);
        if (layer) {
            drawnItems.removeLayer(layer);
        }
        shapesList.splice(shapeIndex, 1);
        updateShapesList();
    }
}

// Add event listeners for editing and deleting shapes
map.on(L.Draw.Event.EDITED, function (e) {
    var layers = e.layers;
    layers.eachLayer(function (layer) {
        var id = L.stamp(layer);
        var index = shapesList.findIndex(shape => shape.id === id);
        if (index !== -1) {
            var newComment = prompt("Oppdater kommentar for denne formen:", shapesList[index].comment);
            if (newComment) {
                updateComment(id, newComment);
            }
        }
    });
});

map.on(L.Draw.Event.DELETED, function (e) {
    var layers = e.layers;
    layers.eachLayer(function (layer) {
        var id = L.stamp(layer);
        shapesList = shapesList.filter(shape => shape.id !== id);
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
});

document.getElementById('shapeForm').addEventListener('submit', function () {
    document.getElementById('shapeData').value = JSON.stringify(shapesList);
});

// Function to add a shape with a comment
function addShapeWithComment(layer, type, comment) {
    drawnItems.addLayer(layer);
    var shapeId = L.stamp(layer);
    var timestamp = getCurrentTimestamp();
    var popupContent = `<strong>ID: ${shapeId}</strong><br>${comment}<br><small>Added: ${timestamp}</small>`;
    layer.bindPopup(popupContent);

    var shapeInfo = {
        id: shapeId,
        type: type,
        coordinates: getCoordinates(layer),
        comment: comment,
        addedAt: timestamp,
        lastEdited: timestamp
    };

    shapesList.push(shapeInfo);
    console.log("Added shape:", shapeInfo);
}

// Function to get coordinates from a layer
function getCoordinates(layer) {
    if (layer instanceof L.Marker) {
        return JSON.stringify(layer.getLatLng());
    } else if (layer instanceof L.Circle) {
        return JSON.stringify({ center: layer.getLatLng(), radius: layer.getRadius() });
    } else if (layer instanceof L.Polygon || layer instanceof L.Polyline) {
        return JSON.stringify(layer.getLatLngs());
    }
    return "Unknown shape type";
}

// Add premade shapes
function addPremadeShapes() {
    // Clear existing shapes
    drawnItems.clearLayers();
    shapesList = [];

    // Marker
    var marker = L.marker([58.1599, 8.0182]);
    addShapeWithComment(marker, 'Markør', 'Dette er en markør');

    // Circle
    var circle = L.circle([58.1650, 8.0250], { radius: 500 });
    addShapeWithComment(circle, 'Sirkel', 'Dette er en sirkel');

    // Polyline
    var polyline = L.polyline([
        [58.1550, 8.0100],
        [58.1600, 8.0150],
        [58.1650, 8.0200]
    ]);
    addShapeWithComment(polyline, 'Linje', 'Dette er en linje');

    // Polygon
    var polygon = L.polygon([
        [58.1500, 8.0250],
        [58.1550, 8.0300],
        [58.1600, 8.0350],
        [58.1550, 8.0400]
    ]);
    addShapeWithComment(polygon, 'Polygon', 'Dette er en polygon');

    // Update the shapes list display
    updateShapesList();

    console.log("Shapes list after adding:", shapesList); // For debugging

    // Fit the map to show all shapes
    var group = new L.featureGroup(drawnItems.getLayers());
    map.fitBounds(group.getBounds().pad(0.1));
}

// Call the function to add premade shapes
addPremadeShapes();




// Function to update the shapes list display
function updateShapesList() {
    var listContainer = document.getElementById('shapes-list');
    listContainer.innerHTML = '';
    if (shapesList.length === 0) {
        listContainer.innerHTML = '<p>Ingen kommentarer enda.</p>';
        return;
    }
    var ul = document.createElement('ul');
    ul.style.listStyleType = 'none';
    ul.style.padding = '0';
    shapesList.forEach(function (shape) {
        var li = document.createElement('li');
        li.style.marginBottom = '10px';
        li.style.border = '1px solid #ddd';
        li.style.padding = '10px';
        li.style.borderRadius = '5px';
        li.innerHTML = `
            <div><strong>${shape.type}</strong> (ID: ${shape.id})</div>
            <div style="word-wrap: break-word; white-space: pre-wrap; margin: 5px 0;">${shape.comment}</div>
            <div><small>Added: ${shape.addedAt}</small></div>
            <div><small>Last edited: ${shape.lastEdited}</small></div>
            <div>
                <button onclick="editCorrection(${shape.id})">Rediger</button>
                <button onclick="deleteCorrection(${shape.id})">Slett</button>
            </div>
        `;
        li.onclick = function (e) {
            if (e.target.tagName !== 'BUTTON') {
                var layer = drawnItems.getLayer(shape.id);
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
    console.log("Updated shapes list:", shapesList);
}
