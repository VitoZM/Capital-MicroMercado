using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALLER.Vista
{
    public partial class FormFactura : Form
    {
        private int idVenta;
        public FormFactura(int id)
        {
            InitializeComponent();
            idVenta = id;
        }

        private void InformePrueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAPITALTableAdapterDataSet.LISTARLOTEVENTA' Puede moverla o quitarla según sea necesario.
            this.lISTARLOTEVENTATableAdapter.Fill(this.cAPITALTableAdapterDataSet.LISTARLOTEVENTA, idVenta);
            this.reportViewer1.RefreshReport();
        }
    }
}
