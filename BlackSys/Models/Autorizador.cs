//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackSys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Autorizador
    {
        public int Autorizador_Id { get; set; }
        public Nullable<int> Oficina_Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Estado_Id { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Oficina Oficina { get; set; }
    }
}