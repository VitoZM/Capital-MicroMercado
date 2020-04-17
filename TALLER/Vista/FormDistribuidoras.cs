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
    public partial class FormDistribuidoras : Form
    {
        private BaseDatos bd = new BaseDatos();
        private DataTable tabla = new DataTable();
        private List<Distribuidora> listarDistribuidoras;
        public Distribuidora distribuidora;
        public bool ban = false;
        public FormDistribuidoras()
        {
            InitializeComponent();
        }

        private void FormDistribuidoras_Load(object sender, EventArgs e)
        {
            this.txtBoxBuscarNombre.Focus();
            this.StartPosition = FormStartPosition.CenterScreen;
            armarTabla();
            cargarDatos();
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

        private void armarTabla()
        {
            tabla.Columns.Add("ID");//0
            tabla.Columns.Add("NOMBRE");//1
            tabla.Columns.Add("DIRECCION");//2
            tabla.Columns.Add("TELEFONO");//3
            tabla.Columns.Add("CATEGORIA");//4
        }

        private void cargarDatos()
        {
            listarDistribuidoras = bd.listarDistribuidoras();
            tabla.Rows.Clear();
            foreach (Distribuidora d in listarDistribuidoras)
                tabla.Rows.Add(new Object[] { d.IDDISTRIBUIDORA, d.NOMBRE, d.DIRECCION, d.TELEFONO, d.CATEGORIA });

            this.dgvDistribuidoras.DataSource = tabla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtBoxNombreDistribuidora.Text.ToUpper();
            string direccion = this.txtBoxDireccion.Text.ToUpper();
            string telefono = this.txtBoxTelefono.Text;
            string categoria = this.txtBoxCategoria.Text.ToUpper();

            if(nombre == "" || telefono == "")
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS ESPACIOS OBLIGADOS");
                return;
            }

            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA INSERTAR DISTRIBUIDORA?", "INSERTAR DISTRIBUIDORA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                distribuidora = new Distribuidora(-1, nombre, direccion, telefono, categoria);
                bd.insertarDistribuidora(distribuidora);
                cargarDatos();
                limpiar();
                MessageBox.Show("DISTRIBUIDORA INSERTADA EXITOSAMENTE");
            }

        }

        private void limpiar()
        {
            this.txtBoxNombreDistribuidora.Text = "";
            this.txtBoxDireccion.Text = "";
            this.txtBoxCategoria.Text = "";
            this.txtBoxTelefono.Text = "";
        }

        private void dgvAlmacenamiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvDistribuidoras.Rows[e.RowIndex];

            int idDistribuidora = bd.convertirEntero(row.Cells[0].Value.ToString());
            string nombre = row.Cells[1].Value.ToString();
            string direccion = row.Cells[2].Value.ToString();
            string telefono = row.Cells[3].Value.ToString();
            string categoria = row.Cells[4].Value.ToString();

            distribuidora = new Distribuidora(idDistribuidora, nombre, direccion, telefono, categoria);

            if (ban)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                FormDistribuidora frm = new FormDistribuidora(distribuidora);
                string respuesta = frm.ShowDialog().ToString();
                if (respuesta == "OK")
                {
                    MessageBox.Show("¡DISTRIBUIDORA EDITADO EXITOSAMENTE!");
                    this.txtBoxBuscarNombre.Text = "";
                    cargarDatos();
                    this.txtBoxBuscarNombre.Focus();
                }
            }
        }

        private void txtBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            string caja = this.txtBoxBuscarNombre.Text.ToUpper();

            if (caja.Length > 0)
                tabla.DefaultView.RowFilter = $"NOMBRE LIKE'%{caja}%'";
            else
                tabla.DefaultView.RowFilter = $"NOMBRE LIKE '%'";
        }
    }
}
