using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlackSys.Models.Dal
{
    [MetadataType(typeof(DocenteMetaData))]
    public partial class Docente
    {
    }

    public partial class DocenteMetaData
    {
        [Display(Name = "Id ")]
        public int Id { get; set; }

        [Display(Name = "Recinto")]
        public int RecintoId { get; set; }

        [Display(Name = "Profesión")]
        public int ProfesionId { get; set; }

        [Display(Name = "Area")]
        public Nullable<int> AreaId { get; set; }

        [MaxLength(100, ErrorMessage = "Nombre maximo 100 caracteres")]
        [Required(ErrorMessage = "Nombre es Requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [MaxLength(200, ErrorMessage = "Nombre maximo 200 caracteres")]
        [Required(ErrorMessage = "Direccion es Requerida")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }


        [MaxLength(200, ErrorMessage = "Nombre maximo 200 caracteres")]
        [Required(ErrorMessage = "Cédula es Requerida")]
        [Display(Name = "Cedula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Sexo es Requerido")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Debe Seleccionar fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYY}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaNac { get; set; }

        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Display(Name = "Telefono")]
        public string Celular { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Dependencia")]
        public string Dependencia { get; set; }

        [Display(Name = "Etnia")]
        public Nullable<int> EtniaId { get; set; }

        [Display(Name = "Pais Nacimiento")]
        public Nullable<int> PaisId { get; set; }

        [Display(Name = "Departamento Reside")]
        public Nullable<int> DepartamentoId { get; set; }

        [Display(Name = "Municipio Reside")]
        public Nullable<int> MunicipioId { get; set; }

        [Display(Name = "Zona Reside")]
        public string Zona { get; set; }

        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Discapacidad { get; set; }

        [MaxLength(50, ErrorMessage = "Formacion Pedadogica Maximo 10 caracteres")]
        public string FormacionPedadogica { get; set; }

        [Display(Name = "Fecha Formacion Pedadogica")]
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYY}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaFormacionPedadogica { get; set; }

        [Display(Name = "Estudia Si/No")]
        [Required(ErrorMessage = "Dato Estudia Requerido")]
        public Nullable<bool> Estudia { get; set; }

        [Display(Name = "Nivel de Formación")]
        [Required(ErrorMessage = "Nivel de Formación es Requerido")]
        public string NivelFormacion { get; set; }

        [Display(Name = "Recibe Beca?")]
        [Required(ErrorMessage = "Definir si recibe beca es Requerido")]
        public string RecibeBeca { get; set; }

        [Display(Name = "Tipo de Beca")]
        public string TipoBeca { get; set; }

        [Display(Name = "Monto de Beca")]
        public Nullable<decimal> MontoBeca { get; set; }

        [Display(Name = "Tipo Contrato")]
        [Required(ErrorMessage = "Tipo de contrato es Requerido")]
        public Nullable<int> TipoContratoId { get; set; }


        [Display(Name = "Categoria Docente")]
        [Required(ErrorMessage = "Categoria Docente Requerido")]
        public string CategoriaEnDocente { get; set; }

        [Display(Name = "Servicios Programas Especiales")]
        public string ServiciosProgramasEspeciales { get; set; }

        [Display(Name = "Años de Antiguedad")]
        public long AnosAntiguedad { get; set; }

        [Display(Name = "Numero de Hijos")]
        public Nullable<short> NHijos { get; set; }

        [Display(Name = "Cargo Actual")]
        public Nullable<int> CargoActualId { get; set; }

        [Display(Name = "Cantidad de Grupos")]
        public Nullable<int> CantGrupos { get; set; }

        [Display(Name = "Horas Imparte Clases")]
        public Nullable<int> HorasClase { get; set; }

        [Display(Name = "Nº Inss")]
        public string NoInss { get; set; }

        [Display(Name = "Horas Clase Demana")]
        public Nullable<int> HorasClaseSemana { get; set; }

        [Display(Name = "Horas Investigacion Semana")]
        public Nullable<int> HorasInvestigacionSemana { get; set; }

        [Display(Name = "Tipo Investigacion Participa")]
        public string TipoInvestigacionParticipa { get; set; }

        [Display(Name = "Horas Extencion Semana")]
        public Nullable<int> HorasDedicadasExtencionSemana { get; set; }

        [Display(Name = "Institucion Realiza Extencion")]
        public string InstitucionRealizaExtencion { get; set; }

        [Display(Name = "Tutorias")]
        public string Tutorias { get; set; }

        [Display(Name = "Cant Alumno Masc Tutoria Monografia")]
        public Nullable<int> CantAlumnoMascTutoriaMonografia { get; set; }

        [Display(Name = "Cant Alumno Fem Tutoria Monografia")]
        public Nullable<int> CantAlumnoFemTutoriaMonografia { get; set; }

        [Display(Name = "Proyectos de Inves Total Estudiantes Masculino")]
        public string ProyectosInvesTotEstudianteMasculino { get; set; }

        [Display(Name = "Proyectos de Inves Total Estudiantes Femenino")]
        public string ProyectosInvTtotalEstudianteFem { get; set; }

        [Display(Name = "Horas en Curso Posgrado Total")]
        public Nullable<int> HorasenCursoPosgradoTotal { get; set; }

        [Display(Name = "Horas En Curso Postgrado Femenino")]
        public Nullable<int> HorasEnCursoPostgradoFemenino { get; set; }

        [Display(Name = "Movilidad Académica?")]
        public string MovilidadAcademica { get; set; }

        [Display(Name = "Tipo Mobilidad Académica")]
        public string TipoMobilidadAcademica { get; set; }

        [Display(Name = "Modalidad De Mobilidad")]
        public string ModalidadDeMobilidad { get; set; }

        [Display(Name = "Finalidad Mobilidad")]
        public string FinalidadMobilidad { get; set; }

        [Display(Name = "Duracion Mobilidad")]
        public string DuracionMobilidad { get; set; }

        [Display(Name = "Nombre Institución")]
        public string NombreInstitucion { get; set; }

        [Display(Name = "Capacitaciones Recibidas")]
        public Nullable<bool> CapacitacionesRecibidas { get; set; }

        [Display(Name = "Tematica Capacitaciones Recibidas")]
        public string TematicaCapacitacionRecibida { get; set; }

        [Display(Name = "Valor Por Hora Clase")]
        public Nullable<decimal> ValorXHoraClase { get; set; }
        public string UsuarioModifica { get; set; }

        [Display(Name = "Fecha Formacion Pedadogica")]
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYY}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        [Display(Name = "Fecha Formacion Pedadogica")]
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYY}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaModifica { get; set; }

        [Display(Name = "Activo")]
        public Nullable<bool> Activo { get; set; }

}
}