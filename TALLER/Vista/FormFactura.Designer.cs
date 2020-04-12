namespace TALLER.Vista
{
    partial class FormFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cAPITALTableAdapterDataSet = new TALLER.CAPITALTableAdapterDataSet();
            this.lISTARLOTEVENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lISTARLOTEVENTATableAdapter = new TALLER.CAPITALTableAdapterDataSetTableAdapters.LISTARLOTEVENTATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cAPITALTableAdapterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTARLOTEVENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lISTARLOTEVENTABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TALLER.Informes.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1070, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // cAPITALTableAdapterDataSet
            // 
            this.cAPITALTableAdapterDataSet.DataSetName = "CAPITALTableAdapterDataSet";
            this.cAPITALTableAdapterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lISTARLOTEVENTABindingSource
            // 
            this.lISTARLOTEVENTABindingSource.DataMember = "LISTARLOTEVENTA";
            this.lISTARLOTEVENTABindingSource.DataSource = this.cAPITALTableAdapterDataSet;
            // 
            // lISTARLOTEVENTATableAdapter
            // 
            this.lISTARLOTEVENTATableAdapter.ClearBeforeFill = true;
            // 
            // InformePrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1070, 596);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformePrueba";
            this.Text = "INFORME DE PRUEBA";
            this.Load += new System.EventHandler(this.InformePrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAPITALTableAdapterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTARLOTEVENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lISTARLOTEVENTABindingSource;
        private CAPITALTableAdapterDataSet cAPITALTableAdapterDataSet;
        private CAPITALTableAdapterDataSetTableAdapters.LISTARLOTEVENTATableAdapter lISTARLOTEVENTATableAdapter;
    }
}