

    function enlazar2() {
        var UsuarioId = $("#UsuarioId").val();
        //var OrdenId = $("#OrdenId").val();

        $("#ListarOrdenes").load('@Url.Action("ListarOrdenes", "Callcenter")' + '?UsuarioId=' + UsuarioId);
    };
