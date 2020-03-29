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
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormDistribuidora : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Distribuidora distribuidora;
        public FormDistribuidora(Distribuidora d)
        {
            InitializeComponent();
            distribuidora = d;
        }

        private void FormDistribuidora_Load(object sender, EventArgs e)
        {
            cargarDistribuidora();
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            string fichero = Directory.GetCurrentDirectory() + "\\categorias.txt";
            string archivo = String.Empty;
            if (File.Exists(fichero))
            {
                archivo = File.ReadAllText(fichero);
                string[] lineas = archivo.Split('\n');
                foreach (string linea in lineas)
                    this.txtBoxCategoria.Items.Add(linea);
            }

        }
        private void cargarDistribuidora()
        {
            this.txtBoxId.Text = distribuidora.IDDISTRIBUIDORA.ToString();
            this.txtBoxTelefono.Text = distribuidora.TELEFONO;
            this.txtBoxDireccion.Text = distribuidora.DIRECCION;
            this.txtBoxCategoria.Text = distribuidora.CATEGORIA;
            this.txtBoxNombreDistribuidora.Text = distribuidora.NOMBRE;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtBoxNombreDistribuidora.Text.ToUpper();
            string direccion = this.txtBoxDireccion.Text.ToUpper();
            string telefono = this.txtBoxTelefono.Text;
            string categoria = this.txtBoxCategoria.Text.ToUpper();

            if (nombre == "" || telefono == "")
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS ESPACIOS OBLIGADOS");
                return;
            }

            distribuidora = new Distribuidora(distribuidora.IDDISTRIBUIDORA, nombre, direccion, telefono, categoria);
            bd.editarDistribuidora(distribuidora);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
