// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
  const usernameElements = document.querySelectorAll(".username-truncate");

  function updateMargin() {
    usernameElements.forEach((element) => {
      // Check if text is truncated
      const isTruncated = element.scrollWidth > element.clientWidth;

      // Add margin-right if NOT truncated
      element.style.marginRight = isTruncated ? "2px" : "6px";
    });
  }

  // Initial check
  updateMargin();

  // Update on window resize
  window.addEventListener("resize", updateMargin);
});
