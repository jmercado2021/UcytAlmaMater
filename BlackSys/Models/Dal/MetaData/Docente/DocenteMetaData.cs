using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BlackSys.Models.Dal.MetaData.Docente
{
    public class DocenteMetaData
    {
         [Display(Name="Identificador")]
        public int Id { get; set; }
        public int RecintoId { get; set; }
        public int ProfesionId { get; set; }
        public Nullable<int> AreaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }

        public string Sexo { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
        public string Dependencia { get; set; }
        public Nullable<int> EtniaId { get; set; }
        public Nullable<int> PaisId { get; set; }
        public Nullable<int> DepartamentoId { get; set; }
        public Nullable<int> MunicipioId { get; set; }
        public string Zona { get; set; }
        public string Discapacidad { get; set; }
        public string FormacionPedadogica { get; set; }
        public Nullable<System.DateTime> FechaFormacionPedadogica { get; set; }
        public Nullable<bool> Estudia { get; set; }
        public string NivelFormacion { get; set; }
        public string RecibeBeca { get; set; }
        public string TipoBeca { get; set; }
        public Nullable<decimal> MontoBeca { get; set; }
        public Nullable<int> TipoContratoId { get; set; }
        public string CategoriaEnDocente { get; set; }
        public string ServiciosProgramasEspeciales { get; set; }
        public Nullable<int> AnosAntiguedad { get; set; }
        public Nullable<int> NHijos { get; set; }
        public Nullable<int> CargoActualId { get; set; }
        public Nullable<int> CantGrupos { get; set; }
        public string HorasClase { get; set; }
        public string NoInss { get; set; }
        public string HorasClaseSemana { get; set; }
        public string HorasInvestigacionSemana { get; set; }
        public string TipoInvestigacionParticipa { get; set; }
        public string HorasDedicadasExtencionSemana { get; set; }
        public Nullable<int> InstitucionRealizaExtencion { get; set; }
        public Nullable<bool> Tutorias { get; set; }
        public Nullable<int> CantAlumnoMascTutoriaMonografia { get; set; }
        public string CantAlumnoFemTutoriaMonografia { get; set; }
        public Nullable<int> ProyectosInvesTotEstudianteMasculino { get; set; }
        public Nullable<int> ProyectosInvTtotalEstudianteFem { get; set; }
        public Nullable<int> HorasenCursoPosgradoTotal { get; set; }
        public Nullable<int> HorasEnCursoPostgradoFemenino { get; set; }
        public Nullable<bool> MovilidadAcademica { get; set; }
        public string TipoMobilidadAcademica { get; set; }
        public string ModalidadDeMobilidad { get; set; }
        public string FinalidadMobilidad { get; set; }
        public string DuracionMobilidad { get; set; }
        public string NombreInstitucion { get; set; }
        public string CapacitacionesRecibidas { get; set; }
        public string TematicaCapacitacionRecibida { get; set; }
        public Nullable<decimal> ValorXHoraClase { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}