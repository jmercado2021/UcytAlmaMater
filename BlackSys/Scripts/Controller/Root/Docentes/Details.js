
$(document).ready(function () {

jQuery("#docente_FechaNac").datepicker({
    format: "dd/mm/yyyy",
    language: "es",
    autoclose: true,
    enableOnReadonly: false
}).on('show', function () {
    if ($(this).attr('readonly')) {
        $(this).datepicker('hide');
    }
});



});

function AddSubject() {
    var DtoDocenteAsignatura = {
        DocenteId: $('#docente_Id').val(),
        AsignaturaId: $('#AsignaturaId').val()
    };
    var docenteId = $('#docente_Id').val();

    $.ajax({
        type: "POST",
        url: "/Docentes/NAddSubjectDocente",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(DtoDocenteAsignatura),
        success: function (d) {
            if (d.success === true) {
                alertify.success("Se ha asociado la Asignatura");
                $("#partial").load("/Docentes/_AddSubjectDocenteAction/" + docenteId);
                //alert('Has Asociado la Asignatura!!');
            } else {
                alertify.error("La asignatura ya está asociada para este Docente!!");
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log("Error:", xhr, textStatus, errorThrown);
            alert('Error en la solicitud AJAX');
        }
    });
}

function DeleteSubject(DocenteId, AsignaturaId) {
    var DtoDocenteAsignatura = {
        DocenteId: DocenteId,
        AsignaturaId: AsignaturaId
    };
    var docenteId = DocenteId;

    $.ajax({
        type: "POST",
        url: "/Docentes/DeleteSubjectDocente",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(DtoDocenteAsignatura),
        success: function (d) {
            if (d.success === true) {
                Swal.fire(
                    'Desasociado!',
                    'Se ha desasociado la Asignatura al Docente',
                    'success'
                )
               
                $("#partial").load("/Docentes/_AddSubjectDocenteAction/" + docenteId);
              
            } else {
                alertify.error("Ocurrio un problema al desasociar la asignatura!!");
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log("Error:", xhr, textStatus, errorThrown);
            alert('Error en la solicitud AJAX');
        }
    });
}



function AlertDesasociarAsignatura(AsignaturaId) {
    console.log(AsignaturaId);
    var DocenteId = $('#docente_Id').val();
       
  
    Swal.fire({
        title: 'Esta seguro en desasociar la Asignatura?',
        text: "",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, Desasociar!'
    }).then((result) => {
        if (result.isConfirmed) {
            DeleteSubject(DocenteId, AsignaturaId)


        }
        else {
            Swal.fire(
                'Desasociar!',
                'Tranquilo, no pasa nada :)',
                'success'
            )
        }
    })

}
$(function () {

    var loc = window.location;
    var basePatch = loc.protocol + "//" + loc.hostname + (loc.port ? ":" + loc.port : "") + "/";
   
    $(document).on('change', '#docente_DepartamentoId', function () {
        $.get(basePatch + "Region/GetMunicioByDepId", { Id: $(this).val() }, function (data, textStatus, jqXHR) {
            if (textStatus === "success") {
                if ($('#docente_MunicipioId').data('select2')) {
                    $('#docente_MunicipioId').select2('destroy');
                }
                $('#docente_MunicipioId').empty();
                $.each(data, function (i, item) {
                    $('#docente_MunicipioId').append($('<option>', {
                        value: item.Id,
                        text: item.Descripcion
                    }));
                });
                $('#docente_MunicipioId').prepend($("<option value='' selected='selected'></option>"));
            }
            $('#docente_MunicipioId').select2({
                placeholder: "",
                width: "100%",
                allowClear: true
            });
        }, "json");
    });
});


