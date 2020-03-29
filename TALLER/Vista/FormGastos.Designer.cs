namespace TALLER.Vista
{
    partial class FormGastos
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
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBoxMonto = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnListarEgresos = new System.Windows.Forms.Button();
            label26 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label26
            // 
            label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.ForeColor = System.Drawing.Color.Red;
            label26.Location = new System.Drawing.Point(582, 185);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(16, 20);
            label26.TabIndex = 80;
            label26.Text = "*";
            // 
            // label25
            // 
            label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.ForeColor = System.Drawing.Color.Red;
            label25.Location = new System.Drawing.Point(582, 215);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(16, 20);
            label25.TabIndex = 81;
            label25.Text = "*";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(211, 185);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(99, 16);
            label7.TabIndex = 71;
            label7.Text = "CATEGORIA:";
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = System.Drawing.SystemColors.Control;
            label14.Location = new System.Drawing.Point(211, 215);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(67, 16);
            label14.TabIndex = 72;
            label14.Text = "MONTO:";
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.ForeColor = System.Drawing.SystemColors.Control;
            label15.Location = new System.Drawing.Point(211, 240);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(114, 16);
            label15.TabIndex = 73;
            label15.Text = "DESCRIPCION:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(281, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "GASTOS DE OPERACION";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(label26);
            this.panel1.Controls.Add(label25);
            this.panel1.Controls.Add(this.txtBoxCategoria);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtBoxMonto);
            this.panel1.Controls.Add(this.txtBoxDescripcion);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label14);
            this.panel1.Controls.Add(label15);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 416);
            this.panel1.TabIndex = 66;
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCategoria.FormattingEnabled = true;
            this.txtBoxCategoria.Items.AddRange(new object[] {
            "IMPUESTOS",
            "MATERIAL DE ESCRITORIO",
            "LUZ",
            "AGUA",
            "GASTOS DE CAJA CHICA",
            "EQUIPAMIENTO"});
            this.txtBoxCategoria.Location = new System.Drawing.Point(364, 183);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(212, 23);
            this.txtBoxCategoria.TabIndex = 75;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(200, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(398, 42);
            this.btnGuardar.TabIndex = 78;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBoxMonto
            // 
            this.txtBoxMonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMonto.Location = new System.Drawing.Point(364, 212);
            this.txtBoxMonto.Name = "txtBoxMonto";
            this.txtBoxMonto.Size = new System.Drawing.Size(212, 21);
            this.txtBoxMonto.TabIndex = 74;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(364, 239);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(212, 45);
            this.txtBoxDescripcion.TabIndex = 77;
            // 
            // btnListarEgresos
            // 
            this.btnListarEgresos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnListarEgresos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListarEgresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnListarEgresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListarEgresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListarEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEgresos.ForeColor = System.Drawing.Color.Silver;
            this.btnListarEgresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEgresos.Location = new System.Drawing.Point(487, 461);
            this.btnListarEgresos.Name = "btnListarEgresos";
            this.btnListarEgresos.Size = new System.Drawing.Size(398, 42);
            this.btnListarEgresos.TabIndex = 82;
            this.btnListarEgresos.Text = "LISTAR MIS EGRESOS";
            this.btnListarEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarEgresos.UseVisualStyleBackColor = false;
            this.btnListarEgresos.Click += new System.EventHandler(this.btnListarEgresos_Click);
            // 
            // FormGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(919, 596);
            this.Controls.Add(this.btnListarEgresos);
            this.Controls.Add(this.panel1);
            this.Name = "FormGastos";
            this.Text = "GASTOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtBoxCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBoxMonto;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Button btnListarEgresos;
    }
}