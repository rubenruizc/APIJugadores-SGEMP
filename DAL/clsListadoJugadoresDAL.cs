using ENT;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class clsListadoJugadoresDAL
    {

        /// <summary>
        /// Función que devuelve un listado de jugadores de la base de datos de azure.
        /// <br></br>
        /// Precondición: Ninguna
        /// <br></br>
        /// Postcondición: Puede devolver un listado vacío, por algún error con la BD
        /// </summary>
        /// <returns>Listado de puntuaciones</returns>
        public static List<clsJugador> listadoCompletoJugadoresDAL()
        {
            List<clsJugador> listadoJugadores = new List<clsJugador>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsJugador jugador;



            try
            {
                conexion = clsConexionBD.getConexion();
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.CommandText = "SELECT * FROM Jugador";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                            jugador = new clsJugador((int)miLector["id"]);

                            jugador.Nombre = (string)miLector["nombre"];

                            jugador.Puntuacion = (int)miLector["puntuacion"];
                            
                            listadoJugadores.Add(jugador);
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return listadoJugadores;
        }


    }
}
