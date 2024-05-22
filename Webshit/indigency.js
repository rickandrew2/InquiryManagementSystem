// form-validation.js
document.addEventListener("DOMContentLoaded", function () {
    var form = document.querySelector("form");
    form.addEventListener("submit", function (event) {
        var ageInput = document.querySelector('input[name="age"]');
        var age = ageInput.value;
        if (age < 0 || age > 120 || isNaN(age)) {
            alert("Please enter a valid age between 0 and 120.");
            event.preventDefault(); // Prevent form submission
        }
    });
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
    document.getElementById("indigencyForm").reset();
}

function submitForm(event) {
    // Prevent the default form submission behavior
    event.preventDefault();
  
    // Validate the form input here
    var isValid = validateForm(); // Call a function for form validation, which returns true if the form is valid
  
    if (isValid) {
        // If the input is valid, show the popup and send the form data using AJAX
        document.getElementById("popup").classList.add("open-popup");
  
        // Send form data using AJAX
        var formData = new FormData(event.target);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "indigency.php", true);
        xhr.onload = function() {
            if (xhr.status === 200) {
                // Form submission successful
                console.log("Form submitted successfully.");
            } else {
                // Form submission failed
                console.log("Form submission failed.");
            }
        };
        xhr.send(formData);
    }
  }
  
  
  function validateForm() {
    // Perform form validation here
    // You can check if each input field meets the required criteria
    // Return true if the form is valid, otherwise return false
  
    var name = document.getElementsByName("name")[0].value;
    var age = document.getElementsByName("age")[0].value;
    var parents = document.getElementsByName("Parents")[0].value;
    var motherName = document.getElementsByName("sitio")[0].value;
    var date = document.getElementsByName("date")[0].value;
    var purpose = document.getElementsByName("purpose")[0].value;
  
    // Example validation: Check if the name field is not empty
    if (name.trim() === "") {
        // Display an error message or perform any necessary action for invalid input
        alert("Please enter your full name.");
        return false;
    }
  
    // Perform similar checks for other fields
  
    // If all validations pass, return true
    return true;
  }
    
function closePopup() {
      document.getElementById("popup").classList.remove("open-popup");
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
 
  