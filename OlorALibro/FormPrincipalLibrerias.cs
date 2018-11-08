using Newtonsoft.Json;
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
    public partial class FormPrincipalLibrerias : Form
    {
        List<Libreria> libreri;
        public FormPrincipalLibrerias()
        {
            InitializeComponent();
        }

        private void FormPrincipalLibrerias_Activated(object sender, EventArgs e)
        {
            dataGridViewPrincipalLibrerias.DataSource = null;
         dataGridViewPrincipalLibrerias.DataSource = libreri;
        }

        private void FormPrincipalLibrerias_Load(object sender, EventArgs e)
        {

         
            tools();
            if (File.Exists("libreriasjson.json"))
            {
                JArray jarrayLibreria = JArray.Parse(File.ReadAllText("libreriasjson.json"));
                libreri = jarrayLibreria.ToObject<List<Libreria>>();

                dataGridViewPrincipalLibrerias.DataSource = null;
                dataGridViewPrincipalLibrerias.DataSource = libreri;
            }
            else
            {
                libreri = new List<Libreria>();

                dataGridViewPrincipalLibrerias.DataSource = null;
                dataGridViewPrincipalLibrerias.DataSource = libreri;

            }


        }
        private void buttonAñadir_Click(object sender, EventArgs e)
        {

           
            FormRellenarLibrerias libreria = new FormRellenarLibrerias(libreri);
            libreria.ShowDialog();
    
           
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
           
            libreri.Remove((Libreria)dataGridViewPrincipalLibrerias.SelectedRows[0].DataBoundItem);

            dataGridViewPrincipalLibrerias.DataSource = null;
            dataGridViewPrincipalLibrerias.DataSource = libreri;
         

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Libreria l = (Libreria)dataGridViewPrincipalLibrerias.SelectedRows[0].DataBoundItem;
            FormModificarLibreria f = new FormModificarLibreria(l);
            f.Text = "Formulario Librerias";
            f.ShowDialog();
         
           
            //FormRellenarLibrerias libreria = new FormRellenarLibrerias();
            //libreria =(Libreria) dataGridViewPrincipalLibrerias.SelectedRows[0].DataBoundItem;

            //libreria.ShowDialog();

        }
        private void guardarJson()
        {
          
            JArray jarrayLibreria = (JArray)JToken.FromObject(libreri);
            StreamWriter fichero = File.CreateText("libreriasjson.json");
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);
            jarrayLibreria.WriteTo(jsonWriter);
            jsonWriter.Close();
            

        }
        private void tools()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(buttonAñadir, "Añadir");
            toolTip1.SetToolTip(buttonEliminar, "Eliminar");
            toolTip1.SetToolTip(buttonEditar, "Editar");
        }

        private void FormPrincipalLibrerias_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Quieres guardar antes de salir? ", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                guardarJson();
            }
    
        }

        private void libreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipalLibrerias libreria = new FormPrincipalLibrerias();
                
            libreria.ShowDialog();
        }
    }
}
