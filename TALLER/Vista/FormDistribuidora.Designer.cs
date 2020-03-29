namespace TALLER.Vista
{
    partial class FormDistribuidora
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label1;
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxNombreDistribuidora = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtBoxId);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(this.txtBoxCategoria);
            this.panel3.Controls.Add(label8);
            this.panel3.Controls.Add(this.txtBoxTelefono);
            this.panel3.Controls.Add(this.txtBoxDireccion);
            this.panel3.Controls.Add(this.txtBoxNombreDistribuidora);
            this.panel3.Controls.Add(label10);
            this.panel3.Controls.Add(label18);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(label20);
            this.panel3.Controls.Add(label13);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 353);
            this.panel3.TabIndex = 70;
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.FormattingEnabled = true;
            this.txtBoxCategoria.Location = new System.Drawing.Point(206, 142);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(209, 21);
            this.txtBoxCategoria.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(44, 15);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(317, 24);
            label8.TabIndex = 1;
            label8.Text = "DATOS DISTRIBUIDORA NUEVA";
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTelefono.Location = new System.Drawing.Point(206, 170);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(209, 20);
            this.txtBoxTelefono.TabIndex = 4;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxDireccion.Location = new System.Drawing.Point(206, 116);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(209, 20);
            this.txtBoxDireccion.TabIndex = 2;
            // 
            // txtBoxNombreDistribuidora
            // 
            this.txtBoxNombreDistribuidora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNombreDistribuidora.Location = new System.Drawing.Point(206, 88);
            this.txtBoxNombreDistribuidora.Name = "txtBoxNombreDistribuidora";
            this.txtBoxNombreDistribuidora.Size = new System.Drawing.Size(209, 20);
            this.txtBoxNombreDistribuidora.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(45, 175);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(92, 16);
            label10.TabIndex = 1;
            label10.Text = "TELEFONO:";
            // 
            // label18
            // 
            label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.ForeColor = System.Drawing.SystemColors.Control;
            label18.Location = new System.Drawing.Point(45, 117);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(94, 16);
            label18.TabIndex = 1;
            label18.Text = "DIRECCION:";
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
            this.btnGuardar.Location = new System.Drawing.Point(501, 249);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 35);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "EDITAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label20
            // 
            label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.ForeColor = System.Drawing.SystemColors.Control;
            label20.Location = new System.Drawing.Point(45, 89);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(77, 16);
            label20.TabIndex = 1;
            label20.Text = "NOMBRE:";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = System.Drawing.SystemColors.Control;
            label13.Location = new System.Drawing.Point(45, 147);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(99, 16);
            label13.TabIndex = 1;
            label13.Text = "CATEGORIA:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxId.Location = new System.Drawing.Point(206, 52);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(209, 20);
            this.txtBoxId.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(45, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 16);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // FormDistribuidora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1070, 596);
            this.Controls.Add(this.panel3);
            this.Name = "FormDistribuidora";
            this.Text = "DISTRIBUIDORA";
            this.Load += new System.EventHandler(this.FormDistribuidora_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.ComboBox txtBoxCategoria;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxNombreDistribuidora;
        private System.Windows.Forms.Button btnGuardar;
    }
}