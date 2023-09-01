using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackSys.Models
{
    public class ArticulosDescuentoClass
    {
        public short Descuento_Id { get; set; }
        public int CONSECUTIVO { get; set; }
        public string ARTICULO_ID { get; set; }
        public string ArticuloNombre { get; set; }
        public decimal Descuento_Porcentaje { get; set; }
    }
}