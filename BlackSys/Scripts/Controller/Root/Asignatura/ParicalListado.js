$(document).on('click', '.details-link', function (e) {
    e.preventDefault();

    var url = $(this).attr('href');

    $.get(url, function (data) {
        $('#myModal .modal-body').html(data);
        $('#myModal').modal('show');
    });
});
