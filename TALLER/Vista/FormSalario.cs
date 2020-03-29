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
    public partial class FormSalario : Form
    {
        BaseDatos bd = new BaseDatos();
        List<Usuario> listarUsuarios = new List<Usuario>();
        Usuario usuario;
        public FormSalario()
        {
            InitializeComponent();
        }

        private void FormSalario_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            listarUsuarios = bd.listarUsuarios();
            foreach (Usuario u in listarUsuarios)
                if (u.ESTADO == "ACTIVO")
                    this.txtBoxCiUsuario.Items.Add(u.CIUSUARIO);
        }

        private void txtBoxCiUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ci = this.txtBoxCiUsuario.Text;
            usuario = obtenerUsuario(ci);
            this.txtBoxVendedor.Text = usuario.NOMBRES + " " + usuario.APELLIDOS;
            this.txtBoxSueldo.Text = usuario.SUELDO.ToString();
            calcularLiquido();
        }

        private void calcularLiquido()
        {
            decimal sueldo = bd.convertirDecimal(this.txtBoxSueldo.Text);
            decimal descuento = bd.convertirDecimal(this.txtBoxDescuento.Text);
            this.txtBoxLiquido.Text = (sueldo - descuento).ToString();
        }

        private Usuario obtenerUsuario(string ci)
        {
            foreach (Usuario u in listarUsuarios)
                if (u.CIUSUARIO == ci)
                    return u;
            return null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bd.insertarDesdeTexto();
            MessageBox.Show("aunq no lo creas funciono");
        }

        private void txtBoxDescuento_TextChanged(object sender, EventArgs e)
        {
            calcularLiquido();
        }
    }
}
