using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsManejadoraJugadoresDAL
    {

        /// <summary>
        /// Inserta un nuevo jugador en la base de datos.
        /// <br></br>
        /// Precondición: El objeto clsJugador debe contener datos válidos para todas las propiedades requeridas.
        /// <br></br>
        /// Postcondición: Devuelve el número de filas afectadas (1 si se ha introducido, 0 si falla, 0 si falla).
        /// </summary>
        /// <param name="jugador">Objeto clsJugador con los detalles del jugador a insertar</param>
        /// <returns>Número de filas afectadas en la base de datos</returns>
        public static int insertarJugadorDAL(clsJugador jugador)
        {
            int numeroFilasAfectadas = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                conexion = clsConexionBD.getConexion();

                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = jugador.Nombre;
                miComando.Parameters.Add("@puntuacion", System.Data.SqlDbType.VarChar).Value = jugador.Puntuacion;


                miComando.CommandText = "INSERT INTO Jugador " +
                    "VALUES (@nombre, @puntuacion)";
                miComando.Connection = conexion;

                numeroFilasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return numeroFilasAfectadas;
        }

    }
}
