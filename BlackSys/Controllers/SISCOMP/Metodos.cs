using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models;

namespace BlackSys.Controllers.SISCOMP
{
    public class Metodos
    {
        public static int GetUltimoId (string Entidad,string atributo)
        {
            using (SISCOMPEntities db = new SISCOMPEntities())
            {
                try
                {
                    string query;
                    //query = "from data in db." + Entidad + " select data." + atributo;

                    int id = (from data in db.Oficina select data.Oficina_Id).Max();
                    //int id = (query).Max();
                    id = id + 1;
                    return id;

                }
                catch (Exception e)
                {
                    return 0;
                    
                }
            }

        }
    }
}