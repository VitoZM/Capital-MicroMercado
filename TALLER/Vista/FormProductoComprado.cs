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

namespace TALLER.Vista
{
    public partial class FormProductoComprado : Form
    {
        private BaseDatos bd = new BaseDatos();
        private List<ListaLote> listaLote;
        private int idProducto;
        DataTable tabla = new DataTable();
        public FormProductoComprado(int id)
        {
            InitializeComponent();
            this.idProducto = id;
        }

        private void FormProductoComprado_Load(object sender, EventArgs e)
        {
            cargarColumnas();
            cargarDatos();
        }
        private void cargarColumnas()
        {
            tabla.Columns.Add("CANTIDAD");//0
            tabla.Columns.Add("CODIGO");//1
            tabla.Columns.Add("PRODUCTO");//2
            tabla.Columns.Add("FECHA");//3
        }

        private void cargarDatos()
        {
            listaLote = bd.listarProductoComprado(idProducto);

            foreach (ListaLote l in listaLote)
                tabla.Rows.Add(new Object[] { l.CANTIDAD, l.CODIGO, l.PRODUCTO, l.EXPIRACION });

            this.dgvAlmacenamiento.Rows.Clear();
            this.dgvAlmacenamiento.DataSource = tabla;
        }
    }
}
