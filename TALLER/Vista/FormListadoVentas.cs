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
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormListadoVentas : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<ListaVenta> listaVentas = new List<ListaVenta>();
        Usuario usuario;
        Cliente cliente;
        public FormListadoVentas()
        {
            InitializeComponent();
        }

        private void FormListadoVentas_Load(object sender, EventArgs e)
        {
            cargarColumnas();
            cargarDatos();
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
            listaVentas = bd.listarVentasFinal();

            foreach (ListaVenta v in listaVentas)
                tabla.Rows.Add(new Object[] { v.IDVENTA, v.NOMBREUSUARIO, v.NOMBRECLIENTE, v.FECHA, v.COSTOTARJETA, v.COSTOTOTAL, v.PAGO, v.EFECTIVO, v.CAMBIO, v.ESTADO });

            this.dgvIngresos.DataSource = tabla;
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string caja = this.txtBoxBuscar.Text.ToUpper();

            if (caja.Length > 0)
                if (Char.IsDigit(caja[0]))
                    tabla.DefaultView.RowFilter = $"ID LIKE '{caja}%'";
                else
                    tabla.DefaultView.RowFilter = $"CLIENTE LIKE '{caja}%'";
            else
                tabla.DefaultView.RowFilter = $"ID LIKE '%'";

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
                    FormLoteVenta frm = new FormLoteVenta(lv, usuario);
                    string respuesta = frm.ShowDialog().ToString();
                    if (respuesta == "OK")
                    {
                        /*if (!ban)
                        {
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                            return;
                        }*/
                        cargarDatos();
                    }
                    break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
