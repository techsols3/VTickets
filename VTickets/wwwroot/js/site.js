// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $('.myTable').DataTable();
});

$(document).ready(function() {
    var output = document.getElementById('ProfilePicturePreview');
    output.src = $("#ProfilePictureUrl").val();
});

$("#ProfilePictureUrl").on("change",
    function () {
        var output = document.getElementById('ProfilePicturePreview');
        output.src = $(this).val();
    });