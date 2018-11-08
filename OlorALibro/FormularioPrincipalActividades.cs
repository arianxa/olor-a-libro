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
    public partial class FormularioPrincipalActividades : Form
    {
        List<Actividad> actividad = new List<Actividad>();

        public FormularioPrincipalActividades()
        {
            InitializeComponent();
        }

        private void refrescarDataGread()
        {
            dataGridViewActividades.DataSource = null; // ho posa a 0. / DATASOURCE --> datos
            dataGridViewActividades.DataSource = actividad; // les dades provenen de la classe activitats
        }
        private void guardar()
        {
            JArray JArrayActividad = (JArray)JToken.FromObject(actividad); // agafem la llista i desde el objecte (fromObject) crea el JToken i el pasa a JArray
            StreamWriter fitxer = File.CreateText(@"actividades.json"); // agafa el fitxer i el "converteix" amb json || @ per que sapiga que es una ruta
            JsonTextWriter jsonWriter = new JsonTextWriter(fitxer); // escriu en el fitxer que hem creat abans 

            JArrayActividad.WriteTo(jsonWriter); // guarda lo del array al jsonWriter

            jsonWriter.Close();
        }    

        private void buttonAñadirActividades_Click(object sender, EventArgs e)
        {
            FormularioActividades f = new FormularioActividades(actividad); // le pasamos la lista para que en el otro formulario vaya añadiendo las actividades nuevas
            f.Text = "Formulario Actividades";
            f.ShowDialog();
        }

        private void buttonModificarActividades_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;

            FormularioModificarActividades f = new FormularioModificarActividades(a);
            f.Text = "Formulario Actividades";
            f.ShowDialog();
    }

        private void buttonEliminarActividades_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;
            actividad.Remove(a);
            refrescarDataGread();
        }

        private void buttonSalirActividad_Click(object sender, EventArgs e)
        {
            guardar();
            Close(); // Cuando salga ira al formulario inicial. Falta 
        }

        private void FormularioPrincipalActividades_Load(object sender, EventArgs e)
        {
            if (File.Exists("actividades.json")) // si existeix el sobrescribim
            {
                JArray JArrayActividad = JArray.Parse(File.ReadAllText("actividades.json")); // Llegeix el fitxer
                actividad = JArrayActividad.ToObject<List<Actividad>>(); // agafem el fitxer i el converteix en llista 

            }
            else       // sino existeix el crea
            {
                actividad = new List<Actividad>();
            }

            dataGridViewActividades.DataSource = actividad; // mostra la llista a la gridView
            refrescarDataGread();
        }

        private void FormularioPrincipalActividades_Activated(object sender, EventArgs e)
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = actividad; // mostra la peli al dataGridView
        }

        private void FormularioPrincipalActividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            // hacer opcion de salir i guardar o salir sin guardar
            DialogResult resultado;

            resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                guardar();
            }
            
        }
    }
}