using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsConexionBD
    {

        /// <summary>
        /// Función estática que devuelve una conexión abierta a la bd  
        /// </summary>
        /// <returns></returns>
        public static SqlConnection getConexion()
        {
            SqlConnection miConexion = new SqlConnection();

            try
            {

                miConexion.ConnectionString = "server=auri.database.windows.net;database=auriDB;uid=usuario;pwd=LaCampana123;trustServerCertificate = true;";

                miConexion.Open();

            }
            catch (Exception ex)
            {
                throw;
            }

            return miConexion;
        }


    }

}
