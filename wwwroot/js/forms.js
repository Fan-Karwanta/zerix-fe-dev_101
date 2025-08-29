function togglePasswordVisibility(buttonId, fieldId) {
  var passwordField = document.getElementById(fieldId);
  var button = document.getElementById(buttonId);
  var icon = button.querySelector("i");

  if (passwordField.type === "password") {
    passwordField.type = "text";
    icon.classList.remove("bi-eye");
    icon.classList.add("bi-eye-slash");
  } else {
    passwordField.type = "password";
    icon.classList.remove("bi-eye-slash");
    icon.classList.add("bi-eye");
  }
}
function togglePasswordVisibilityFilled(buttonId, fieldId) {
  var passwordField = document.getElementById(fieldId);
  var button = document.getElementById(buttonId);
  var icon = button.querySelector("i");

  if (passwordField.type === "password") {
    passwordField.type = "text";
    icon.classList.remove("bi-eye-fill");
    icon.classList.add("bi-eye-slash-fill");
  } else {
    passwordField.type = "password";
    icon.classList.remove("bi-eye-slash-fill");
    icon.classList.add("bi-eye-fill");
  }
}
