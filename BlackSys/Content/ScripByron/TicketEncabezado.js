$(document).ready(function () {
    $.ajaxSetup({ cache: false });
});

function RenderActions(RenderActionstring) {
    $("#OpenDialog").load(RenderActionstring);
};



    function Edit2(id) {
        //if (!ValidateInputs())
        //    return;
        $.ajax({
            url: '/TblTicketEncabezado/Edit2/' + id,
            type: 'POST',
            data: $('form').serialize(),
            success: function (res) {
                var keys = ["NTicket", "EstadoId"];
                $('#' + res.NTicket + ' td').each(function (i) {
                    $(this).text(res[keys[i]]);
                    location.href = "/Dashboard/TiemposPorTicketAbiertos";

                });
                $('#btnCloseModal').click();
                location.href = "/Dashboard/TiemposPorTicketAbiertos";
            },
            error: function (err) { alert("Error: " + err.responseText); }

        })
    //};
    //return flag;
    };

    function ValidateInputs() {
        var flag = true;
        var firstNameInput = $('#FirstName');
        var secondNameInput = $('#SecondName');
        var emailInput = $('#Email');

        if ($.trim(firstNameInput.val()) != '') {
            firstNameInput.closest('.form-group').removeClass('has-error');
            flag = true;
        }

        if ($.trim(secondNameInput.val()) != '') {
            secondNameInput.closest('.form-group').removeClass('has-error');
            flag = true;
        }

        if ($.trim(emailInput.val()) === '') {
            emailInput.closest('.form-group').removeClass('has-error');
            flag = true;
        }

        if ($.trim(firstNameInput.val()) === '') {
            firstNameInput.closest('.form-group').addClass('has-error');
            flag = false;
        }

        if ($.trim(secondNameInput.val()) === '') {
            secondNameInput.closest('.form-group').addClass('has-error');
            flag = false;
        }

        if ($.trim(emailInput.val()) != '') {
            var reg = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            if (!reg.test($('#Email').val())) {
                emailInput.closest('.form-group').addClass('has-error');
                flag = false;
            }
        }

        return flag;
    };