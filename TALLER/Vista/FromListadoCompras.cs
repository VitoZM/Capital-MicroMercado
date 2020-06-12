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
    public partial class FromListadoCompras : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Compra compra;
        private List<ListaCompra> listaCompras = new List<ListaCompra>();
        DataTable tabla = new DataTable();
        private Usuario usuario;
        private bool ban = true;
        public FromListadoCompras(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void FromListadoCompras_Load(object sender, EventArgs e)
        {
            cargarColumnas();
            cargarDatos();
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
            listaCompras = bd.listarComprasFinal();

            foreach (ListaCompra c in listaCompras)
                tabla.Rows.Add(new Object[] { c.IDCOMPRA, c.NOMBREUSUARIO, c.NOMBREDISTRIBUIDORA, c.FECHA, c.COSTOTOTAL, c.DESCUENTO, c.COSTOFINAL/*, c.DESCRIPCION*/ });

            this.dgvCompras.Rows.Clear();
            this.dgvCompras.DataSource = tabla;
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string caja = this.txtBoxBuscar.Text.ToUpper();

            if (caja.Length > 0)
                if (Char.IsDigit(caja[0]))
                    tabla.DefaultView.RowFilter = $"ID LIKE '{caja}%'";
                else
                    tabla.DefaultView.RowFilter = $"DISTRIBUIDORA LIKE '{caja}%'";
            else
                tabla.DefaultView.RowFilter = $"ID LIKE '%'";

            this.dgvCompras.DataSource = tabla;
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
