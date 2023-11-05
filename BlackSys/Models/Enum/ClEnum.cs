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
            [Display(Name = "Masculino")]
            Masculino=0,
            [Display(Name = "Femenino")]
            Femenino=1
        }

        public enum CivilStatus
        {
            [Display(Name = "Soltero")]
            Soltero = 0,
            [Display(Name = "Casado")]
            Casado = 1,
            [Display(Name = "Union de Hecho")]
            Union_de_Hecho = 2
        }

        public enum OriginBeca
        {
            [Display(Name = "Institucional")]
            Institucional = 0,
            [Display(Name = "No Institucional")]
            NoInstitucional = 1,
            [Display(Name = "No Aplica")]
            NoAplica = 2
        }
        public enum TypeBeca
        {
            [Display(Name = "Completa")]
            Completa = 0,
            [Display(Name = "Parcial")]
            Parcial = 1,
            [Display(Name = "No Aplica")]
            NoAplica = 2
        }
        public enum Zone
        {
            [Display(Name = "Urbano")]
            Urbano = 0,
            [Display(Name = "Rural")]
            Rural = 1,
        
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
            [Display(Name = "Si")]
            Si = 0,
            [Display(Name = "No")]
            No = 1


        }

        public enum SelectTrueFalseEstudies
        {
            [Display(Name = "Si")]
            Si = 0,
            [Display(Name = "No")]
            No = 1,
            [Display(Name = "No Aplica")]
            NoAplica = 2


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