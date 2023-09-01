using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace LogicaM
{
   public class ClsRepartidor
    {
        public int Sp { get; set; }
        public int SucId { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre_Repartidor { get; set; }
        public int EstadoActivoId { get; set; }
        public string RepartidorStatusOrden { get; set; }
        public string UltimaOrden { get; set; }
        public string OrdenConsecutivo { get; set; }



        ClsManejador manejador = new ClsManejador(); //agregamos referencia al ClsManejador 
        public string user;

        public DataTable ListarMensajero()
        {
            string msj = "";
            try
            {
            //List<ClsParametros> lst = new List<ClsParametros>()/*;*/
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@Id", Sp));
                return manejador.Listado("SpTblRepartidor", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

    }

    




}
