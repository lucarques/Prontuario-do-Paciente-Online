$(document).ready(function () {
    $('.details-button').on('click', function (event) {
        event.preventDefault();

        var patientId = $(this).data('id');

        $.ajax({
            url: '/Pacientes/Details/' + patientId, // Substitua pelo caminho correto
            type: 'GET',
            success: function (response) {
                console.log('Detalhes do Paciente:', response);
            },
            error: function (error) {
                console.error('Erro ao carregar detalhes do paciente:', error);
            }
        });
    });
});