// form-validation.js
document.addEventListener("DOMContentLoaded", function() {
    var form = document.getElementById('residencyForm');
    form.addEventListener('submit', submitForm);
});

// Others option
function toggleOtherInput() {
    var purposeSelect = document.getElementById("purposeSelect");
    var otherInput = document.getElementById("otherInput");
    if (purposeSelect.value === "Others") {
        otherInput.style.display = "block";
    } else {
        otherInput.style.display = "none";
    }
}

// Reset inputboxes
function resetForm() {
    document.getElementById("residencyForm").reset();
}

// JavaScript
function submitForm(event) {
    // Prevent the default form submission behavior
    event.preventDefault();

    // Validate the form input here
    var isValid = validateForm(); // Call a function for form validation, which returns true if the form is valid

    if (isValid) {
        // Send form data using AJAX
        var formData = new FormData(event.target);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "rc.php", true);
        xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        xhr.onload = function() {
            if (xhr.status === 200) {
                // Form submission successful
                console.log("Form submitted successfully.");
                // Show the popup modal
                document.getElementById("popup").style.visibility = "visible";
                document.getElementById("popup").style.opacity = "1";
            } else {
                // Form submission failed
                console.log("Form submission failed.");
            }
        };
        xhr.send(new URLSearchParams(formData));
    }
}


function validateForm() {
    var name = document.getElementsByName("name")[0].value;


    // If all validations pass, return true
    return true;
}

    
function closePopup() {
    document.getElementById("popup").style.visibility = "hidden";
    document.getElementById("popup").style.opacity = "0";
}

// Corrected JavaScript for handling the Purpose Select dropdown
var purposeSelect = document.getElementById("purposeSelect"); // Correct method to access the select element
var otherInput = document.getElementById("otherInput");
otherInput.style.display = "none"; // Initially hide the other input

purposeSelect.addEventListener("change", function() {
    if (this.value === "Others") {
        otherInput.style.display = "block";
    } else {
        otherInput.style.display = "none";
    }
});