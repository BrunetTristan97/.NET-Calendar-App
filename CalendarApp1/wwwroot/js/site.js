// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Use event delegation on a parent element that doesn't get replaced
$(document).on('click', '#btnPrev', function(e) {
    e.preventDefault();
    console.log("Clicked previous");
    updateCalendar('previous');
});

$(document).on('click', '#btnNext', function(e) {
    e.preventDefault();
    console.log("Clicked next");
    updateCalendar('next');
});

function updateCalendar(direction) {
    const currentDate = $('#_datetime').val();
    console.log('Sending request with date:', currentDate, 'direction:', direction);
    
    $.ajax({
        url: "/Calendar/GetMonth",
        method: 'GET',
        data: { 
            datetime: currentDate,
            direction: direction 
        },
        success: function (data) {
            $('.calendar').replaceWith(data);
            console.log(`Calendar updated successfully - ${direction}`);
        },
        error: function (xhr, status, error) {
            console.error("Error updating calendar:", error);
            console.error("Response:", xhr.responseText);
        }
    });
}