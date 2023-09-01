//jmercado 20/01/2021
//***********************************************************
//genera el codigo dos digitos de la casa, 4 digitos del codigo de barra, el texbox de va a inabilitar
    function GenerarCodigo()
            {
               
                var CodBarra = $('#ArticuloBarra').val();
                var Casa = $('#CasaId').val();

                    if ($('#ArticuloBarra').val().length >= 4) {
                        document.getElementById('Codigo').value = Casa.substring(0, 4) + CodBarra.substring(0, -4)
                        document.getElementById('Codigo').text = Casa.substring(0, 4) + CodBarra.substring(0, 4)

                        document.getElementById('CodAuto').value ="1" 
                        $('#Codigo').attr("disabled", "disabled");
                    }
                    else
                    {

                         alertify.error("Debe llenar el campo Codigo de Barrass");
        }

        //*********************************************************************
}
//si se elige codigo manual entonce borro el texbox y lo habilito
        function CodigoManual()
         {

            document.getElementById('Codigo').value = ""
            document.getElementById('CodAuto').value = "0" 
                $('#Codigo').removeAttr("disabled");
        }


function ValidarBotonCrearSuelto()
{
    if ($('#Identificador').text = "S")
    {
        document.getElementById('#Identificador').disabled = true;
        var Mensaje = new String("Estimado");
        alert(Mensaje);
    }
    else
    {
        document.getElementById('#Identificador').disabled = false;
        var Mensaje = new String("Estimado");
        alert(Mensaje);
    }
 } 
//function CrearCodigoSuelto22() {  //FUNCION PARA CREAR EL CODIGO SUELTO. CARGAMOS LA VISTA PARCIAL PARA EL MENSAJE A MOSTRAR
//    var CodigoPadre = $("#CodigoPadre").val();
//    var Factor = $("#Factor").val();

//    $("#partial2").load('@Url.Action("CrearCodigoSuelto")' + '?CodigoPadre=' + CodigoPadre + '&Factor=' + Factor);
//};
      
