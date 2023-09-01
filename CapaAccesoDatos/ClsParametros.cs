using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsParametros
    {
        //Parametros
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }


        //Contructores
        //Entrada
        public ClsParametros(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }

        //Salida
        public ClsParametros(String objNombre, SqlDbType objTipoDato, Int32 ObjTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = ObjTamaño;
            Direccion = ParameterDirection.Output;
        }
    }
}
