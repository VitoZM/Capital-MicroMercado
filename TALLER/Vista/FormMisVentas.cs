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
        }

        public FormMisVentas(Usuario u,Cliente c)
        {
            InitializeComponent();
            usuario = u;
            cliente = c;
            cargarDeuda();
        }

        private void cargarDeuda()
        {
            this.lblTitulo.Text = "CREDITOS";
            this.lblDeudaTotal.Visible = true;
            this.btnPagarDeudaTotal.Visible = true;
            this.txtBoxDeudaTotal.Visible = true;
            this.txtBoxTotalVendido.Visible = false;            
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
            tabla.Columns.Add("TARJETAS");//4
            tabla.Columns.Add("TOTAL");//5
            tabla.Columns.Add("PAGO");//6
            tabla.Columns.Add("EFECTIVO");//7
            tabla.Columns.Add("CAMBIO");//8
            tabla.Columns.Add("ESTADO");//9
        }

        private void cargarDatos()
        {
            tabla.Rows.Clear();
            if (ban)
                listaVentas = bd.listarVentas(usuario);
            else
                listaVentas = bd.listarDeudasCliente(cliente);

            foreach (ListaVenta v in listaVentas)
                tabla.Rows.Add(new Object[] { v.IDVENTA, v.NOMBREUSUARIO, v.NOMBRECLIENTE, v.FECHA, v.COSTOTARJETA,v.COSTOTOTAL, v.PAGO, v.EFECTIVO, v.CAMBIO, v.ESTADO });

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
                    FormLoteVenta frm = new FormLoteVenta(lv,usuario);
                    string respuesta = frm.ShowDialog().ToString();
                    if (respuesta == "OK")
                    {
                        if (!ban)
                        {
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                            return;
                        }
                        cargarDatos();
                    }
                    break;
                }
            }
        }

        private void btnPagarDeudaTotal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA PAGAR EL TOTAL DE LA DEUDA?", "PAGAR DEUDA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dgvIngresos.Rows)
                    if (row.Cells[9].Value.ToString() == "VENDIDO")
                        bd.pagarCredito(bd.convertirEntero(row.Cells[0].Value.ToString()), usuario.IDUSUARIO);
                MessageBox.Show("¡VENTA PAGADA EXITOSAMENTE!");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
