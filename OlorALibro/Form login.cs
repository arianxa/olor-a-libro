using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    public partial class Form_login : Form
    {

        Usuario admnistrador;

        /*CONSTRUCTOR*/
        public Form_login()
        {
            InitializeComponent();
        }

        /*FORMULARIO*/
            /*load*/
        private void Form_login_Load(object sender, EventArgs e)
        {
            JObject usuario = JObject.Parse(File.ReadAllText(@"..\..\Jason\datosLogin.json")); //cargamos el fitxero json a usuario
            admnistrador = usuario.ToObject<Usuario>(); //passo los datos de usuario a administrador          
        }
            /*Boton Aceptar*/
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == admnistrador.nombre && textBoxContrasenia.Text == admnistrador.contrasenia) //comprobamos si los datos introducidos son iguales a los de administrador
            {                
               // FormPrincipal f = new FormPrincipal();
                //f.Show();//abrimos el FormPrincipal               
            }
            else
            {
                MessageBox.Show("Contrasña incorrecta o usuario incorrecto", "Información Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNombre.Clear();
                textBoxContrasenia.Clear();
            }
        }        
    }
}
