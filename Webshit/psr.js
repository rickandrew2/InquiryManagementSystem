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


// Reset inputboxes
function resetForm() {
    document.getElementById("psrForm").reset();
}

function submitFormD(event) {
    // Prevent the default form submission behavior
    event.preventDefault();
  
    // Validate the form input here
    var isValid = validateFormD(); // Call a function for form validation, which returns true if the form is valid
  
    if (isValid) {
        // If the input is valid, show the popup and send the form data using AJAX
        document.getElementById("popup").classList.add("open-popup");
  
        // Send form data using AJAX
        var formData = new FormData(event.target);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "psr.php", true);
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

  
  document.addEventListener("DOMContentLoaded", function() {
    var form = document.getElementById('psrForm');
    form.addEventListener('submit', submitFormD);
});
  
  function validateFormD() {
    // Perform form validation here
    // You can check if each input field meets the required criteria
    // Return true if the form is valid, otherwise return false
  
    var fullname = document.getElementsByName("fullname")[0].value;
    var address = document.getElementsByName("address")[0].value;
    var contactInfo = document.getElementsByName("contact_info")[0].value;
    var dob = document.getElementsByName("dob")[0].value;
    var natureOfRequest = document.getElementsByName("nature_of_request")[0].value;
    var specificServiceNeed = document.getElementsByName("psr_need")[0].value;
  
    if (fullname.trim() === "") {
        alert("Please enter your full name.");
        return false;
    }

    if (address.trim() === "") {
        alert("Please enter your address.");
        return false;
    }

    if (contactInfo.trim() === "") {
        alert("Please enter your contact information.");
        return false;
    }

    if (dob.trim() === "") {
        alert("Please enter your date of birth.");
        return false;
    }

    if (natureOfRequest.trim() === "") {
        alert("Please select the nature of your request.");
        return false;
    }

    if (specificServiceNeed.trim() === "") {
        alert("Please enter your specific service need.");
        return false;
    }

    return true;  // Only if all fields are valid
  }
    
function closePopup() {
      document.getElementById("popup").classList.remove("open-popup");
    }
  

 
  