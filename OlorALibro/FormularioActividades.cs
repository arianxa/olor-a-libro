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
    public partial class FormularioActividades : Form
    {
        
        List<Actividad> act;

        public FormularioActividades()
        {
            InitializeComponent();
        }

        public FormularioActividades(List<Actividad> act)
        {
            InitializeComponent();
            this.act = act;            
        }
        private void buttonCrearActividad_Click(object sender, EventArgs e)
        {

            // Crea actividad

            Actividad a = new Actividad();

            a.nombre = textBoxNombreActividad.Text;
            a.fechaInicio = dateTimeFechaInicio.Value;
            a.fechaFinal = DateTime.Parse(dateTimeFechaFinal.Text);
            a.categorias = new List<string>(); // inicializar las categorias
            foreach(String item in listBoxCategoriasActividades.SelectedItems) // bucle per selecionar mas de una categoria
            {
                a.categorias.Add(item);
            }
            a.descripcion = textBoxDescripcionActividades.Text;
            a.librerias = new List<string>(); 
            foreach (String item in listBoxLibreriasActividades.SelectedItems)
            {
                a.librerias.Add(item);
            }

            // Avisa quan intentes crear una activitat i ya esta creada
            if (act.Contains(a))
            {
                MessageBox.Show("Esta actividad ya esta creada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // sino la añade en la lista
            {
                act.Add(a); 
            }

            this.Close();
        }
    }
}