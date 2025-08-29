// Find all custom-select elements
document.querySelectorAll(".custom-select").forEach(function (selectElement) {
  var classes = selectElement.className,
    id = selectElement.id,
    name = selectElement.name;

  // Create the custom select template
  var template = '<div class="' + classes + '">';
  template +=
    '<span class="custom-select-trigger">' +
    selectElement.getAttribute("placeholder") +
    "</span>";
  template += '<div class="custom-options scroll">';

  // Loop through the option elements and create custom options
  selectElement.querySelectorAll("option").forEach(function (optionElement) {
    template +=
      '<span class="custom-option ' +
      optionElement.className +
      '" data-value="' +
      optionElement.value +
      '">' +
      optionElement.innerHTML +
      "</span>";
  });

  template += "</div></div>";

  // Wrap the select element with custom-select-wrapper
  var wrapper = document.createElement("div");
  wrapper.className = "custom-select-wrapper";
  selectElement.parentNode.insertBefore(wrapper, selectElement);
  wrapper.appendChild(selectElement);

  // Hide the original select element
  selectElement.style.display = "none";

  // Insert the custom select template after the hidden select element
  wrapper.insertAdjacentHTML("beforeend", template);
});

// Handle hovering on the first custom option
document
  .querySelectorAll(".custom-option:first-of-type")
  .forEach(function (optionElement) {
    optionElement.addEventListener("mouseenter", function () {
      this.closest(".custom-options").classList.add("option-hover");
    });
    optionElement.addEventListener("mouseleave", function () {
      this.closest(".custom-options").classList.remove("option-hover");
    });
  });

// Toggle the custom select dropdown when the trigger is clicked
document
  .querySelectorAll(".custom-select-trigger")
  .forEach(function (triggerElement) {
    triggerElement.addEventListener("click", function (event) {
      // Close any other open custom selects
      document
        .querySelectorAll(".custom-select")
        .forEach(function (selectElement) {
          if (selectElement !== triggerElement.closest(".custom-select")) {
            selectElement.classList.remove("opened");
          }
        });

      // Toggle the current custom select
      this.closest(".custom-select").classList.toggle("opened");

      // Stop the event from bubbling up to document
      event.stopPropagation();
    });
  });

// Close the dropdown when clicking outside of it
document.addEventListener("click", function () {
  document.querySelectorAll(".custom-select").forEach(function (selectElement) {
    selectElement.classList.remove("opened");
  });
});

// Handle option selection
document.querySelectorAll(".custom-option").forEach(function (optionElement) {
  optionElement.addEventListener("click", function () {
    var selectWrapper = this.closest(".custom-select-wrapper");
    var selectElement = selectWrapper.querySelector("select");

    // Update the original select value
    selectElement.value = this.getAttribute("data-value");

    // Update the selected option display
    selectWrapper.querySelectorAll(".custom-option").forEach(function (opt) {
      opt.classList.remove("selection");
    });
    this.classList.add("selection");
    this.closest(".custom-select").classList.remove("opened");
    this.closest(".custom-select").querySelector(
      ".custom-select-trigger"
    ).textContent = this.textContent;
  });
});
