//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackSys.Models.Expediente
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuariosTokens
    {
        public int Id { get; set; }
        public string Carnet { get; set; }
        public System.Guid TokenGuid { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime FechaExpiracion { get; set; }
        public bool Activo { get; set; }
    }
}