﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Repository;
using Microsoft.AspNet.Identity;
using BlackSys.Models;
using BlackSys.Models.Dal;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity.Core.Objects;
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
            return _dtx.Docente.OrderBy(t => t.Nombre).ToList();
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
                var paramId = new ObjectParameter("NuevoId", typeof(int));
                // Llama al procedimiento almacenado
                _dtx.SpDocente(2,p.Id, p.RecintoId, p.ProfesionId, p.Nombre, p.Direccion, Convert.ToInt32(p.Celular), p.Telefono, p.Email,
                    p.CargoActualId, p.TipoDocumentoId, p.Cedula_Documento, p.Sexo, p.FechaNac, p.EtniaId, p.PaisId, p.DominaIdiomas,
                    p.NombreIdioma, p.NivelAlcanzado, p.DepartamentoId, p.MunicipioId, p.Zona, p.EstadoCivil,
                    p.NHijos, p.Discapacidad, p.AreaId, p.EjercicioDirectivoId, p.MaximoNivelFpId, p.NombreTitulos,
                    p.TieneFormacionPedagogica, p.NombreFormacionPedagogica, p.AnioFormacionPedadogica,
                    p.TipoContratoId, p.CategoriaDocenteId, p.PservUNICAM, p.PServ_UALN, p.PServ_RSJ, p.PServ_Prepa,
                    p.NoGrupos, p.NoAsignaturas, p.NoAsigMod, p.RealizaInvestigacion, p.DocenteAreaInvestigacionId, p.Tutorias,
                    p.NoMTGrado, p.NoFTGrado, p.NoMTPosgrado, p.NoFTPosgrado, p.Estudia, p.NivelFpEstudios,
                    p.NombreEstudios, p.BecaEstudios, p.ProcedBeca, p.TipoBeca, p.MontoBeca, p.Capacitaciones,
                    p.AreaCapacitacionId, p.NoInss, p.HorasClaseSemana, p.ValorXHoraClase, p.UsuarioModifica, p.Activo,p.RecintoId, paramId);
                //Models.Dal.Docente a = GetById(p.Id);
                //a.Nombre = p.Nombre;
                //a.NoInss = p.NoInss;
                //a.TipoDocumentoId = p.TipoDocumentoId;
                //a.Cedula_Documento = p.Cedula_Documento;
                //a.Sexo = p.Sexo;
                //a.FechaNac = p.FechaNac;
                //a.EtniaId = p.EtniaId;
                //a.PaisId = p.PaisId;
                //a.DominaIdiomas = p.DominaIdiomas;
                //a.NombreIdioma = p.NombreIdioma;
                //a.NivelAlcanzado = p.NivelAlcanzado;

                //a.DepartamentoId = p.DepartamentoId;
                //a.MunicipioId = p.MunicipioId;
                //a.Zona = p.Zona;
                //a.EstadoCivil = p.EstadoCivil;
                //a.NHijos = p.NHijos;
                //a.Discapacidad = p.Discapacidad;
                //a.AreaId = p.AreaId;
                //a.EjercicioDirectivoId = p.EjercicioDirectivoId;
                //a.MaximoNivelFpId = p.MaximoNivelFpId;
                //a.NombreTitulos = p.NombreTitulos;
                //a.TieneFormacionPedagogica = p.TieneFormacionPedagogica;
                //a.NombreFormacionPedagogica = p.NombreFormacionPedagogica;
                //a.AnioFormacionPedadogica = p.AnioFormacionPedadogica;
                //a.TipoContratoId = p.TipoContratoId;
                //a.CategoriaDocenteId = p.CategoriaDocenteId;
                //a.PservUNICAM = p.PservUNICAM;
                //a.PServ_UALN = p.PServ_UALN;
                //a.PServ_RSJ = p.PServ_RSJ;
                //a.PServ_Prepa = p.PServ_Prepa;
                //a.NoGrupos = p.NoGrupos;
                ////a.NoAsignaturas=a.NoAsignaturas;
                //a.NoAsigMod = p.NoAsigMod;
                //a.RealizaInvestigacion = p.RealizaInvestigacion;
                //a.DocenteAreaInvestigacionId = p.DocenteAreaInvestigacionId;
                //a.Tutorias = p.Tutorias;
                //a.NoMTGrado = p.NoMTGrado;
                //a.NoFTGrado = p.NoFTGrado;
                //a.NoMTPosgrado = p.NoMTPosgrado;
                //a.NoFTPosgrado = p.NoFTPosgrado;
                //a.Estudia = p.Estudia;
                //a.NivelFpEstudios = p.NivelFpEstudios;
                //a.NombreEstudios = p.NombreEstudios;
                //a.BecaEstudios = p.BecaEstudios;
                //a.ProcedBeca = p.ProcedBeca;
                //a.TipoBeca = p.TipoBeca;
                //a.MontoBeca = p.MontoBeca;
                //a.Capacitaciones = p.Capacitaciones;
                //a.AreaCapacitacionId = p.AreaCapacitacionId;
                //a.Activo = p.Activo;
                //a.UsuarioModifica = "user";
                //a.Email = p.Email;
                ////a.UsuarioModifica = principal.User.Identity.GetUserName();
                //a.ValorXHoraClase = p.ValorXHoraClase;
                //a.Zona = p.Zona;
                //a.HorasClaseSemana = p.HorasClaseSemana;
                //a.CargoActualId = p.CargoActualId;
                //a.TipoDocumentoId = p.TipoDocumentoId;
                //a.NoAsignaturas = p.NoAsignaturas;
                //_dtx.SaveChanges();
                return true;
            }
            catch (Exception E)
            {
                return false;
            }


            //}
           
           

        }
        public int Add(Docente p)
        {

            try
            {
                // Definir parámetro de salida para el nuevo ID
                var paramId = new ObjectParameter("NuevoId", typeof(int));
                // Llama al procedimiento almacenado
                _dtx.SpDocente(1, p.Id, p.RecintoId, p.ProfesionId, p.Nombre, p.Direccion, Convert.ToInt32(p.Celular), p.Telefono, p.Email,
                    p.CargoActualId, p.TipoDocumentoId, p.Cedula_Documento, p.Sexo, p.FechaNac, p.EtniaId, p.PaisId, p.DominaIdiomas,
                    p.NombreIdioma, p.NivelAlcanzado, p.DepartamentoId, p.MunicipioId, p.Zona, p.EstadoCivil,
                    p.NHijos, p.Discapacidad, p.AreaId, p.EjercicioDirectivoId, p.MaximoNivelFpId, p.NombreTitulos,
                    p.TieneFormacionPedagogica, p.NombreFormacionPedagogica, p.AnioFormacionPedadogica,
                    p.TipoContratoId, p.CategoriaDocenteId, p.PservUNICAM, p.PServ_UALN, p.PServ_RSJ, p.PServ_Prepa,
                    p.NoGrupos, p.NoAsignaturas, p.NoAsigMod, p.RealizaInvestigacion, p.DocenteAreaInvestigacionId, p.Tutorias,
                    p.NoMTGrado, p.NoFTGrado, p.NoMTPosgrado, p.NoFTPosgrado, p.Estudia, p.NivelFpEstudios,
                    p.NombreEstudios, p.BecaEstudios, p.ProcedBeca, p.TipoBeca, p.MontoBeca, p.Capacitaciones,
                    p.AreaCapacitacionId, p.NoInss, p.HorasClaseSemana, p.ValorXHoraClase, p.UsuarioModifica, p.Activo,p.RecintoId, paramId);
                //_dtx.Docente.Add(model);
                //_dtx.SaveChanges();
                int nuevoId = (int)paramId.Value;
                //int scope_identity_id = model.Id;
                return nuevoId;
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