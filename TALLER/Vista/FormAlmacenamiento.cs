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
using TALLER.Vista;

namespace TALLER.CapaVista
{
    public partial class FormAlmacenamiento : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<Producto> listarProductos;
        public Producto producto;
        public bool ban = false;
        public FormAlmacenamiento()
        {
            InitializeComponent();
        }

        private void FormAlmacenamiento_Load(object sender, EventArgs e)
        {
            this.txtBoxCodigo.Focus();
            armarTabla();
            cargarDatos();
        }

        private void armarTabla()
        {
            tabla.Columns.Add("CANTIDAD");//0
            tabla.Columns.Add("CODIGO");//1
            tabla.Columns.Add("NOMBRE");//2
            tabla.Columns.Add("MARCA");//3
            tabla.Columns.Add("CONTENIDO");//4
            tabla.Columns.Add("PRECIO COMPRA");//5
            tabla.Columns.Add("PRECIO VENTA");//6
            tabla.Columns.Add("UBICACION");//7
            tabla.Columns.Add("DESCRIPCION");//8
            tabla.Columns.Add("ID");//9
            tabla.Columns.Add("CATEGORIA");//10
        }

        private void cargarDatos()
        {
            listarProductos = bd.listarProductos();
            tabla.Rows.Clear();
            foreach (Producto p in listarProductos)
                tabla.Rows.Add(new Object[] { p.CANTIDAD, p.CODIGO, p.NOMBRE, p.MARCA, p.CONTENIDO, p.PRECIOCOMPRA, p.PRECIOVENTA, p.UBICACION, p.DESCRIPCION, p.IDPRODUCTO, p.CATEGORIA});

            if(!ban)//Esto lo hice para que no se cargue todo cuando lo invocan desde ventas
                this.dgvAlmacenamiento.DataSource = tabla;
        }


        private void txtBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            string caja = this.txtBoxCodigo.Text.ToUpper();

            if (caja.Length > 0)
                if (Char.IsDigit(caja[0]))
                    tabla.DefaultView.RowFilter = $"CODIGO LIKE '{caja}%'";
                else
                    tabla.DefaultView.RowFilter = $"NOMBRE LIKE '{caja}%' OR MARCA LIKE '%{caja}%'";
            else
                tabla.DefaultView.RowFilter = $"NOMBRE LIKE '%'";

            if(ban)//Esto lo hice para que se cargue solo la consulta
                this.dgvAlmacenamiento.DataSource = tabla;
        }

        private void seleccionarFila(DataGridViewRow row)
        {
            int cantidad = bd.convertirEntero(row.Cells[0].Value.ToString());
            string codigo = row.Cells[1].Value.ToString();
            string nombre = row.Cells[2].Value.ToString();
            string marca = row.Cells[3].Value.ToString();
            string contenido = row.Cells[4].Value.ToString();
            decimal precioCompra = bd.convertirDecimal(row.Cells[5].Value.ToString());
            decimal precioVenta = bd.convertirDecimal(row.Cells[6].Value.ToString());
            string ubicacion = row.Cells[7].Value.ToString();
            string descripcion = row.Cells[8].Value.ToString();
            int id = bd.convertirEntero(row.Cells[9].Value.ToString());
            string categoria = row.Cells[10].Value.ToString();

            producto = new Producto(id, codigo, nombre, categoria, "", precioCompra, precioVenta, descripcion, ubicacion, cantidad, marca, contenido);

            if (ban)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                FormProducto frm = new FormProducto(producto);
                string respuesta = frm.ShowDialog().ToString();
                if (respuesta == "OK")
                {
                    MessageBox.Show("¡PRODUCTO EDITADO EXITOSAMENTE!");
                    this.txtBoxCodigo.Text = "";
                    cargarDatos();
                    this.txtBoxCodigo.Focus();
                }
            }
        }

        private void dgvAlmacenamiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvAlmacenamiento.Rows[e.RowIndex];
            seleccionarFila(row);
        }

        private void txtBoxCodigo_Enter(object sender, EventArgs e)
        {
            this.txtBoxCodigo.BackColor = Color.FromArgb(243, 195, 151);
        }

        private void txtBoxCodigo_Leave(object sender, EventArgs e)
        {
            this.txtBoxCodigo.BackColor = Color.White;
        }

        private void primeraFila()
        {
            if(dgvAlmacenamiento.Rows.Count > 0)
            {
                dgvAlmacenamiento.Rows[0].Selected = true;
                dgvAlmacenamiento.Focus();
            }
        }

        private void txtBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                primeraFila();
            }

            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;

                primeraFila();
            }
        }

        private void dgvAlmacenamiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataGridViewRow row = dgvAlmacenamiento.CurrentRow;
                seleccionarFila(row);
            }
        }
    }
}
