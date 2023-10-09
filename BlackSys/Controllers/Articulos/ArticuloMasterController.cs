using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models;
using System.IO;
using Microsoft.AspNet.Identity;

namespace BlackSys.Controllers.Articulos
{
   
    public class ArticuloMasterController : Controller
    {
        //private COMERCIALEntities db = new COMERCIALEntities();
        // GET: ArticuloMaster
        public ActionResult Listado()
        {
            //var data = db.W_ListarArticulosIndex("888").ToList();
            //return View(data);
            return View();
        }
        public ActionResult ParcialListado(string Nombre)
        {
            //return PartialView(db.W_ListarArticulosIndex(Nombre).ToList());
            return View();
        }
        public ActionResult DetallarArticulo(string Codigo)
        {
            return View();

            //ViewBag.Casa = new SelectList(db.TblCasa, "Codigo", "Nombre");
            //ViewBag.Departamento = new SelectList(db.TblDepartamentoArticulo, "Id", "Nombre");
            //ViewBag.Grupo = new SelectList(db.TblGrupoTerapeutico, "Id", "Nombre");
            //ViewBag.Categoria = new SelectList(db.TblCategoriaArticulo, "Id", "Nombre");
            //ViewBag.SubCategoria = new SelectList(db.TblSubCategoriaArticulo, "Id", "Nombre");
            //ViewBag.TipoUso = new SelectList(db.TblProveedor, "Id", "Nombre");
            //ViewBag.Proveedor = new SelectList(db.TblProveedor, "Id", "Nombre");
            //ViewBag.sustituto = new SelectList(db.TblArticulo_Sustituto, "Sustituto_Id", "Sustituto_Nombre");
            //ViewBag.Mensaje = "";
            ////Byte[] imagen = GetImageFromDatabase(Codigo);
            ////ViewBag.imagen = imagen;
            //var lista = db.W_ConsultarArticuloById(Codigo).ToList();

            //return PartialView(lista);
            //int a = 0;
        }
  
        public ActionResult ActualizarImagen(string Codigo, HttpPostedFileBase file)
        {
            byte[] array2;
            if (file != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();

                    array2 = array;

                    //db.W_ArticuloActualizaImagen(Codigo,array2);

                }
            }
            else
            {

            }

            return RedirectToAction("Listado");
        }

        //public ActionResult RetrieveImage(string Codigo)
        //{

        //    Byte[] cover = GetImageFromDatabase(Codigo);
        //    if (cover != null)
        //    {
        //        return File(cover, "image/jpg");

        //    }
        //    else
        //    {
        //        return null;


        //    }

        //    return View();
        //}

        //public Byte[] GetImageFromDatabase(string Codigo)
        //{
        //    //var q = from temp in db.TblArticulo where temp.Codigo == Codigo select temp.Articulo_image;
        //    //Byte[] cover = q.First();
        //    //return cover;
        //    //return View();
        //}
        public ActionResult ArticulosEquivalentes(string Codigo)
        {
            return View();
            //return PartialView(db.W_ListarArticulosIndex(Codigo).ToList());
        }
        [HttpPost]
        public ActionResult GuardarSusititutoEquivalente(string Codigo, int SustitutoId)
        {
            // db.W_ModificaSusitutoArticulo(SustitutoId, Codigo);
            //return RedirectToAction("Listado");
            return View();
        }


