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
    public partial class Login : Form
    {
        BaseDatos bd = new BaseDatos();
        List<Usuario> listarUsuarios = new List<Usuario>();
        Usuario usuario;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            this.txtBoxCiUsuario.Text = "10332";
        }

        private void cargarUsuarios()
        {
            listarUsuarios = bd.listarUsuarios();
            foreach (Usuario u in listarUsuarios)
                if(u.ESTADO == "ACTIVO")
                    this.txtBoxCiUsuario.Items.Add(u.CIUSUARIO);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string ci = txtBoxCiUsuario.Text;
                string contrasena = txtBoxPassword.Text;
                usuario = bd.loginSystem(ci, contrasena);
                if (usuario != null)
                {
                    Usuario aux = bd.cajaAbierta();
                    if (aux != null)
                    {
                        if (aux.IDUSUARIO == usuario.IDUSUARIO)
                        {
                            FormMenu form = new FormMenu(usuario);
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("¡" + aux.NOMBRES + " " + aux.APELLIDOS + " DEBE CERRAR LA CAJA ANTES!");
                            return;
                        }
                    }
                    else
                    {
                        FormCaja frm = new FormCaja(usuario);
                        this.btnNuevo.Visible = false;
                        string respuesta = frm.ShowDialog().ToString();
                        if (respuesta == "OK")
                        {
                            FormMenu form = new FormMenu(usuario);
                            form.Show();
                            this.Hide();
                        }
                        this.btnNuevo.Visible = true;
                    }
                }
                else
                    MessageBox.Show("¡CONTRASEÑA INCORRECTA!");
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnNuevo_Click(sender, e);
            }
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnNuevo_Click(sender, e);
            }
        }

        private void txtBoxCiUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBoxPassword.Focus();
        }
    }
}
