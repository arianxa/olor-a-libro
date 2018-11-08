using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
