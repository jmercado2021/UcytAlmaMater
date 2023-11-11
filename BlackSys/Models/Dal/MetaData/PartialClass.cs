using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackSys.Models.Dal
{
    [MetadataType(typeof(DocenteMetaData))]
    public partial class Docente
    {
    

    public partial class DocenteMetaData
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "Id ")]


        //[MaxLength(200, ErrorMessage = "Nombre maximo 200 caracteres")]
        //[Required(ErrorMessage = "Direccion es Requerida")]
        //[Display(Name = "Dirección")]
        //public string Direccion { get; set; }


        //[MaxLength(14, ErrorMessage = "Cédula maximo 14 caracteres")]
        //[Required(ErrorMessage = "Cédula es Requerida")]
        //[DisplayFormat(DataFormatString = "{0;#############")]





        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Display(Name = "Recinto")]
        [Required(ErrorMessage = "Categoria Docente Requerido")]
        public int RecintoId { get; set; }

        [Display(Name = "Profesion")]
        [Required(ErrorMessage = "Debe Seleccionar la Profesion")]
        public Nullable<int> ProfesionId { get; set; }

        [MaxLength(80, ErrorMessage = "Nombre maximo 80 caracteres")]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe editar el Nombre")]
        public string Nombre { get; set; }

        [MaxLength(80, ErrorMessage = "Dirección maximo 80 caracteres")]
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe editar la direccion")]
        public string Direccion { get; set; }

        [MaxLength(8)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }


        [MaxLength(8)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }


        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Debe Seleccionar el Cargo")]
        public Nullable<int> CargoActualId { get; set; }

        [Display(Name = "Tipo Documento")]
        [Required(ErrorMessage = "Debe Seleccionar el tipo de documento")]
        public Nullable<int> TipoDocumentoId { get; set; }

        [MaxLength(20, ErrorMessage = "Documento maximo 20 caracteres")]
        [Display(Name = "Nº Documento")]
        [Required(ErrorMessage = "Debe editar el numero de documento")]
        public string Cedula_Documento { get; set; }



        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Debe Seleccionar el sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/YYY}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaNac { get; set; }


      
        [Display(Name = "Etnia")]
        [Required(ErrorMessage = "Debe Seleccionar la Etnia")]
        public Nullable<int> EtniaId { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Debe Seleccionar el Pais")]
        public Nullable<int> PaisId { get; set; }

        [Display(Name = "Domina Idiomas")]
        [Required(ErrorMessage = "Debe Seleccionar si domina Idiomas")]
        public string DominaIdiomas { get; set; }

        [Display(Name = "Nombre Idiomas")]
        [Required(ErrorMessage = "Debe editar el nombre de Idioma")]
        public string NombreIdioma { get; set; }

        [Display(Name = "Nivel Alcanzado")]
        [Required(ErrorMessage = "Debe editar el nivel alcanzado")]
        public string NivelAlcanzado { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Debe seleccionar el departamento del Docente")]
        public Nullable<int> DepartamentoId { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Debe seleccionar el Municipio del Docente")]
        public Nullable<int> MunicipioId { get; set; }

        [Display(Name = "Zona")]
        [Required(ErrorMessage = "Debe seleccionar la Zona del Docente")]
        public string Zona { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Debe seleccionar un estado civil del Docente")]
        public string EstadoCivil { get; set; }


        [Display(Name = "Nº Hijos")]
        [Required(ErrorMessage = "Debe indicar numero de hijos")]
        public Nullable<int> NHijos { get; set; }

        [Display(Name = "Tiene Discapacidad?")]
        [Required(ErrorMessage = "Debe indicar si tiene discapacidad")]
        public string Discapacidad { get; set; }

        [Display(Name = "Area Institucional")]
        [Required(ErrorMessage = "Debe seleccionar una Area")]
        public Nullable<int> AreaId { get; set; }

        [Display(Name = "Ejercicio Directivo")]
        [Required(ErrorMessage = "Debe seleccionar un ejercicio directivo")]
        public Nullable<int> EjercicioDirectivoId { get; set; }


        [Display(Name = "Máximo Nivel Formacion Pedadogica")]
        [Required(ErrorMessage = "Debe seleccionar el maximo nivel pedadogica")]
        public Nullable<int> MaximoNivelFpId { get; set; }
        
        [Display(Name = "Nombre Titulos")]
        [Required(ErrorMessage = "Debe Editar nombre Titulo")]
        public string NombreTitulos { get; set; }

        [Display(Name = "Tiene Formación Pedadógia")]
        [Required(ErrorMessage = "Debe indicar si Tiene Formación Pedadógia")]
        public string TieneFormacionPedagogica { get; set; }

        [Display(Name = "Nombre Formación Pedadógia")]
        public string NombreFormacionPedagogica { get; set; }

        [Display(Name = "Año Formación Pedadógia")]
        public Nullable<int> AnioFormacionPedadogica { get; set; }


        [Display(Name = "Tipo de Contrato")]
        [Required(ErrorMessage = "Debe seleccionar el tipo de contrato")]
        public Nullable<int> TipoContratoId { get; set; }

        [Display(Name = "Categoria docente")]
        [Required(ErrorMessage = "Debe seleccionar categoria de docente")]
        public Nullable<int> CategoriaDocenteId { get; set; }


        [Display(Name = "Años de Antiguedad")]
        //[Required(ErrorMessage = "Debe seleccionar categoria de docente")]
        public Nullable<int> AnosAntiguedad { get; set; }

        [Display(Name = "Pserv UNICAM")]
        [Required(ErrorMessage = "Debe seleccionar el tipo de contrato")]
        public string PservUNICAM { get; set; }

        [Display(Name = "PServ UALN")]
        [Required(ErrorMessage = "Debe seleccionar PServ UALN ")]
        public string PServ_UALN { get; set; }

        [Display(Name = "PServ RSJ")]
        [Required(ErrorMessage = "Debe seleccionar PServ RSJ")]
        public string PServ_RSJ { get; set; }

        [Display(Name = "PServ Prepa")]
        [Required(ErrorMessage = "Debe seleccionar el tipo de contrato")]
        public string PServ_Prepa { get; set; }

        [Display(Name = "Nº Grupos")]
        [Required(ErrorMessage = "Edite la cantidad de Grupos")]
        public Nullable<int> NoGrupos { get; set; }

        [Display(Name = "Nº Asignaturas")]
        [Required(ErrorMessage = "Edite la cantidad de asignaturas")]
        public Nullable<int> NoAsignaturas { get; set; }

        [Display(Name = "No Asi gMod")]
        [Required(ErrorMessage = "Edite numero de Asignaturas Mod")]
        public string NoAsigMod { get; set; }

        [Display(Name = "Realiza Investigacion")]
        [Required(ErrorMessage = "Debe seleccionar si realiza investigacion")]
        public string RealizaInvestigacion { get; set; }

        [Display(Name = "Area Investigacion")]
        [Required(ErrorMessage = "Debe seleccionar investigacion")]
        public Nullable<int> DocenteAreaInvestigacionId { get; set; }

        [Display(Name = "Realiza Tutorias")]
        [Required(ErrorMessage = "Debe seleccionar si realiza Tutorias")]
        public string Tutorias { get; set; }

        [Display(Name = "No Masculino TGrado")]
        [Required(ErrorMessage = "Debe Editar NoMTGrado")]
        public Nullable<int> NoMTGrado { get; set; }

        [Display(Name = "No Femenino TGrado")]
        [Required(ErrorMessage = "Debe Editar NoMFGrado")]
        public Nullable<int> NoFTGrado { get; set; }

        [Display(Name = "No Masculino PosGrado")]
        [Required(ErrorMessage = "Debe Editar No M PosGrado")]
        public Nullable<int> NoMTPosgrado { get; set; }

        [Display(Name = "No Femenino PosGrado")]
        [Required(ErrorMessage = "Debe Editar No Femenino PosGrado")]
        public Nullable<int> NoFTPosgrado { get; set; }


        [Display(Name = "Estudia")]
        [Required(ErrorMessage = "Debe Editar si estudia")]
        public string Estudia { get; set; }


        [Display(Name = "Nivel FP Estudios")]
        [Required(ErrorMessage = "Debe Editar Nivel Fp Estudios")]
        public Nullable<int> NivelFpEstudios { get; set; }

        [Display(Name = "Nombre Estudios")]
        [Required(ErrorMessage = "Debe Seleccionar Nombre Estudios")]
        public string NombreEstudios { get; set; }

        [Display(Name = "Beca Estudios")]
        [Required(ErrorMessage = "Beca Estudios")]
        public string BecaEstudios { get; set; }

        [Display(Name = "Procedencia Beca Estudios")]
       
        public string ProcedBeca { get; set; }

        [Display(Name = "Tipo Beca Estudios")]
      
        public string TipoBeca { get; set; }


        [Display(Name = "Monto Beca Estudios")]
        
        public Nullable<decimal> MontoBeca { get; set; }

        [Display(Name = "Capacitaciones")]
        [Required(ErrorMessage = "Debe Seleccionar Capacitaciones")]
        public string Capacitaciones { get; set; }

        [Display(Name = "Capacitaciones")]
        [Required(ErrorMessage = "Debe Seleccionar Capacitaciones")]
        public Nullable<int> AreaCapacitacionId { get; set; }

        //[Display(Name = "Horas Clase")]
        //[Required(ErrorMessage = "Debe editar Horas clase")]
        //public Nullable<int> HorasClase { get; set; }

        [Display(Name = "No Inss")]
        [Required(ErrorMessage = "Debe editar el no inss Docente")]
        public string NoInss { get; set; }

        [Display(Name = "Horas Clase semana")]
        [Required(ErrorMessage = "Debe editar Horas clase Semana")]
        public Nullable<int> HorasClaseSemana { get; set; }

        [Display(Name = "Valor por Hora")]
        [Required(ErrorMessage = "Debe editar valor por hora")]
        public Nullable<decimal> ValorXHoraClase { get; set; }

        [Display(Name = "Usuario Modifica")]
        public string UsuarioModifica { get; set; }

        [Display(Name = "Fecha registro")]
       
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        [Display(Name = "Fecha Modificado")]
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string Activo { get; set; }

        }

    }
}