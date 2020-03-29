using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormClientes : Form
    {
        private BaseDatos bd = new BaseDatos();
        private List<Cliente> listaClientes;
        private DataTable tabla = new DataTable();
        public Cliente cliente;
        public bool ban = false;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            armarTabla();
            cargarDatos();
        }

        private void armarTabla()
        {
            tabla.Columns.Add("N");
            tabla.Columns.Add("CI_O_NIT");
            tabla.Columns.Add("NOMBRES");
            tabla.Columns.Add("TELEFONO");
            tabla.Columns.Add("ID");
        }

        private void cargarDatos()
        {
            listaClientes = bd.listarClientes();
            tabla.Rows.Clear();
            int n = 0;
            foreach (Cliente c in listaClientes)
            {
                n++;
                tabla.Rows.Add(new Object[] { n, c.CICLIENTE, c.NOMBRES, c.TELEFONO, c.IDCLIENTE });
            }

            this.dgvClientes.DataSource = tabla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ciCliente = this.txtBoxCi.Text;
            string nombres = this.txtBoxNombres.Text.ToUpper();
            string telefono = this.txtBoxTelefono.Text;

            if (ciCliente == "" || nombres == "")
            {
                MessageBox.Show("¡DEBE LLENAR TODOS LOS ESPACIOS OBLIGATORIOS!");
                return;
            }

            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA GUARDAR NUEVO CLIENTE?", "CLIENTE NUEVO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cliente = new Cliente(-1, ciCliente, nombres, telefono);
                bd.insertarCliente(cliente);
                cargarDatos();
                limpiar();
                MessageBox.Show("¡CLIENTE INGRESADO EXITOSAMENTE!");
            }
        }

        private void limpiar()
        {
            this.txtBoxCi.Text = "";
            this.txtBoxNombres.Text = "";
            this.txtBoxTelefono.Text = "";
        }

        private void txtBoxBuscarCi_TextChanged(object sender, EventArgs e)
        {
            string caja = this.txtBoxBuscarCi.Text.ToUpper();

            if (caja.Length > 0)
                if (Char.IsDigit(caja[0]))
                    tabla.DefaultView.RowFilter = $"CI_O_NIT LIKE '{caja}%'";
                else
                    tabla.DefaultView.RowFilter = $"NOMBRES LIKE '%{caja}%'";
            else
                tabla.DefaultView.RowFilter = $"NOMBRES LIKE '%'";
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

            string ciCliente = row.Cells[1].Value.ToString();
            string nombres = row.Cells[2].Value.ToString();
            string telefono = row.Cells[3].Value.ToString();
            int idCliente = bd.convertirEntero(row.Cells[4].Value.ToString());

            cliente = new Cliente(idCliente, ciCliente, nombres, telefono);

            if (ban)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                FormCliente frm = new FormCliente(cliente);
                string respuesta = frm.ShowDialog().ToString();
                if (respuesta == "OK")
                {
                    MessageBox.Show("¡CLIENTE EDITADO EXITOSAMENTE!");
                    this.txtBoxBuscarCi.Text = "";
                    cargarDatos();
                    this.txtBoxBuscarCi.Focus();
                }
            }
        }
    }
}
