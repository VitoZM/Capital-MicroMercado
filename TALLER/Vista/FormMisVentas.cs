using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.ClasesVista;
using TALLER.Controlador;
using TALLER.Vista;
using TALLER.Modelo;

namespace TALLER.CapaVista
{
    public partial class FormMisVentas : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<ListaVenta> listaVentas = new List<ListaVenta>();
        Usuario usuario;
        Cliente cliente;
        bool ban = false;

        public FormMisVentas(Usuario u)
        {
            InitializeComponent();
            usuario = u;
            ban = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormMisVentas(Usuario u,Cliente c)
        {
            InitializeComponent();
            usuario = u;
            cliente = c;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormReparacion_Load(object sender, EventArgs e)
        { 
            cargarColumnas();
            cargarDatos();
            if (this.dgvIngresos.Rows.Count > 0)
                calcularTotal();
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvIngresos.Rows)
                if (row.Cells[8].Value.ToString() == "VENDIDO")
                    total += bd.convertirDecimal(row.Cells[4].Value.ToString());
            this.txtBoxTotalVendido.Text = total.ToString();
        }

        private void cargarColumnas()
        {
            tabla.Columns.Add("ID");//0
            tabla.Columns.Add("VENDEDOR");//1
            tabla.Columns.Add("CLIENTE");//2
            tabla.Columns.Add("FECHA");//3
            tabla.Columns.Add("COSTO T");//4
            tabla.Columns.Add("PAGO");//5
            tabla.Columns.Add("EFECTIVO");//6
            tabla.Columns.Add("CAMBIO");//7
            tabla.Columns.Add("ESTADO");//8
        }

        private void cargarDatos()
        {
            if (ban)
                listaVentas = bd.listarVentas(usuario);
            else
                listaVentas = bd.listarDeudasCliente(cliente);

            foreach (ListaVenta v in listaVentas)
                tabla.Rows.Add(new Object[] { v.IDVENTA, v.NOMBREUSUARIO, v.NOMBRECLIENTE, v.FECHA, v.COSTOTOTAL, v.PAGO, v.EFECTIVO, v.CAMBIO, v.ESTADO });

            this.dgvIngresos.Rows.Clear();
            this.dgvIngresos.DataSource = tabla;
        }

        private void dgvIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvIngresos.Rows[e.RowIndex];
            int idVenta = bd.convertirEntero(row.Cells[0].Value.ToString());

            for (int i = 0; i < listaVentas.Count; i++)
            {
                ListaVenta lv = listaVentas[i];
                if (lv.IDVENTA == idVenta)
                {
                    FormLoteVenta frm = new FormLoteVenta(lv);
                    string respuesta = frm.ShowDialog().ToString();
                    if (respuesta == "OK")
                    {
                        if (!ban)
                        {
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                            return;
                        }
                        MessageBox.Show("PRESIONE BOTON INGRESOS NUEVAMENTE PARA ACTUALIZAR");
                    }
                    break;
                }
            }
        }
    }
}
