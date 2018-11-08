using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{

    public partial class FormModificarLibreria : Form
    {
        //List<Libreria> libreria = new List<Libreria>();
        Libreria modlibreria;
        public FormModificarLibreria()
        {
            InitializeComponent();
        }
        public FormModificarLibreria(Libreria modlibreria)//
        {
            InitializeComponent();
            this.modlibreria = modlibreria;
            //libreria = libreri;
        }
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
            private void FormModificarLibreria_Load(object sender, EventArgs e)
            {

                textBoxnombreMod.Text = modlibreria.nombre;
                textBoxtelefonoMod.Text = modlibreria.telefono.ToString();
                textBoxdireccionMod.Text = modlibreria.direccion;
                textBoxnombrecontactoMod.Text = modlibreria.nombreContacto;




            }
            private void buttonAceptarMod_Click(object sender, EventArgs e)
            {

                modlibreria.nombre = textBoxnombreMod.Text;
                modlibreria.direccion = textBoxdireccionMod.Text;
                modlibreria.telefono = int.Parse(textBoxtelefonoMod.Text);
                modlibreria.nombreContacto = textBoxnombrecontactoMod.Text;
                this.Close();



            }


        }
    }
}


    
