using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
   public class Libreria:IEquatable<Libreria>
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string nombreContacto { get; set; }

        public bool Equals(Libreria l)
        {
            bool igual = false;
            if (l.nombre == this.nombre && l.direccion == this.direccion)
            {

                igual = true;

            }
            return igual;
        }
    }

  
}
