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
    public partial class FormCliente : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Cliente cliente;

        public FormCliente(Cliente c)
        {
            InitializeComponent();
            cliente = c;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ciCliente = this.txtBoxCi.Text;
            string nombres = this.txtBoxNombres.Text.ToUpper();
            string telefono = this.txtBoxTelefono.Text;

            if (ciCliente == "" || nombres == "")
            {
                MessageBox.Show("¡DEBE LLENAR TODOS LOS ESPACIOS OBLIGATORIOS!");
                return;
            }

            cliente = new Cliente(cliente.IDCLIENTE, ciCliente, nombres, telefono);
            bd.editarCliente(cliente);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            this.txtBoxId.Text = cliente.IDCLIENTE.ToString();
            this.txtBoxCi.Text = cliente.CICLIENTE;
            this.txtBoxNombres.Text = cliente.NOMBRES;
            this.txtBoxTelefono.Text = cliente.TELEFONO;
        }
    }
}
