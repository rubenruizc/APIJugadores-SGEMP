using ENT;

namespace BL
{
    public class clsManejadoraJugadoresBL
    {
        /// <summary>
        /// Inserta un nuevo jugador.
        /// <br></br>
        /// Precondición: El objeto clsJugador debe contener datos válidos para todas las propiedades requeridas.
        /// <br></br>
        /// Postcondición: Devuelve el número de filas afectadas (1 si la inserción es exitosa, 0 si falla).
        /// </summary>
        /// <param name="jugador">Objeto clsJugador con los detalles del jugador a insertar</param>
        /// <returns>Número de filas afectadas</returns>
        public static int insertarJugadorBL(clsJugador jugador)
        {
            return DAL.clsManejadoraJugadoresDAL.insertarJugadorDAL (jugador);
        }
        }
}
