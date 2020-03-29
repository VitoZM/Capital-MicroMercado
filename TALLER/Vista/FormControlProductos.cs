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
    public partial class FormControlProductos : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<ControlP> listarControlP;
        public ControlP controlP;
        public bool ban = false;
        public FormControlProductos()
        {
            InitializeComponent();
        }

        private void FormControlProductos_Load(object sender, EventArgs e)
        {
            this.txtBoxCodigo.Focus();
            armarTabla();
            cargarDatos();
        }

        private void armarTabla()
        {
            tabla.Columns.Add("IDLOTE");//0
            tabla.Columns.Add("CODIGO");//1
            tabla.Columns.Add("PRODUCTO");//2
            tabla.Columns.Add("CANTIDAD");//3
            tabla.Columns.Add("EXPIRACION");//4
        }

        private void cargarDatos()
        {
            listarControlP = bd.listarControles();
            tabla.Rows.Clear();
            foreach (ControlP cp in listarControlP)
                tabla.Rows.Add(new Object[] { cp.IDLOTE, cp.CODIGO, cp.PRODUCTO, cp.CANTIDAD, cp.EXPIRACION });

            this.dgvControlProductos.DataSource = tabla;
        }
    }
}
