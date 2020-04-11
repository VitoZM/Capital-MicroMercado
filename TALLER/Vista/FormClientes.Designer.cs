namespace TALLER.Vista
{
    partial class FormClientes
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label vEND_IDLabel;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxBuscarCi = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxNombres = new System.Windows.Forms.TextBox();
            this.txtBoxCi = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            vEND_IDLabel = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(275, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(143, 16);
            label3.TabIndex = 65;
            label3.Text = "CI, NIT O NOMBRE:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(13, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 24);
            label1.TabIndex = 1;
            label1.Text = "DATOS CLIENTE NUEVO";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(426, 49);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 16);
            label6.TabIndex = 1;
            label6.Text = "TELEFONO:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(14, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 16);
            label2.TabIndex = 1;
            label2.Text = "NOMBRES:";
            // 
            // vEND_IDLabel
            // 
            vEND_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            vEND_IDLabel.AutoSize = true;
            vEND_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vEND_IDLabel.ForeColor = System.Drawing.SystemColors.Control;
            vEND_IDLabel.Location = new System.Drawing.Point(14, 49);
            vEND_IDLabel.Name = "vEND_IDLabel";
            vEND_IDLabel.Size = new System.Drawing.Size(70, 16);
            vEND_IDLabel.TabIndex = 1;
            vEND_IDLabel.Text = "CI O NIT:";
            // 
            // label22
            // 
            label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = System.Drawing.Color.Red;
            label22.Location = new System.Drawing.Point(284, 49);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(16, 20);
            label22.TabIndex = 93;
            label22.Text = "*";
            // 
            // label21
            // 
            label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.ForeColor = System.Drawing.Color.Red;
            label21.Location = new System.Drawing.Point(399, 79);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(16, 20);
            label21.TabIndex = 92;
            label21.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(393, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "CLIENTES";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtBoxBuscarCi);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvClientes);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 449);
            this.panel3.TabIndex = 66;
            // 
            // txtBoxBuscarCi
            // 
            this.txtBoxBuscarCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxBuscarCi.Location = new System.Drawing.Point(453, 42);
            this.txtBoxBuscarCi.Name = "txtBoxBuscarCi";
            this.txtBoxBuscarCi.Size = new System.Drawing.Size(164, 20);
            this.txtBoxBuscarCi.TabIndex = 64;
            this.txtBoxBuscarCi.TextChanged += new System.EventHandler(this.txtBoxBuscarCi_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvClientes.Location = new System.Drawing.Point(3, 74);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Size = new System.Drawing.Size(931, 370);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(label21);
            this.panel1.Controls.Add(label22);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtBoxTelefono);
            this.panel1.Controls.Add(this.txtBoxNombres);
            this.panel1.Controls.Add(this.txtBoxCi);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(vEND_IDLabel);
            this.panel1.Location = new System.Drawing.Point(36, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 113);
            this.panel1.TabIndex = 67;
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
            this.btnGuardar.Location = new System.Drawing.Point(557, 70);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 34);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTelefono.Location = new System.Drawing.Point(526, 48);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(174, 20);
            this.txtBoxTelefono.TabIndex = 4;
            // 
            // txtBoxNombres
            // 
            this.txtBoxNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNombres.Location = new System.Drawing.Point(112, 79);
            this.txtBoxNombres.Name = "txtBoxNombres";
            this.txtBoxNombres.Size = new System.Drawing.Size(281, 20);
            this.txtBoxNombres.TabIndex = 3;
            // 
            // txtBoxCi
            // 
            this.txtBoxCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCi.Location = new System.Drawing.Point(112, 48);
            this.txtBoxCi.Name = "txtBoxCi";
            this.txtBoxCi.Size = new System.Drawing.Size(166, 20);
            this.txtBoxCi.TabIndex = 2;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(963, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBuscarCi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxNombres;
        private System.Windows.Forms.TextBox txtBoxCi;
    }
}