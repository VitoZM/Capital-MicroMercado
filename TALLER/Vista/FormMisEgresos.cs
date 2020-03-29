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
    public partial class FormMisEgresos : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<Egreso> listarEgresos;
        private Egreso egreso;
        private Usuario usuario;
        public FormMisEgresos(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void FormMisEgresos_Load(object sender, EventArgs e)
        {
            armarTabla();
            cargarDatos();
            if(this.dgvEgresos.Rows.Count > 0)
                calcularTotal();
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvEgresos.Rows)
                total += bd.convertirDecimal(row.Cells[4].Value.ToString());
            this.txtBoxTotalEgresos.Text = total.ToString();
        }

        private void armarTabla()
        {
            tabla.Columns.Add("ID");//0
            tabla.Columns.Add("USUARIO");//1
            tabla.Columns.Add("FECHA");//2
            tabla.Columns.Add("CATEGORIA");//3
            tabla.Columns.Add("MONTO");//4
            tabla.Columns.Add("DESCRIPCION");//5
        }

        private void cargarDatos()
        {
            listarEgresos = bd.listarEgresos(usuario.IDUSUARIO);
            tabla.Rows.Clear();
            foreach (Egreso e in listarEgresos)
                tabla.Rows.Add(new Object[] { e.IDEGRESO, e.NOMBREUSUARIO, e.FECHA, e.CATEGORIA, e.MONTO, e.DESCRIPCION });

            this.dgvEgresos.DataSource = tabla;
        }
    }
}
