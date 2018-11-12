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
    public partial class FormUsuarios : Form
    {
        string jsonName = @"..\..\\datos_usuarios.json";
        List<Usuario> usuarios = new List<Usuario>();

        public FormUsuarios()
        {
            InitializeComponent();
        }
        //Load: Si el archivo JSON está en la ruta, pasa su contenido a la lista "usuarios" y la lista a la dataGridView. Si no crea una lista vacía de usuarios.
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            if (File.Exists(jsonName))
            {
                MessageBox.Show("JSON Existe", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(jsonName));
                usuarios = jArrayUsuarios.ToObject<List<Usuario>>();
            }
            else
            {
                List<Usuario> usuarios = new List<Usuario>();
                MessageBox.Show("JSON NO Existe", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewUsuarios.DataSource = usuarios;
        }
        //Cuando se presiona la imágen de Eliminar elimina de la lista de usuarios las filas seleccionadas en el dataGridView.
        private void buttonBorrarUsuarios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewUsuarios.SelectedRows)
            {
                Usuario u = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;
                usuarios.Remove(u);
            }

            JArray jArrayUsuarios = (JArray)JToken.FromObject(usuarios);

            StreamWriter fichero = File.CreateText(@"..\..\datos_usuarios.json");
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);

            jArrayUsuarios.WriteTo(jsonWriter);

            jsonWriter.Close();


            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = usuarios;
        }
        
        //Si hay una fila seleccionada en la 'dataGridViewUsuarios' y se pulsa el 'buttonEditarUsuario' pasa el objecto y abre el 'FormEditarUsuario'.
        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            
            if(dataGridViewUsuarios.SelectedRows.Count == 1)
            { 
                Usuario usuario = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                FormEditarUsuario formularioEditarUsuario = new FormEditarUsuario(usuario);
                formularioEditarUsuario.ShowDialog();
                dataGridViewUsuarios.DataSource = null;
                dataGridViewUsuarios.DataSource = usuarios;
                //Se puede poner en el evento closing
                JArray jArrayUsuarios = (JArray)JToken.FromObject(usuarios);

                StreamWriter fichero = File.CreateText(@"..\..\datos_usuarios.json");
                JsonTextWriter jsonWriter = new JsonTextWriter(fichero);

                jArrayUsuarios.WriteTo(jsonWriter);

                jsonWriter.Close();
            }
        }

        
    }

}
