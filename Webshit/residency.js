function submitFormC(event) {
    // Prevent the default form submission behavior
    event.preventDefault();
  
    // Validate the form input here
    var isValid = validateFormC(); // Call a function for form validation, which returns true if the form is valid
  
    if (isValid) {
        // If the input is valid, show the popup and send the form data using AJAX
        document.getElementById("popup").classList.add("open-popup");
  
        // Send form data using AJAX
        var formData = new FormData(event.target);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "residency.php", true);
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

function resetFormC() {
    document.getElementById("residencyForm").reset();
}

function validateFormC() {
    var name = document.getElementsByName("name")[0].value;
    var age = document.getElementsByName("age")[0].value;
    var date = document.getElementsByName("date")[0].value;
    var status = document.getElementById("statusSelect").value; // Get selected status

    if (name.trim() === "") {
        alert("Please enter your full name.");
        return false;
    }

    if (isNaN(age) || age.trim() === "") {
        alert("Please enter a valid age.");
        return false;
    }

    if (status === "Please select your status") { // Check if status is selected
        alert("Please select your civil status.");
        return false;
    }

    if (date.trim() === "") {
        alert("Please select a date.");
        return false;
    }

    return true;
}

function closePopup() {
    document.getElementById("popup").classList.remove("open-popup");
}

// Attach event listener for form submission
document.addEventListener("DOMContentLoaded", function() {
    var form = document.getElementById('residencyForm');
    form.addEventListener('submit', submitFormC);
});
