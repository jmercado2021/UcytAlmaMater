using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models;

namespace BlackSys.Models
{
    public class Metodos
    {
        AspNetUsers db = new AspNetUsers();
        public AspNetUsers Obtener(string id)
        {
            var usuario = new AspNetUsers();

            using (var context = new BlackSysEntities())
            {
                try
                {
                    usuario = context.AspNetUsers
                                    .Where(x => x.Id == id)
                                    .SingleOrDefault();
                }
                catch (Exception e)
                {

                }
            }

            return usuario;
        }
    }
}