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
    public partial class FormGastos : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Egreso egreso;
        private Usuario usuario;
        public FormGastos(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string categoria = this.txtBoxCategoria.Text;
            decimal monto = bd.convertirDecimal(this.txtBoxMonto.Text);
            string descripcion = this.txtBoxDescripcion.Text;

            if (categoria == "" || monto <= 0)
            {
                MessageBox.Show("¡DEBE INGRESAR LOS ESPACIOS OBLIGATORIOS!");
                return;
            }

            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA INGRESAR EL GASTO?", "CANCELAR VENTA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                egreso = new Egreso(0, usuario.IDUSUARIO, usuario.NOMBRES + " " + usuario.APELLIDOS, "", categoria, monto, descripcion);
                bd.insertarEgreso(egreso);
                limpiar();
                MessageBox.Show("¡GASTO INGRESADO EXITOSAMENTE!");
                DialogResult = DialogResult.OK;
            }
        }

        private void limpiar()
        {
            this.txtBoxCategoria.Text = "";
            this.txtBoxMonto.Text = "";
            this.txtBoxDescripcion.Text = "";
        }

        private void btnListarEgresos_Click(object sender, EventArgs e)
        {
            FormMisEgresos frm = new FormMisEgresos(usuario);
            frm.ShowDialog();
        }
    }
}
