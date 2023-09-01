function enlazar2() {
    var SucursalcId = $("#SucursalcId").val();
    var OrdenId = $("#OrdenId").val();

    $("#partial2").load('@Url.Action("BorraExpressNull", "Soporte")' + '?SucursalcId=' + SucursalcId + '&OrdenId=' + OrdenId);
};