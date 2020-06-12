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
    public partial class FormMisCompras : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Compra compra;
        private List<ListaCompra> listaCompras = new List<ListaCompra>();
        DataTable tabla = new DataTable();
        private Usuario usuario;
        private bool ban = true;
        public FormMisCompras(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        public FormMisCompras(Usuario u, bool b)
        {
            InitializeComponent();
            usuario = u;
            ban = b;
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            cargarColumnas();
            cargarDatos();
            if (this.dgvCompras.Rows.Count > 0)
                calcularTotal();
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCompras.Rows)
                total += bd.convertirDecimal(row.Cells[4].Value.ToString());
            this.txtBoxTotalCompras.Text = total.ToString();
        }

        private void cargarColumnas()
        {
            tabla.Columns.Add("ID");//0
            tabla.Columns.Add("VENDEDOR");//1
            tabla.Columns.Add("DISTRIBUIDORA");//2
            tabla.Columns.Add("FECHA");//3
            tabla.Columns.Add("COSTO T");//4
            tabla.Columns.Add("DESCUENTO");//5
            tabla.Columns.Add("COSTO F");//6
            //tabla.Columns.Add("DESCRIPCION");//7
        }


        private void cargarDatos()
        {
            if (ban)
                listaCompras = bd.listarCompras(usuario);
            else
                listaCompras = bd.listarComprasTarjetas();

            foreach (ListaCompra c in listaCompras)
                tabla.Rows.Add(new Object[] { c.IDCOMPRA, c.NOMBREUSUARIO, c.NOMBREDISTRIBUIDORA, c.FECHA, c.COSTOTOTAL, c.DESCUENTO, c.COSTOFINAL/*, c.DESCRIPCION*/ });

            this.dgvCompras.Rows.Clear();
            this.dgvCompras.DataSource = tabla;
        }

        private void dgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvCompras.Rows[e.RowIndex];
            int idCompra = bd.convertirEntero(row.Cells[0].Value.ToString());

            for (int i = 0; i < listaCompras.Count; i++)
            {
                ListaCompra lc = listaCompras[i];
                if (lc.IDCOMPRA == idCompra)
                {
                    FormLote frm = new FormLote(lc);
                    /*string respuesta = */
                    frm.ShowDialog().ToString();
                    /*if (respuesta == "OK")
                        MessageBox.Show("PRESIONE BOTON INGRESOS NUEVAMENTE PARA ACTUALIZAR");*/
                    break;
                }
            }
        }
    }
}
