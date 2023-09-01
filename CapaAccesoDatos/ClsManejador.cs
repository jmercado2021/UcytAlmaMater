using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaAccesoDatos
{
   
    public class ClsManejador
    {
        //SqlConnection conexion = new SqlConnection();

        //CONEXION LDCOM
        //string conexion = "Data Source=172.16.1.28;Initial Catalog=COMERCIAL;User ID=jmercado;Password=FCITY2K14!";
        //CONEXION BDFCITY
        //string ConexDBDFCITY = "Data Source=192.168.11.7;Initial Catalog=BD_FARMACITY;User ID=FCITY;Password=FCITY2K14!";
        SqlConnection conexion = new SqlConnection("Data Source=172.16.1.28;Initial Catalog=COMERCIAL;User ID=jmercado;Password=j123456");

      
        public void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }

        //Metodo para cerrar conexion
        public void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        //Metodo para ejecutar sp(Insertar, Borrar, Modificar)
        public void Ejecutar_sp(String NombreSP, List<ClsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                abrirConexion();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    //recorremos los parametros de entrada
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();

                    //recuperamos los parametros de salida
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            cerrarConexion();
        }



        //Metodo para los listados o consultas (SELECT)
        public DataTable Listado(String NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

    }
}
