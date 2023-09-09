using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;

namespace BlackSys.Repository.Departamento
{
    public interface IRepository
    {
        List<BlackSys.Models.Dal.Departamento> GetAll();
        BlackSys.Models.Dal.Departamento GetById(int id);
       
    }
}