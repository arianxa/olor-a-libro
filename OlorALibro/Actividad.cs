using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    public class Actividad : IEquatable<Actividad>
    {
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<string> categorias { get; set; }
        public string descripcion { get; set; }
        public List<string> librerias { get; set; }


        // Saber quan una activitat es repeteix
        public bool Equals(Actividad a) 
        {
            bool igual = false;

            if (a.nombre == this.nombre && a.fechaInicio == this.fechaInicio && a.fechaFinal == this.fechaFinal)
            {
                igual = true;
            }
            return igual;
        }
    }
}
