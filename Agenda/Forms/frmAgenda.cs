using Agenda.Clases;
using Newtonsoft.Json;
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

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        public string rutaJson = Path.Combine("Recursos", "agenda.json");

        public frmAgenda()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            try
            {
                string json = File.ReadAllText(rutaJson);
                var registros = JsonConvert.DeserializeObject<datosJson>(json);
                cargarJson(registros);
                string info = "Registros: " + registros.totalRegistros + "    Ultima actualizacion: " + registros.ultimaActualizacion;
                tsslRegistros.Text = info;
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarJson(datosJson lista)
        {
            var registrosJson = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(lista, registrosJson);
            File.WriteAllText(rutaJson, json);
        }

        private datosJson cargarDatos()
        {
            var registros = new datosJson();
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? "";
                    persona.apPaterno = fila.Cells[1].Value?.ToString() ?? "";
                    persona.apMaterno = fila.Cells[2].Value?.ToString() ?? "";
                    persona.direccion = fila.Cells[3].Value?.ToString() ?? "";
                    persona.telefono = fila.Cells[4].Value?.ToString() ?? "";
                    persona.correo = fila.Cells[5].Value?.ToString() ?? "";
                }
                registros.datos.Add(persona);
            }
            registros.totalRegistros = registros.datos.Count;
            return registros;
        }

        private void cargarJson(datosJson registros)
        {
            dgvDatos.Rows.Clear();
            foreach (var persona in registros.datos)
            {
                dgvDatos.Rows.Add(new object[] { persona.nombre, persona.apPaterno, persona.apMaterno, persona.direccion, persona.telefono, persona.correo });
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var baseDatos = cargarDatos();
                if (svfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    guardarJson(baseDatos);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(ofdAbrir.FileName);
                    var registros = JsonConvert.DeserializeObject<datosJson>(json);
                    cargarJson(registros);
                    string info = "Registros: " + registros.totalRegistros + "    Ultima actualizacion: " + registros.ultimaActualizacion;
                    tsslRegistros.Text = info;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error "+ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            try
            {
                var baseDatos = cargarDatos();
                guardarJson(baseDatos);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar datos. " + ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrSave_Tick(object sender, EventArgs e)
        {
            try
            {
                var baseDatos = cargarDatos();
                guardarJson(baseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
