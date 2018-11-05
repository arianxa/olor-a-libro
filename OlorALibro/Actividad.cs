using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    class Actividad
    {
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<string> categorias { get; set; }
        public string descripcion { get; set; }
        public List<string> librerias { get; set; }
    }
}
