using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class clsListadoJugadoresBL
    {

        /// <summary>
        /// Función que devuelve un listado de jugadores.
        /// <br></br>
        /// Precondición: Ninguna
        /// <br></br>
        /// Postcondición: Puede devolver un listado vacío
        /// </summary>
        /// <returns>Listado de puntuaciones</returns>
        public static List<clsJugador> listadoCompletoJugadoresBL()
        {
            return DAL.clsListadoJugadoresDAL.listadoCompletoJugadoresDAL();
        }

        }
}
