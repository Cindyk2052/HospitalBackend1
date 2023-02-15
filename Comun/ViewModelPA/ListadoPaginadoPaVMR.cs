using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModelPA
{
    public class ListadoPaginadoPaVMR<T> { 
 
        public int cantidadTotal { get; set; }
       

        public IEnumerable<T> elemento { get; set; }
        public ListadoPaginadoPaVMR()
        {
            elemento = new List<T>();
            cantidadTotal = 0;
        }
    }
}


