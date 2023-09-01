$(document).ready(function () {
    $.ajaxSetup({ cache: false });
});

function RenderActions(RenderActionstring) {
    $("#OpenDialog").load(RenderActionstring);
};

function CreateNew() {
    if (!ValidateInputs())
        return;


function EditEmp(id) {
    if (!ValidateInputs())
        return;
    $.ajax({
        url: '/TblTicketEncabezado/Edit/' + id,
        type: 'POST',
        data: $('form').serialize(),
        success: function (res) {
            var keys = ["UsuarioId", "UsuarioClienteId", "OperadorId", "EstadoId", "TipoProblemaId","SubTipoProblemaId","PrioridaId","Incidente"];
            $('#' + res.Id + ' td').each(function (i) {
                $(this).text(res[keys[i]]);
            });
            $('#btnCloseModal').click();
        },
        error: function (err) { alert("Error: " + err.responseText); }
    })
};
