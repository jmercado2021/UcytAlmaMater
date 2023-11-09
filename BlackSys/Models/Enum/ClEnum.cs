using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackSys.Models.Enum
{
    public class ClEnum
    {
        public enum Gender
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Masculino")]
            Masculino=1,
            [Display(Name = "Femenino")]
            Femenino=2
        }

        public enum CivilStatus
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Soltero")]
            Soltero = 1,
            [Display(Name = "Casado")]
            Casado = 2,
            [Display(Name = "Union de Hecho")]
            Union_de_Hecho = 3
        }

        public enum OriginBeca
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Institucional")]
            Institucional = 1,
            [Display(Name = "No Institucional")]
            NoInstitucional = 2,
            [Display(Name = "No Aplica")]
            NoAplica = 3
        }
        public enum TypeBeca
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Completa")]
            Completa = 1,
            [Display(Name = "Parcial")]
            Parcial = 2,
            [Display(Name = "No Aplica")]
            NoAplica = 3
        }
        public enum Zone
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Urbano")]
            Urbano = 1,
            [Display(Name = "Rural")]
            Rural = 2,
        
        }

        //public enum Lenguages
        //{
        //    [Display(Name = "Español")]
        //    Español= 0,
        //    [Display(Name = "Ingles")]
        //    Ingles = 1,
        //   [Display(Name = "Frances")]
        //    Frances = 2,
        //    [Display(Name = "Aleman")]
        //    Aleman = 3,
        //    [Display(Name = "Portugues")]
        //    Portugues = 4
        //}

        public enum SelectTrueFalse
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Si")]
            Si = 1,
            [Display(Name = "No")]
            No =2


        }

        public enum SelectTrueFalseEstudies
        {
            [Display(Name = "Seleccione una opción")]
            SinAsignar = 0,
            [Display(Name = "Si")]
            Si =1,
            [Display(Name = "No")]
            No = 2,
            [Display(Name = "No Aplica")]
            NoAplica = 3


        }
        public enum NotificationType
        {
            error,
            success,
            warning,
            info
        }
    }
}