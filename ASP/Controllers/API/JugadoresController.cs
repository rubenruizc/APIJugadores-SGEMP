using ENT;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController : ControllerBase
    {
        // GET: api/<JugadoresController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<clsJugador> listadoCompleto = new List<clsJugador>();


            try
            {
                listadoCompleto = BL.clsListadoJugadoresBL.listadoCompletoJugadoresBL();

                if (listadoCompleto.Count() == 0)
                {
                    salida = NoContent();
                }
                else
                {
                    salida = Ok(listadoCompleto);
                }
            }
            catch
            {
                salida = BadRequest();
            }

            return salida;
        }


        // POST api/<JugadoresController>
        [HttpPost]
        public IActionResult Post(clsJugador jugadorInsertar)
        {
            IActionResult salida;

            int numeroFilasAfectadas = 0;

            try
            {

                numeroFilasAfectadas = BL.clsManejadoraJugadoresBL.insertarJugadorBL(jugadorInsertar);


                if (numeroFilasAfectadas == 0)
                {
                    salida = NotFound();
                }
                else
                {
                    salida = Ok(numeroFilasAfectadas);
                }
            }
            catch (Exception e)
            {
                salida = BadRequest();
            }

            return salida;
        }

    }
}
