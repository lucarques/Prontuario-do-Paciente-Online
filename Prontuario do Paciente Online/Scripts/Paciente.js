$(document).ready(function () {
    $('.details-button').on('click', function (event) {
        event.preventDefault();

        var patientId = $(this).data('id');

        $.ajax({
            url: '/Pacientes/Details/' + patientId,
            type: 'GET',
            success: function (response) {
                
            },
            error: function (error) {
                
            }
        });
    });
});