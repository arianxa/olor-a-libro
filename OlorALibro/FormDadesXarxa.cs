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
    public partial class FormDadesXarxa : Form
    {
        string jsonName = @"..\..\\datos_red.json";
        DatosRed red = new DatosRed();

        public FormDadesXarxa()
        {
            InitializeComponent();
        }

        //Load: si el archivo JSON existe lo lee y pasa el objeto al textBoxDescripcionRed
        // si no existe manda un mensaje avisando.
        private void FormDadesXarxa_Load(object sender, EventArgs e)
        {

            if (File.Exists(jsonName))
            {
                MessageBox.Show("JSON Existe", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JObject jArrayPelis = JObject.Parse(File.ReadAllText(jsonName));
                red = jArrayPelis.ToObject<DatosRed>();
                textBoxDescripcionRed.Text = red.descripcion;

            }
            else
            {
                MessageBox.Show("JSON NO Existe", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //Pasa el contenido del textBoxDescripcionRed a un objecto y ese objeto al archivo JSON.
        private void buttonPasarAJSON_Click(object sender, EventArgs e)
        {
            
            red.descripcion = textBoxDescripcionRed.Text;
            JObject jObjectDescripcion = (JObject)JToken.FromObject(red);
            StreamWriter fichero = File.CreateText(jsonName);
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);

            jObjectDescripcion.WriteTo(jsonWriter);

            jsonWriter.Close();
        }
    }
}
