using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;

namespace BlackSys.Repository.AreaCapacitacion
{
    public interface IRepository
    {
        List<BlackSys.Models.Dal.AreaCapacitacion> GetAll();
        BlackSys.Models.Dal.AreaCapacitacion GetById(int id);
       
    }
}