using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public static class EgresoDAL
    {

        if(!string.isnullorEmpty(textoBusqueda))
            query= Queryable.where(e =>)
            e.medico.cedula.contains(textoBusqueda)
            ||
    }

    resultado.cantidadTotal= Queryable.Count();
    resuktado.elemento= query
            .orderBy(e=> e.id)
            .skyp(cantidad * pagina)
            .take(cantidad)
            .ToList()

    public static class egresoVmr   leerUno (long id)
    {
        egresoVmr 
    }

    public static long Crear(Egreso item)
    {
        long id = 0;
        using(var db= DbConexion.Create())
        {
            item.borrado= false
            item.fecha = DateTime.Now;
            db.Egreso.Add(item);
            db.SaveChanges();
        }

    public static void Actualizar(Egreso item)
    {
            using (var db= DbConexion.Create()) 
            {
            
            }
    }

    public static void Eliminar(List<long> ids) 
    {
            using (var db = DbConexion.Create())
            {
                var items = db.Egreso.Where(e => ids.Contains(e.id));

                foreach(var )

            }
    }





    }
}
