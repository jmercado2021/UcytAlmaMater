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
            M=0,
            [Display(Name = "Femenino")]
            F=1
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
        public enum NotificationType
        {
            error,
            success,
            warning,
            info
        }
    }
}