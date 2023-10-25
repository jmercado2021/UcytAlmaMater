using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Repository;
using Microsoft.AspNet.Identity;
using BlackSys.Models;
using BlackSys.Models.Dal;
using System.Web.Mvc;
//using System.Security.Principal;


namespace BlackSys.Repository.Docentes
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private System.Security.Principal.IPrincipal principal;
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<Docente> GetAll()
        {
            return _dtx.Docente.ToList();
        }
        public Docente GetById(int id)
        {
            return _dtx.Docente.Where(t => t.Id==id).FirstOrDefault();
        }
        public List<Docente> FindByName(string Nombre)
        {
            return _dtx.Docente.Where(x => x.Nombre.Contains("Nombre")).ToList();
        }
        public List<ViewDocenteAsignatura> LoadDocenteAsignatura(int id)
        {
           IQueryable<ViewDocenteAsignatura> ls = _dtx.ViewDocenteAsignatura.Where(tt => tt.DocenteId==id).OrderBy(t => t.Asignatura);
            return ls.ToList();

        }
        public bool Update(Docente p)
        {
         
            try
            {
                Models.Dal.Docente a = GetById(p.Id);
                a.Nombre = p.Nombre;
                a.NoInss = p.NoInss;
                a.MunicipioId = p.MunicipioId;
                a.Activo = p.Activo;
                a.AnosAntiguedad = p.AnosAntiguedad;
                a.AreaId = p.AreaId;
                a.CantAlumnoFemTutoriaMonografia = p.CantAlumnoFemTutoriaMonografia;
                a.CantAlumnoMascTutoriaMonografia = p.CantAlumnoMascTutoriaMonografia;
                a.CantGrupos = p.CantGrupos;
                a.CapacitacionesRecibidas = p.CapacitacionesRecibidas;
                a.Cargo = p.Cargo;
                a.CargoActualId = p.CargoActualId;
                a.CategoriaEnDocente = p.CategoriaEnDocente;
                a.Cedula = p.Cedula;
                a.Celular = p.Celular;
                a.DepartamentoId = p.DepartamentoId;
                a.Dependencia = p.Dependencia;
                a.Direccion = p.Direccion;
                a.Discapacidad = p.Discapacidad;
                a.DuracionMobilidad = p.DuracionMobilidad;
                a.Email = p.Email;
                a.EstadoCivil = p.EstadoCivil;
                a.Estudia = p.Estudia;
                a.EtniaId = p.EtniaId;
                a.FechaFormacionPedadogica = p.FechaFormacionPedadogica;
                a.FechaModifica = p.FechaModifica;
                a.FechaNac = p.FechaNac;
                a.FinalidadMobilidad = p.FinalidadMobilidad;
                a.FormacionPedadogica = p.FormacionPedadogica;
                a.HorasClase = p.HorasClase;
                a.HorasClaseSemana = p.HorasClaseSemana;
                a.HorasDedicadasExtencionSemana = p.HorasDedicadasExtencionSemana;
                a.HorasenCursoPosgradoTotal = p.HorasenCursoPosgradoTotal;
                a.HorasEnCursoPostgradoFemenino = p.HorasEnCursoPostgradoFemenino;
                a.HorasInvestigacionSemana = p.HorasInvestigacionSemana;
                a.InstitucionRealizaExtencion = p.InstitucionRealizaExtencion;
                a.ModalidadDeMobilidad = p.ModalidadDeMobilidad;
                a.MontoBeca = p.MontoBeca;
                a.MovilidadAcademica = p.MovilidadAcademica;
                a.MunicipioId = p.MunicipioId;
                a.NHijos = p.NHijos;
                a.NivelFormacionId = p.NivelFormacionId;
                a.PaisId = p.PaisId;
                a.NombreInstitucion = p.NombreInstitucion;
                a.ProfesionId = p.ProfesionId;
                a.ProyectosInvesTotEstudianteMasculino = p.ProyectosInvesTotEstudianteMasculino;
                a.ProyectosInvTtotalEstudianteFem = p.ProyectosInvTtotalEstudianteFem;
                a.RecibeBeca = p.RecibeBeca;
                a.RecintoId = p.RecintoId;
                a.ServiciosProgramasEspeciales = p.ServiciosProgramasEspeciales;
                a.Sexo = p.Sexo=="1"? "F":"M";
                a.Telefono = p.Telefono;
                a.TematicaCapacitacionRecibida = p.TematicaCapacitacionRecibida;
                a.TipoBeca = p.TipoBeca;
                a.TipoContratoId = p.TipoContratoId;
                a.TipoInvestigacionParticipa = p.TipoInvestigacionParticipa;
                a.TipoMobilidadAcademica = p.TipoMobilidadAcademica;
                a.Tutorias = p.Tutorias;
                a.UsuarioModifica = "user";
                //a.UsuarioModifica = principal.User.Identity.GetUserName();
                a.ValorXHoraClase = p.ValorXHoraClase;
                a.Zona = p.Zona;
                a.TipoDocumentoId = p.TipoDocumentoId;
                //_dtx.SaveChanges();
                return true;
            }
            catch (Exception E)
            {
                return false;
            }


            //}
           
           

        }
        public int Add(Docente model)
        {

            try
            {
                //Models.Dal.Docente a = GetById(p.Id);
                //a.Nombre = p.Nombre;
                //a.NoInss = p.NoInss;
                //a.MunicipioId = p.MunicipioId;
                //a.Activo = p.Activo;
                //a.AnosAntiguedad = p.AnosAntiguedad;
                //a.AreaId = p.AreaId;
                //a.CantAlumnoFemTutoriaMonografia = p.CantAlumnoFemTutoriaMonografia;
                //a.CantAlumnoMascTutoriaMonografia = p.CantAlumnoMascTutoriaMonografia;
                //a.CantGrupos = p.CantGrupos;
                //a.CapacitacionesRecibidas = p.CapacitacionesRecibidas;
                //a.Cargo = p.Cargo;
                //a.CargoActualId = p.CargoActualId;
                //a.CategoriaEnDocente = p.CategoriaEnDocente;
                //a.Cedula = p.Cedula;
                //a.Celular = p.Celular;
                //a.DepartamentoId = p.DepartamentoId;
                //a.Dependencia = p.Dependencia;
                //a.Direccion = p.Direccion;
                //a.Discapacidad = p.Discapacidad;
                //a.DuracionMobilidad = p.DuracionMobilidad;
                //a.Email = p.Email;
                //a.EstadoCivil = p.EstadoCivil;
                //a.Estudia = p.Estudia;
                //a.EtniaId = p.EtniaId;
                //a.FechaFormacionPedadogica = p.FechaFormacionPedadogica;
                //a.FechaModifica = p.FechaModifica;
                //a.FechaNac = p.FechaNac;
                //a.FinalidadMobilidad = p.FinalidadMobilidad;
                //a.FormacionPedadogica = p.FormacionPedadogica;
                //a.HorasClase = p.HorasClase;
                //a.HorasClaseSemana = p.HorasClaseSemana;
                //a.HorasDedicadasExtencionSemana = p.HorasDedicadasExtencionSemana;
                //a.HorasenCursoPosgradoTotal = p.HorasenCursoPosgradoTotal;
                //a.HorasEnCursoPostgradoFemenino = p.HorasEnCursoPostgradoFemenino;
                //a.HorasInvestigacionSemana = p.HorasInvestigacionSemana;
                //a.InstitucionRealizaExtencion = p.InstitucionRealizaExtencion;
                //a.ModalidadDeMobilidad = p.ModalidadDeMobilidad;
                //a.MontoBeca = p.MontoBeca;
                //a.MovilidadAcademica = p.MovilidadAcademica;
                //a.MunicipioId = p.MunicipioId;
                //a.NHijos = p.NHijos;
                //a.NivelFormacion = p.NivelFormacion;
                //a.PaisId = p.PaisId;
                //a.NombreInstitucion = p.NombreInstitucion;
                //a.ProfesionId = p.ProfesionId;
                //a.ProyectosInvesTotEstudianteMasculino = p.ProyectosInvesTotEstudianteMasculino;
                //a.ProyectosInvTtotalEstudianteFem = p.ProyectosInvTtotalEstudianteFem;
                //a.RecibeBeca = p.RecibeBeca;
                //a.RecintoId = p.RecintoId;
                //a.ServiciosProgramasEspeciales = p.ServiciosProgramasEspeciales;
                //a.Sexo = p.Sexo == "1" ? "F" : "M";
                //a.Telefono = p.Telefono;
                //a.TematicaCapacitacionRecibida = p.TematicaCapacitacionRecibida;
                //a.TipoBeca = p.TipoBeca;
                //a.TipoContratoId = p.TipoContratoId;
                //a.TipoInvestigacionParticipa = p.TipoInvestigacionParticipa;
                //a.TipoMobilidadAcademica = p.TipoMobilidadAcademica;
                //a.Tutorias = p.Tutorias;
                //a.UsuarioModifica = "user";
                ////a.UsuarioModifica = principal.User.Identity.GetUserName();
                //a.ValorXHoraClase = p.ValorXHoraClase;
                //a.Zona = p.Zona;
                //_dtx.SaveChanges();
                _dtx.Docente.Add(model);
                _dtx.SaveChanges();
                int scope_identity_id = model.Id;
                return scope_identity_id;
            }
            catch (Exception E)
            {
                return 0;
            }


            //}



        }
        public List<ViewDocenteAsignatura> GetSubjectDocente(Docente model, int AsignaturaId)
        {
            IQueryable<ViewDocenteAsignatura> ls = _dtx.ViewDocenteAsignatura.Where(tt => tt.DocenteId == model.Id && tt.AsignaturaId ==AsignaturaId);

            return ls.ToList();

        }

        public bool AddSubject(Docente model,int AsignaturaId)
        {
            try
            {
                DocenteAsignatura docSubject = new DocenteAsignatura()
                {
                    DocenteId = model.Id,
                    RecintoId = model.RecintoId,
                    AsignaturaId = AsignaturaId,
                    Activo = true
                };
                _dtx.DocenteAsignatura.Add(docSubject);
                 Save();
                return true;
            }
           catch(Exception ex)
            {
                return false;
            }  
        }
        public bool DeleteSubject(int DocenteId, int AsignaturaId)
        {
            try
            {
                var docSubject = _dtx.DocenteAsignatura.Where(tt => tt.DocenteId == DocenteId && tt.AsignaturaId == AsignaturaId);

                foreach (var registro in docSubject)
                {
                    _dtx.DocenteAsignatura.Remove(registro);
                }
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Save()
        {
            _dtx.SaveChanges();
        }


    }
}