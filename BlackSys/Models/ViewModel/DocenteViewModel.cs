using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;


namespace BlackSys.Models.ViewModel
{
    public class DocenteViewModel 
    {
        public Docente docente { get; set; }
        public  List<ViewDocenteAsignatura> asignaturasView { get; set; }

    }
}