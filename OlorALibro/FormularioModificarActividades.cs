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
    public partial class FormularioModificarActividades : Form
    {
        Actividad modAct;

        public FormularioModificarActividades()
        {
            InitializeComponent();
        }
        public FormularioModificarActividades(Actividad modAct)
        {
            InitializeComponent();
            this.modAct = modAct;
        }

        // abre el formulario selecionado para editarlo 
        private void FormularioModificarActividades_Load(object sender, EventArgs e)
        {

            textBoxNombreModificarActividad.Text = modAct.nombre;
            dateTimeModiciarFechaInicio.Value = modAct.fechaInicio;
            dateTimeModificarFechaFinal.Value = modAct.fechaFinal;
            listBoxCategoriasModificarActividades.SelectedItems.Clear();
            foreach (string item in modAct.categorias)
            {
                listBoxCategoriasModificarActividades.SelectedItems.Add(item);
            }
            textBoxDescripcionModificarActividades.Text = modAct.descripcion;
            listBoxLibreriasModificarActividades.SelectedItems.Clear();
            foreach (string item in modAct.librerias)
            {
                listBoxLibreriasModificarActividades.SelectedItems.Add(item);
            }
        }

        // Guarda la actividad modificada.
        private void buttonCrearModificarActividad_Click(object sender, EventArgs e)
        {

            modAct.nombre = textBoxNombreModificarActividad.Text;
            modAct.fechaInicio = dateTimeModiciarFechaInicio.Value;
            modAct.fechaFinal = dateTimeModificarFechaFinal.Value;
            modAct.categorias = new List<string>(); // inicializar las categorias
            foreach (String item in listBoxCategoriasModificarActividades.SelectedItems) // bucle per selecionar mas de una categoria
            {
                modAct.categorias.Add(item);
            }
            modAct.descripcion = textBoxDescripcionModificarActividades.Text;
            modAct.librerias = new List<string>();
            foreach (String item in listBoxLibreriasModificarActividades.SelectedItems)
            {
                modAct.librerias.Add(item);
            }

            this.Close();
        }
    }
    
}
