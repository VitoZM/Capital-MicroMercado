using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TALLER.Modelo;
using TALLER.Vista;
using TALLER.Controlador;

namespace TALLER.CapaVista
{
    public partial class FormMenu : Form
    {
        private bool ban = false;
        private bool banEgresos = false;
        private bool banIngresos = false;
        private bool banCuentas = false;
        private bool banProductos = false;
        private bool banRecursos = false;
        private bool banConsultas = false;
        private Usuario usuario;
        private BaseDatos bd = new BaseDatos();

        public FormMenu(Usuario u)
        {
            InitializeComponent();
            this.usuario = u;
            string[] nombres = usuario.NOMBRES.Split(' ');
            string[] apellidos = usuario.APELLIDOS.Split(' ');
            this.lblusuario.Text = nombres[0] + " " + apellidos[0];
            this.lblCi.Text = usuario.CIUSUARIO;
        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("mensaje,seguro de cerrar?", "titutlo,alerta¡¡¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }*/
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ban)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            else
                ban = false;
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        int LX, LY, SW, SH;
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
            ban = true;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 57)
                MenuVertical.Width = 250;
            else
                MenuVertical.Width = 57;
        }

        private void btnPRODUCTOS_Click(object sender, EventArgs e)
        {
            
        }

        public void btnINICIO_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new FormLogo());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            mostrarlogo();
            bd.backUp();
            this.pnlIngresos.Location = new Point(25, 123);
            this.pnlEgresos.Location = new Point(25, 175);
        }

        private void mostrarlogo()
        {

        }

        private void btnREPORTES_Click(object sender, EventArgs e)
        {
            FormAlmacenamiento frm = new FormAlmacenamiento();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnCLIENTES_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();
            btnRecursos_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void iconCerrar_MouseEnter(object sender, EventArgs e)
        {
            this.iconCerrar.BackColor = System.Drawing.Color.Red;
        }

        private void iconCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.iconCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
        }

        private void iconMinimizar_MouseEnter(object sender, EventArgs e)
        {
            this.iconMinimizar.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void iconMinimizar_MouseLeave(object sender, EventArgs e)
        {
            this.iconMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
        }

        private void iconrestaurar_MouseEnter(object sender, EventArgs e)
        {
            this.iconrestaurar.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void iconrestaurar_MouseLeave(object sender, EventArgs e)
        {
            this.iconrestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
        }

        private void iconmaximizar_MouseEnter(object sender, EventArgs e)
        {
            this.iconmaximizar.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void iconmaximizar_MouseLeave(object sender, EventArgs e)
        {
            this.iconmaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
        }


        private void FormMenu_LocationChanged(object sender, EventArgs e)
        {
            if (ban)
            {
                MessageBox.Show("SDAF");
                iconrestaurar_Click(sender, e);
            }
        }

        private void btnServiciosPendientes_Click(object sender, EventArgs e)
        {
            FormPedido frm = new FormPedido(usuario);
            btnEgresos_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }


        private void btnEMPLEADOS_Click(object sender, EventArgs e)
        {
        }


        private void btnLuminarias_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            int yDesplazamiento = 180;

            if (!banEgresos)
            {
                cambiarControl(pnlEgresos, ref banEgresos);
                desplazarControles(btnCuentas, pnlCuentas, yDesplazamiento);
                desplazarControles(btnProductos, pnlProductos, yDesplazamiento);
                desplazarControles(btnRecursos, pnlRecursos, yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y + yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, yDesplazamiento);
            }
            else
            {
                cambiarControl(pnlEgresos, ref banEgresos);
                desplazarControles(btnCuentas, pnlCuentas, -yDesplazamiento);
                desplazarControles(btnProductos, pnlProductos, -yDesplazamiento);
                desplazarControles(btnRecursos, pnlRecursos, -yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y - yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, -yDesplazamiento);
            }
        }

        private void btnArqueos_Click(object sender, EventArgs e)
        {
            FormArqueo frm = new FormArqueo(usuario);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd.ojala();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            FormGastos frm = new FormGastos(usuario);
            btnEgresos_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnIngresos_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cambiarControl(Panel pnlActual, ref bool bn)
        {
            pnlActual.Visible = !bn;
            bn = !bn;
        }

        private void desplazarControles(Button btn, Panel pnl, int yDesplazamiento)
        {
            btn.Location = new Point(btn.Location.X, btn.Location.Y + yDesplazamiento);
            pnl.Location = new Point(pnl.Location.X, pnl.Location.Y + yDesplazamiento);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            int yDesplazamiento = 120;

            if (!banCuentas)
            {
                cambiarControl(pnlCuentas, ref banCuentas);
                desplazarControles(btnProductos, pnlProductos, yDesplazamiento);
                desplazarControles(btnRecursos, pnlRecursos, yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y + yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, yDesplazamiento);
            }
            else
            {
                cambiarControl(pnlCuentas, ref banCuentas);
                desplazarControles(btnProductos, pnlProductos, -yDesplazamiento);
                desplazarControles(btnRecursos, pnlRecursos, -yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y - yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, -yDesplazamiento);
            }
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            FormCreditos frm = new FormCreditos(usuario);
            btnCuentas_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas(usuario);
            btnIngresos_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            int yDesplazamiento = 120;

            if (!banIngresos)
            {
                cambiarControl(pnlIngresos, ref banIngresos);
                desplazarControles(btnEgresos, pnlEgresos, yDesplazamiento);
                desplazarControles(btnCuentas, pnlCuentas, yDesplazamiento);
                desplazarControles(btnProductos, pnlProductos, yDesplazamiento);
                desplazarControles(btnRecursos, pnlRecursos, yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y + yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, yDesplazamiento);
            }
            else
            {
                cambiarControl(pnlIngresos, ref banIngresos);
                desplazarControles(btnEgresos, pnlEgresos, -yDesplazamiento);
                desplazarControles(btnCuentas, pnlCuentas, -yDesplazamiento);
                desplazarControles(btnProductos, pnlProductos, -yDesplazamiento);
                desplazarControles(btnRecursos, pnlRecursos, -yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y - yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, -yDesplazamiento);
            }
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            int yDesplazamiento = 120;

            if (!banProductos)
            {
                cambiarControl(pnlProductos, ref banProductos);
                desplazarControles(btnRecursos, pnlRecursos, yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y + yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, yDesplazamiento);
            }
            else
            {
                cambiarControl(pnlProductos, ref banProductos);
                desplazarControles(btnRecursos, pnlRecursos, -yDesplazamiento);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y - yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, -yDesplazamiento);
            }
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            int yDesplazamiento = 180;

            if (!banRecursos)
            {
                cambiarControl(pnlRecursos, ref banRecursos);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y + yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, yDesplazamiento);
            }
            else
            {
                cambiarControl(pnlRecursos, ref banRecursos);
                btnArqueos.Location = new Point(btnArqueos.Location.X, btnArqueos.Location.Y - yDesplazamiento);
                desplazarControles(btnConsultas, pnlConsultas, -yDesplazamiento);
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if (!banRecursos)
                cambiarControl(pnlConsultas, ref banConsultas);
            else
                cambiarControl(pnlConsultas, ref banConsultas);
        }

        private void btnDistribuidoras_Click(object sender, EventArgs e)
        {
            FormDistribuidoras frm = new FormDistribuidoras();
            btnRecursos_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            FormAlmacenamiento frm = new FormAlmacenamiento();
            btnProductos_Click_1(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            if (usuario.ROL == "ADMINISTRADOR")
            {
                FormSalario frm = new FormSalario();
                btnEgresos_Click(sender, e);
                frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
                AbrirFormInPanel(frm);
            }
            else
            {
                MessageBox.Show("¡ACCESO DENEGADO!");
                btnEgresos_Click(sender, e);
            }
        }

        private void btnInversiones_Click(object sender, EventArgs e)
        {
            FormInversion frm = new FormInversion(usuario);
            btnIngresos_Click(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormArqueoTotal frm = new FormArqueoTotal();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnExpiracion_Click(object sender, EventArgs e)
        {
            FormControlProductos frm = new FormControlProductos();
            btnProductos_Click_1(sender, e);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }
        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

        

    }
}
