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
    public partial class FormRellenarLibrerias : Form
    {

        List<Libreria> libreria = new List<Libreria>();
        public FormRellenarLibrerias()
        {
            InitializeComponent();
        }
        
        public FormRellenarLibrerias(List<Libreria> libreri)
        {
            InitializeComponent();
            libreria = libreri;
        }
      
    

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            Libreria l = new Libreria();
            l.nombre = textBoxnombre.Text;
            l.direccion = textBoxdireccion.Text;
            l.telefono = int.Parse(textBoxtelefono.Text);
            l.nombreContacto = textBoxnombrecontacto.Text;
            GuardadoYErrores(l);// le pasamos la libreria


           
           
          
          

            //this.Close();
        }
        private void GuardadoYErrores(Libreria l)
        {
            if (l.nombre == "")
            {

                MessageBox.Show("No has añadido bien el nombre!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxnombre.Focus();

            }
            else if (l.direccion == "")
            {
                MessageBox.Show("No has añadido bien la direccion!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxdireccion.Focus();


            }
            else if (libreria.Contains(l))
      
                {
                    MessageBox.Show("Esta libreria ya esta creada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                libreria.Add(l);
                this.Close();

            }
        }

        private void textBoxnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten letras");
            }

        }

        private void comprobarletras()
        {
            

        }
    }
}
