namespace TALLER.Vista
{
    partial class FormCliente
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label vEND_IDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label21;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxNombres = new System.Windows.Forms.TextBox();
            this.txtBoxCi = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            vEND_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 356);
            this.panel1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(label22);
            this.panel2.Controls.Add(label21);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.txtBoxTelefono);
            this.panel2.Controls.Add(this.txtBoxNombres);
            this.panel2.Controls.Add(this.txtBoxId);
            this.panel2.Controls.Add(this.txtBoxCi);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(vEND_IDLabel);
            this.panel2.Location = new System.Drawing.Point(37, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 191);
            this.panel2.TabIndex = 68;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(34, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(217, 24);
            label2.TabIndex = 1;
            label2.Text = "DATOS DEL CLIENTE";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(695, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 34);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTelefono.Location = new System.Drawing.Point(133, 149);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(174, 20);
            this.txtBoxTelefono.TabIndex = 4;
            // 
            // txtBoxNombres
            // 
            this.txtBoxNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNombres.Location = new System.Drawing.Point(133, 115);
            this.txtBoxNombres.Name = "txtBoxNombres";
            this.txtBoxNombres.Size = new System.Drawing.Size(281, 20);
            this.txtBoxNombres.TabIndex = 3;
            // 
            // txtBoxCi
            // 
            this.txtBoxCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCi.Location = new System.Drawing.Point(133, 81);
            this.txtBoxCi.Name = "txtBoxCi";
            this.txtBoxCi.Size = new System.Drawing.Size(166, 20);
            this.txtBoxCi.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(33, 150);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 16);
            label6.TabIndex = 1;
            label6.Text = "TELEFONO:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(35, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 16);
            label3.TabIndex = 1;
            label3.Text = "NOMBRES:";
            // 
            // vEND_IDLabel
            // 
            vEND_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            vEND_IDLabel.AutoSize = true;
            vEND_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vEND_IDLabel.ForeColor = System.Drawing.SystemColors.Control;
            vEND_IDLabel.Location = new System.Drawing.Point(35, 82);
            vEND_IDLabel.Name = "vEND_IDLabel";
            vEND_IDLabel.Size = new System.Drawing.Size(70, 16);
            vEND_IDLabel.TabIndex = 1;
            vEND_IDLabel.Text = "CI O NIT:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(35, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 16);
            label1.TabIndex = 1;
            label1.Text = "ID CLIENTE:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxId.Location = new System.Drawing.Point(133, 50);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(166, 20);
            this.txtBoxId.TabIndex = 2;
            // 
            // label22
            // 
            label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = System.Drawing.Color.Red;
            label22.Location = new System.Drawing.Point(305, 82);
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
            label21.Location = new System.Drawing.Point(420, 116);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(16, 20);
            label21.TabIndex = 92;
            label21.Text = "*";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1070, 383);
            this.Controls.Add(this.panel1);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxNombres;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxCi;
    }
}