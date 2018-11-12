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
    public partial class FormEditarUsuario : Form
    {
        Usuario modificarUsuario;     

        public FormEditarUsuario()
        {
            InitializeComponent();
        }
        //Pasamos el objeto (Usuario) seleccionado en la 'dataGridViewUsuarios'.
        public FormEditarUsuario(Usuario modificarUsuario)
        {
            InitializeComponent();
            this.modificarUsuario = modificarUsuario;
        }

        //Load: Los atributos del objeto que se ha seleccionado en la 'dataGridViewUsuarios' pasan a los textbox correspondientes.
        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            textBoxNombreUsuario.Text = modificarUsuario.nombre;
            textBoxContraseñaUsuario.Text = modificarUsuario.contraseña;
            textBoxCorreoUsuario.Text = modificarUsuario.correo;
            textBoxTelefonoUsuario.Text = modificarUsuario.telefono.ToString();
        }
        //Al pulsar el 'buttonGuardarUsuario' pasamos el contenido de los textbox a sus atributos correspondientes del objeto.
        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            modificarUsuario.nombre = textBoxNombreUsuario.Text;
            modificarUsuario.contraseña = textBoxContraseñaUsuario.Text;
            modificarUsuario.correo = textBoxCorreoUsuario.Text;
            modificarUsuario.telefono = int.Parse(textBoxTelefonoUsuario.Text);
            this.Close();
        }
    }
}
