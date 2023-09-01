

                $(document).ready(function () {

                    $("#ListarEstatus").change(function () {
                        alertify.notify('Cargando', 'success', 1, null);
                        var estatus = $("#ListarEstatus").val();
                        $("#PartialOrdenes").load('@(Url.Action("ListarOrdenesDetalleXestatusRetraso", "Callcenter", null, Request.Url.Scheme))?estatus=' + estatus);

                    });
                });




                function Actualizar() {

                    $("#ListarEstatus").change(function () {
                        alertify.notify('Cargando', 'success', 1, null);
                        var estatus = $("#ListarEstatus").val();
                        $("#PartialOrdenes").load('@(Url.Action("ListarOrdenesDetalleXestatusRetraso", "Callcenter", null, Request.Url.Scheme))?estatus=' + estatus);

                    });
                };




                        $(document).ready(function () {
                            $('.navbar-nav').on('click', function () {
                                $('.navbar-collapse').collapse('hide');
                            });
                        });
