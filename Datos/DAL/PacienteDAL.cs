using Comun.ViewModelPA;
using Comun.ViewModels;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class PacienteDAL
    {
       public static ListadoPaginadoPaVMR<PacienteVMR> LeerTodo(int cantidad, int pagina, string textoBusqueda)
        {
            ListadoPaginadoPaVMR<PacienteVMR> resultado= new ListadoPaginadoPaVMR<PacienteVMR>();
            using(var db=DbConexion.Create())
            {
                var query = db.Paciente.Where(x => !x.borrado).Select(x => new PacienteVMR
                {
                    id = x.id,
                    cedula = x.cedula,
                    nombre = x.nombre + " " + x.apellidoPaterno + (x.apellidoMaterno != null ? (" " + x.apellidoMaterno) : " "),
                    correoElectronico=x.correoElectronico
                });
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    query = query.Where(x => x.cedula.Contains(textoBusqueda) 
                    || x.nombre.Contains(textoBusqueda)
                    || x.correoElectronico.Contains(textoBusqueda)) ;
                }
                resultado.cantidadTotal = query.Count();    
                resultado.elemento = query
                    .OrderBy(x => x.id)
                    .Skip(cantidad * pagina)
                    .Take(cantidad)
                    .ToList();
            }
            return resultado;    
        }
       /* LeerUno() { }
        Crear() { }
        actualizar() { }
        borrado() { }*/
    }
}
