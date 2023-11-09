using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using Newtonsoft.Json;

namespace BlackSys.Models.ViewModel
{
    public class DocenteViewModel 
    {
        [JsonIgnore]
        public Docente docente { get; set; }
        public  List<ViewDocenteAsignatura> asignaturasView { get; set; }

    }
}