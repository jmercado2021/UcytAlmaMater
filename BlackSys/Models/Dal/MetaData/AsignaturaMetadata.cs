using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackSys.Models.Dal
{
    [MetadataType(typeof(AsignaturaMetadata))]
    public partial class Asignatura
    {
        public partial class AsignaturaMetadata
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Display(Name = "Id")]
            public int Id { get; set; }

            [Display(Name = "Descripcion")]     
            [Required(ErrorMessage = "Descripcion Asignatura es Requerido")]
            public string Nombre { get; set; }
            [Display(Name = "Nota Minima Regular")]
            [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
            [Required(ErrorMessage = "Nota Minima es Requerido")]
            public double NotaMinRegular { get; set; }

            [Display(Name = "Nota Minima Extra Drecho")]
            [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
            [Required(ErrorMessage = "Nota Minima Extra Dere escho Requerido")]
            public double NotaMinExtraDerecho { get; set; }

            [Display(Name = "Nota Minima Extra Derecho")]
            [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
            [Required(ErrorMessage = "Nota Maxima Estra Derecho es Requerido")]
            public double NotaMaxExtraDerecho { get; set; }

            [Display(Name = "Nota Minima Regular")]
            [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
            [Required(ErrorMessage = "Nota Minima es Requerido")]
            public double NotaMinConvalidacion { get; set; }

            [Display(Name = "Nota Minima Suficiencia")]
            [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
            [Required(ErrorMessage = "Nota Minima Suficiencia es Requerido")]
            public double NotaMinSuficiencia { get; set; }

            [Display(Name = "Nota Minima Tutoria")]
            [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
            [Required(ErrorMessage = "Nota Minima es Tutoria")]
            public double NotaMinTutoria { get; set; }

            public System.DateTime FechaModifica { get; set; }
            public string UsuarioModifica { get; set; }

            [Display(Name = "Activo")]
            public string Activo { get; set; }

            [Display(Name = "Identificador")]
            [Required(ErrorMessage = "El identificador es requerido")]
            public string Identificador { get; set; }
        }
    }
}