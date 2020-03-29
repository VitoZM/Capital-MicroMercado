using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormInversion : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Usuario usuario;
        private Inversion inversion;
        public FormInversion(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ciInversor = this.txtBoxCiInversor.Text;
            string nombreInversor = this.txtBoxInversor.Text;
            decimal monto = bd.convertirDecimal(this.txtBoxMonto.Text);
            string descripcion = this.txtBoxDescripcion.Text;

            if(monto <= 0)
            {
                MessageBox.Show("INGRESE MONTO VALIDO");
                return;
            }

            inversion = new Inversion(0, ciInversor, nombreInversor, usuario.IDUSUARIO, monto, "", descripcion);
            bd.insertarInversion(inversion);
            limpiar();
            MessageBox.Show("¡INVERSION INGRESADA EXITOSAMENTE!");
        }

        private void limpiar()
        {
            this.txtBoxMonto.Text = "0";
            this.txtBoxDescripcion.Text = "";
        }

        private void FormInversion_Load(object sender, EventArgs e)
        {
            cargarInversores();
        }

        private void cargarInversores()
        {
            string fichero = Directory.GetCurrentDirectory() + "\\inversores.txt";
            string archivo = String.Empty;
            if (File.Exists(fichero))
            {
                archivo = File.ReadAllText(fichero);
                string[] lineas = archivo.Split('\n');
                foreach (string linea in lineas)
                    this.txtBoxCiInversor.Text = linea.Split(',')[0];
            }
        }
    }
}