        public ActionResult NuevoArticulo()
        {
            //ViewBag.Casa = new SelectList(db.TblCasa.OrderBy(x => x.Nombre), "Codigo", "Nombre");
            //ViewBag.Departamento = new SelectList(db.TblDepartamentoArticulo.OrderBy(x => x.Nombre), "Id", "Nombre");
            //ViewBag.Grupo = new SelectList(db.TblGrupoTerapeutico.OrderBy(x => x.Nombre), "Id", "Nombre");
            //ViewBag.Categoria = new SelectList(db.TblCategoriaArticulo.OrderBy(x => x.Nombre), "Id", "Nombre");
            //ViewBag.SubCategoria = new SelectList(db.TblSubCategoriaArticulo.OrderBy(x => x.Nombre), "Id", "Nombre");
            //ViewBag.TipoUso = new SelectList(db.TblProveedor.OrderBy(x => x.Nombre), "Id", "Nombre");
            //ViewBag.Proveedor = new SelectList(db.TblProveedor.OrderBy(x => x.Nombre), "Id", "Nombre");
            //ViewBag.Sustituto = new SelectList(db.TblArticulo_Sustituto.OrderBy(x => x.Sustituto_Nombre), "Sustituto_Id", "Sustituto_Nombre");
        
            return View();

        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult InsertarArticulo(string CodAuto,string Codigo, int CasaId,
                                            int CategoriaId, int SubCategoriaId,
                                            int DepartamentoId, int GrupoId,
                                            int ProveedorId, string ArticuloNombre,
                                            string ArticuloObservacion, string ArticuloClienteFrecuente,
                                            string Color, string Tamaño, string ArticuloBarra,
                                            decimal ArticuloCosto, decimal ArticuloCostoProm, decimal ArticuloCostoUlt,
                                            decimal ArticuloPrecio, decimal ArticuloPrecio1, decimal ArticuloPrecio2,
                                            decimal ArticuloPrecio3, decimal ArticuloPrecio4, decimal ArticuloPrecio5,
                                            decimal ArticuloPrecioFijo, 
                                            string ArticuloActivoVenta, double ArticuloLimiteDesc, double ArticuloLimiteDesc2,
                                            double ArticuloLimiteDesc3, string ArticuloVentaBajoCosto, int ArticuloCantidadMinima,
                                            string PagaIva,
                                            string ArticuloCodCajaSuelto, string ArticuloActivoCompra,
                                            int ArticuloFactorConv, double Articulo_Margen, double Articulo_Alto,
                                            double Articulo_Ancho, double Articulo_Largo, int Articulo_Unidad, string Articulo_Aplica_Regalia,
                                            string Articulo_Express, string Articulo_Devuelve_Proveedor,
                                            int Articulo_Tipo_Uso, int Articulo_Sustituto_Id,
                                            HttpPostedFileBase file, string SumaIvaPrecio,string PrecioPorMargen,string Controlado)
        {
            //if (CodAuto == "on")
            //{
            //    CodAuto = "SI";
            //}
            //int usuarioId = 0;
            //int ArticuloActivoCompraP = 0;
            //int Articulo_Aplica_RegaliaP = 0;
            //int Articulo_Permiso = 1;
            //string ArticuloCodigoHijo = "";
            //string ArticuloCodigoPadre = "";
            //int SumaIvaPrecioP = 0;
            //int PrecioPorMargenP = 0;
            //string ControladoP = "NO";


            //int Articulo_Devuelve_ProveedorP = 0;
            //string PagaIvaP = "";

            //if (PagaIva == "on")
            //{
            //    PagaIvaP = "SI";

            //}
            //else PagaIvaP = "No";


            //if (Articulo_Devuelve_Proveedor == null)
            //{
            //    Articulo_Devuelve_ProveedorP = 0;
            //}



            //if (ArticuloActivoCompra == null)
            //{
            //    ArticuloActivoCompraP = 0;
            //}



            //if (SumaIvaPrecio == null)
            //{
            //    SumaIvaPrecioP = 0;
            //}


            //if (PrecioPorMargen == null)
            //{
            //    PrecioPorMargenP = 0;
            //}
            //else
            //{
            //    PrecioPorMargenP = 0;
            //}
            //if (Controlado == "on")
            //{
            //    ControladoP = "SI";
            //}
            //else ControladoP = "No";

            ////int Articulo_Unidad = 1;

            var user = User.Identity.GetUserName();
            //using (var ctx = new COMERCIALEntities())
            //{
            //    using (var ctxTrans = ctx.Database.BeginTransaction())
            //    {
            //        try
            //        {
            //            if (ModelState.IsValid)
            //            {
            //                string IP = Request.UserHostAddress;
            //    string NombreClente = Request.UserHostName;

            //                int codautov = Convert.ToInt32(CodAuto);
            //                string CodigoGenerad = CasaId + ArticuloBarra.Substring(0,4);
            //                db.W_Inserta_Articulo(codautov, 1, CodigoGenerad, CasaId, CategoriaId, SubCategoriaId, DepartamentoId, GrupoId, ProveedorId, ArticuloNombre,
            //                                    ArticuloObservacion, 1, Color, Tamaño, ArticuloBarra, ArticuloCosto, ArticuloCostoProm,
            //                                    ArticuloCostoUlt, ArticuloPrecio, ArticuloPrecio1, ArticuloPrecio2, ArticuloPrecio3, ArticuloPrecio4, ArticuloPrecio5,
            //                                    ArticuloPrecioFijo, "", 1, 1, ArticuloLimiteDesc, ArticuloLimiteDesc2,
            //                                    ArticuloLimiteDesc3, 1, ArticuloCantidadMinima, user, "SI", PagaIvaP, 0, ArticuloCodigoPadre,
            //                                    ArticuloCodigoHijo, ArticuloCodCajaSuelto, ArticuloActivoCompraP, 1, ArticuloFactorConv, 0, 0, 0, 0, Articulo_Margen,
            //                                    0, 0, Articulo_Alto, Articulo_Ancho, Articulo_Largo, Articulo_Unidad, Articulo_Aplica_RegaliaP, Convert.ToInt32(Articulo_Express),
            //                                    Articulo_Permiso, Articulo_Devuelve_ProveedorP, 0, 0, Articulo_Tipo_Uso, 0, 0,
            //                                    Articulo_Sustituto_Id, IP, NombreClente, 1, SumaIvaPrecioP, PrecioPorMargenP, ControladoP);

            //                //Guardo la Imagen si la View retorna
            //                byte[] array2;
            //                if (file != null)
            //                {
            //                    using (MemoryStream ms = new MemoryStream())
            //                    {
            //                        file.InputStream.CopyTo(ms);
            //                        byte[] array = ms.GetBuffer();

            //                        array2 = array;

            //                        db.W_ArticuloActualizaImagen(CodAuto, array2);

            //                    }
            //                }
            //                ctxTrans.Commit();
            //                //Aprobado

            //   }
            //        }
            //        catch (Exception e)
            //        {
            //            ctxTrans.Rollback(); // Desaprobado
            //            //db.W_InsertaErrorLog(user, "ArticuloMaster/NuevoArticulo", Convert.ToString(e.InnerException));
            //            Console.WriteLine("{0} Exception caught.", e.Message);
            //        }
            //        return RedirectToAction("Listado");
            //    }
            //}
            return View();
        }
        [HttpPost]
        public ActionResult ActualizarArticulo(string Codigo, int Casa,
                                            int CategoriaId, int SubCategoriaId,
                                            int DepartamentoId, int GrupoId,
                                            int ProveedorId, string ArticuloNombre,
                                            string ArticuloObservacion, string ArticuloClienteFrecuente,
                                            string Color, string Tamaño, string ArticuloBarra,
                                            decimal ArticuloCosto, decimal ArticuloCostoProm, decimal ArticuloCostoUlt,
                                            decimal ArticuloPrecio, decimal ArticuloPrecio1, decimal ArticuloPrecio2,
                                            decimal ArticuloPrecio3, decimal ArticuloPrecio4, decimal ArticuloPrecio5,
                                            decimal ArticuloPrecioFijo,
                                            int? ArticuloActivoVenta, double ArticuloLimiteDesc, double ArticuloLimiteDesc2,
                                            double ArticuloLimiteDesc3, int? ArticuloVentaBajoCosto, int ArticuloCantidadMinima,
                                            int? PagaIva,
                                            string ArticuloCodCajaSuelto, int? ArticuloActivoCompra,
                                            int? ArticuloFactorConv, double Articulo_Margen, double Articulo_Alto,
                                            double Articulo_Ancho, double Articulo_Largo, int Articulo_Unidad, int? Articulo_Aplica_Regalia,
                                            int? Articulo_Express, int? Articulo_Devuelve_Proveedor,
                                            int Articulo_Tipo_Uso, int? Articulo_Sustituto_Id,
                                            HttpPostedFileBase file, int? SumaIvaPrecio, int? PrecioPorMargen, string Controlado)
        {

            //int usuarioId = 0;
            ////int ArticuloActivoCompraP = 0;
            ////int Articulo_Aplica_RegaliaP = 0;
            //int Articulo_Permiso = 1;
            //string ArticuloCodigoHijo = "";
            //string ArticuloCodigoPadre = "";
            ////int SumaIvaPrecioP = 0;
            ////int PrecioPorMargenP = 0;
            //string ControladoP = "NO";



            //int Articulo_Devuelve_ProveedorP = 0;
            //String PagaIvaP = "NO";

            //if (PagaIva == null)
            //{
            //    PagaIvaP = "NO";
            //}

            //else
            //{
            //    PagaIvaP = "SI";
            //}
            //if (ArticuloActivoVenta == null)
            //{
            //    ArticuloActivoVenta = 0;
            //}



            //if (Articulo_Devuelve_Proveedor == null)
            //{
            //    Articulo_Devuelve_ProveedorP = 0;
            //}


            //if (Articulo_Aplica_Regalia == null)
            //{
            //    Articulo_Aplica_Regalia = 0;
            //}


            //if (ArticuloActivoCompra == null)
            //{
            //    ArticuloActivoCompra = 0;
            //}



            //if (SumaIvaPrecio == null)
            //{
            //    SumaIvaPrecio = 0;
            //}


            //if (PrecioPorMargen == null)
            //{
            //    PrecioPorMargen = 0;
            //}
            //if (ArticuloVentaBajoCosto == null)
            //{
            //    ArticuloVentaBajoCosto = 0;
            //}
            //if (Controlado == null)
            //{
            //    ControladoP = "SI";
            //}
            //else
            //{
            //    ControladoP = "NO";
            //}
            ////int Articulo_Unidad = 1;

            //var user = User.Identity.GetUserName();
            //using (var ctx = new COMERCIALEntities())
            //{
            //    using (var ctxTrans = ctx.Database.BeginTransaction())
            //    {
            //        try
            //        {

            //                string IP = Request.UserHostAddress;
            //                string NombreClente = Request.UserHostName;



            //                db.W_UPDATE_ARTICULO(0,1,Codigo,Casa, CategoriaId, SubCategoriaId, DepartamentoId, 
            //                                    GrupoId, ProveedorId, ArticuloNombre,
            //                                    ArticuloObservacion, 1, Color, Tamaño, 
            //                                    ArticuloBarra, ArticuloCosto, ArticuloCostoProm,
            //                                    ArticuloCostoUlt, ArticuloPrecio, 
            //                                    ArticuloPrecio1, ArticuloPrecio2, ArticuloPrecio3, ArticuloPrecio4, ArticuloPrecio5,
            //                                    ArticuloPrecioFijo, "", 1, ArticuloActivoVenta, 
            //                                    ArticuloLimiteDesc, ArticuloLimiteDesc2,
            //                                    ArticuloLimiteDesc3, ArticuloVentaBajoCosto, ArticuloCantidadMinima,
            //                                    user, "SI", PagaIvaP, 0, ArticuloCodigoPadre,
            //                                    ArticuloCodigoHijo, ArticuloCodCajaSuelto,
            //                                    ArticuloActivoCompra, 1, ArticuloFactorConv, 
            //                                    0, 0, 0, 0, Articulo_Margen,
            //                                    0, 0, Articulo_Alto, Articulo_Ancho, Articulo_Largo, 
            //                                    Articulo_Unidad, Articulo_Aplica_Regalia, Convert.ToInt32(Articulo_Express),
            //                                    Articulo_Permiso, Articulo_Devuelve_ProveedorP, 0, 0, Articulo_Tipo_Uso,0, 0,
            //                                    Articulo_Sustituto_Id, IP, NombreClente, 1, 
            //                                    SumaIvaPrecio, PrecioPorMargen, ControladoP);

            //                //Guardo la Imagen si la View retorna
            //                ////byte[] array2;
            //                ////if (file != null)
            //                ////{
            //                ////    using (MemoryStream ms = new MemoryStream())
            //                ////    {
            //                ////        file.InputStream.CopyTo(ms);
            //                ////        byte[] array = ms.GetBuffer();

            //                ////        array2 = array;

            //                ////        db.W_ArticuloActualizaImagen(CodAuto, array2);

            //                ////    }
            //                ////}
            //                ctxTrans.Commit();
            //                //Aprobado


            //        }
            //        catch (Exception e)
            //        {
            //            ctxTrans.Rollback(); // Desaprobado
            //            //db.W_InsertaErrorLog(user, "ArticuloMaster/NuevoArticulo", Convert.ToString(e.InnerException));
            //            Console.WriteLine("{0} Exception caught.", e.Message);
            //        }
            //        return RedirectToAction("Listado");
            //    }
            //}
            return View();
        }
        //[HttpPost]
        public ActionResult CrearCodigoSuelto(string CodigoPadre,string Factor,string Identificador)
        {
            //using (var ctx = new COMERCIALEntities())
            //{
            //    var user = User.Identity.GetUserName();
            //    using (var ctxTrans = ctx.Database.BeginTransaction())
            //    {
            //        try
            //        {
            //            if (ModelState.IsValid)
            //            {                        
            //                //Ejecuto el SP IMPORTADO CON ENTITIE
            //                db.W_CREA_CODIGO_SUELTO(CodigoPadre,Convert.ToInt32(Factor), user);
            //                //Ejecutamos la transaccion
            //                ctxTrans.Commit();
            //                return RedirectToAction("Listado");
            //            }
            //        }
            //        catch (Exception e)

            //        {
            //            ctxTrans.Rollback(); // Desaprobado
            //            //db.W_InsertaErrorLog(user, "ArticuloMaster/NuevoArticulo", Convert.ToString(e.InnerException));
            //            TempData["@MSG"] = e.InnerException.Message;
            //            ViewBag.Mensaje = e.InnerException.Message;

            //        }
            //        //Retorno la vista parcial para el mensaje de confirmacion o de error
            //        return PartialView();

            //    }
            return View();
        }
        }
    }




