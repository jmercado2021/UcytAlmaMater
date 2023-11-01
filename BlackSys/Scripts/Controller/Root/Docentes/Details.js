
//$(document).ready(function () {

//    $("#FechaNacP").datepicker({
//        dateFormat: "dd/mm/yy", // Formato de fecha deseado
//        changeMonth: true, // Permite cambiar el mes
//        changeYear: true, // Permite cambiar el AddSubject
//        yearRange: "1900:2030" // Rango de años permitidos
//        // Puedes personalizar más opciones según tus necesidades
//    });
//});

$(document).ready(function () {
    $(".FechaNacP").datepicker();
});
//$("#FechaNacP").datepicker();

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



