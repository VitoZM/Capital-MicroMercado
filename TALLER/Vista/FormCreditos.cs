using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.CapaVista;
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormCreditos : Form
    {
        private BaseDatos bd = new BaseDatos();
        private List<Cliente> listaClientes;
        private DataTable tabla = new DataTable();
        public Cliente cliente;
        private Usuario usuario;
        public FormCreditos(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void FormCreditos_Load(object sender, EventArgs e)
        {
            armarTabla();
            cargarDatos();
        }

        private void armarTabla()
        {
            tabla.Columns.Add("N°");
            tabla.Columns.Add("CI_O_NIT");
            tabla.Columns.Add("NOMBRES");
            tabla.Columns.Add("DEUDA");
        }

        private void cargarDatos()
        {
            listaClientes = bd.listarClientesDeudas();
            tabla.Rows.Clear();
            int n = 0;
            foreach (Cliente c in listaClientes)
            {
                n++;
                tabla.Rows.Add(new Object[] { n, c.CICLIENTE, c.NOMBRES, c.TELEFONO });
            }

            this.dgvClientes.DataSource = tabla;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
            string ci = row.Cells[1].Value.ToString();

            for (int i = 0; i < listaClientes.Count; i++)
            {
                Cliente c = listaClientes[i];
                if (c.CICLIENTE == ci)
                {
                    FormMisVentas frm = new FormMisVentas(usuario,c);
                    string respuesta = frm.ShowDialog().ToString();
                    if (respuesta == "OK")
                        cargarDatos();
                    break;
                }
            }
        }
    }
}
