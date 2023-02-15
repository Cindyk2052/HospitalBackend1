using Comun.ViewModelPA;
using Comun.ViewModels;
using Logica.BLL;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class EgresoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult LeerTodo (int cantidad=10, int pagina= 0, string textoConsultado= null)
        {
            var respuesta = new RespuestaVMR<ListadoPaginadoPaVMR<EgresoVMR>>();

            try
            {
                respuesta.datos = EgresoBLL.LeerTodo (cantidad, pagina, textoConsultado);

            }
            catch (Exception e)
            {
                respuesta.codigo = HttpStatusCode.InternalServerError;
                respuesta.datos = null;
                respuesta.mensajes.Add(e.Message);
                respuesta.mensajes.Add(e.ToString());
            }

            return Content(respuesta.codigo, respuesta);
            {

            }
        }
        
        /*public IHttpActionResult leerUno(long id)
        {

        }

        public IHttpActionResult Crear(Medico item)
        {

        }

        public IHttpActionResult Actualizar(long id, MedicoVMR item)
        {

        }

        public IHttpActionResult Eliminar(List<long> ids)
        {

        }*/

    }   
}
