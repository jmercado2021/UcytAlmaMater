
//$(document).ready(function () {

//    $("#docente_FechaNac").datepicker({
//        dateFormat: "dd/mm/yy", // Formato de fecha deseado
//        changeMonth: true, // Permite cambiar el mes
//        changeYear: true, // Permite cambiar el año
//        yearRange: "1900:2030" // Rango de años permitidos
//        // Puedes personalizar más opciones según tus necesidades
//    });
//});

/*$("#docente_FechaNac").datepicker();*/

function AddSubject() {
    var DtoDocenteAsignatura = {
        DocenteId: $('#docente_Id').val(),
        AsignaturaId: $('#AsignaturaId').val()
    };

    $.ajax({
        type: "POST",
        url: "/Docentes/NAddSubjectDocente",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(DtoDocenteAsignatura),
        success: function (d) {
            if (d.success === true) {
                alertify.success("Se ha asociado la Asignatura");
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

function AlertDesasociarAsignatura(Identificador) {
    var DtoDocenteAsignatura = {
        DocenteId: $('#docente_Id').val(),
        AsignaturaId: $('#AsignaturaId').val()
    };
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
            Swal.fire(
                'Deleted!',
                'Your file has been deleted.',
                'success'
            )
        }
    })

}




//function AlertaProcesoNoCompletado() {


//    swal({
//        title: "Procesos ejecutados correctamente!",
//        text: "Catalogo actualizado!",
//        icon: "success",
//    });
//}
