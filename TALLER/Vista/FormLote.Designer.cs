namespace TALLER.Vista
{
    partial class FormLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidadPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidadPorPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaExpiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.txtBoxDistribuidora = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxCosto = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(849, 518);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "COSTO TOTAL:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(189, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(189, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "DISTRIBUIDORA:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(189, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "FECHA Y HORA:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(212, 534);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "DESCRIPCION:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDetalle.Location = new System.Drawing.Point(103, 14);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(260, 29);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "DETALLE DE VENTA";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvCompra);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtBoxDescripcion);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.txtBoxFecha);
            this.panel3.Controls.Add(this.txtBoxDistribuidora);
            this.panel3.Controls.Add(this.txtBoxUsuario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBoxCosto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblDetalle);
            this.panel3.Location = new System.Drawing.Point(16, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 721);
            this.panel3.TabIndex = 66;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompra.ColumnHeadersHeight = 30;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaProducto,
            this.columnaContenido,
            this.columnaCantidad,
            this.columaPrecio,
            this.columnaCantidadPaquete,
            this.columnaCantidadPorPaquete,
            this.columnaCosto,
            this.columnaExpiracion,
            this.columnaId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompra.EnableHeadersVisualStyles = false;
            this.dgvCompra.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCompra.Location = new System.Drawing.Point(40, 217);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompra.Size = new System.Drawing.Size(1231, 268);
            this.dgvCompra.TabIndex = 82;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "CODIGO";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            this.columnaCodigo.Width = 72;
            // 
            // columnaProducto
            // 
            this.columnaProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaProducto.HeaderText = "PRODUCTO";
            this.columnaProducto.Name = "columnaProducto";
            this.columnaProducto.ReadOnly = true;
            this.columnaProducto.Width = 220;
            // 
            // columnaContenido
            // 
            this.columnaContenido.HeaderText = "CONTENIDO";
            this.columnaContenido.Name = "columnaContenido";
            this.columnaContenido.ReadOnly = true;
            this.columnaContenido.Width = 94;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "CANTIDAD UNIDAD";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.ReadOnly = true;
            this.columnaCantidad.Width = 91;
            // 
            // columaPrecio
            // 
            this.columaPrecio.HeaderText = "PRECIO UNIDAD";
            this.columaPrecio.Name = "columaPrecio";
            this.columaPrecio.ReadOnly = true;
            this.columaPrecio.Width = 77;
            // 
            // columnaCantidadPaquete
            // 
            this.columnaCantidadPaquete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaCantidadPaquete.HeaderText = "CANTIDAD PAQUETES";
            this.columnaCantidadPaquete.Name = "columnaCantidadPaquete";
            this.columnaCantidadPaquete.ReadOnly = true;
            this.columnaCantidadPaquete.Width = 80;
            // 
            // columnaCantidadPorPaquete
            // 
            this.columnaCantidadPorPaquete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaCantidadPorPaquete.HeaderText = "CANTIDAD X PAQUETE";
            this.columnaCantidadPorPaquete.Name = "columnaCantidadPorPaquete";
            this.columnaCantidadPorPaquete.ReadOnly = true;
            this.columnaCantidadPorPaquete.Width = 80;
            // 
            // columnaCosto
            // 
            this.columnaCosto.HeaderText = "COSTO";
            this.columnaCosto.Name = "columnaCosto";
            this.columnaCosto.ReadOnly = true;
            this.columnaCosto.Width = 67;
            // 
            // columnaExpiracion
            // 
            this.columnaExpiracion.HeaderText = "EXPIRACION";
            this.columnaExpiracion.Name = "columnaExpiracion";
            this.columnaExpiracion.ReadOnly = true;
            this.columnaExpiracion.Width = 95;
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "ID";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Visible = false;
            this.columnaId.Width = 41;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(372, 506);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(443, 88);
            this.txtBoxDescripcion.TabIndex = 80;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(869, 607);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(257, 29);
            this.lblEstado.TabIndex = 79;
            this.lblEstado.Text = "VENTA CANCELADA";
            this.lblEstado.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(863, 602);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(307, 43);
            this.btnCancelar.TabIndex = 78;
            this.btnCancelar.Text = "CANCELAR VENTA";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxFecha.Location = new System.Drawing.Point(372, 160);
            this.txtBoxFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.ReadOnly = true;
            this.txtBoxFecha.Size = new System.Drawing.Size(197, 22);
            this.txtBoxFecha.TabIndex = 75;
            // 
            // txtBoxDistribuidora
            // 
            this.txtBoxDistribuidora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxDistribuidora.Location = new System.Drawing.Point(372, 119);
            this.txtBoxDistribuidora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDistribuidora.Name = "txtBoxDistribuidora";
            this.txtBoxDistribuidora.ReadOnly = true;
            this.txtBoxDistribuidora.Size = new System.Drawing.Size(197, 22);
            this.txtBoxDistribuidora.TabIndex = 75;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxUsuario.Location = new System.Drawing.Point(372, 76);
            this.txtBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.ReadOnly = true;
            this.txtBoxUsuario.Size = new System.Drawing.Size(197, 22);
            this.txtBoxUsuario.TabIndex = 75;
            // 
            // txtBoxCosto
            // 
            this.txtBoxCosto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCosto.Location = new System.Drawing.Point(1013, 506);
            this.txtBoxCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCosto.Name = "txtBoxCosto";
            this.txtBoxCosto.ReadOnly = true;
            this.txtBoxCosto.Size = new System.Drawing.Size(121, 37);
            this.txtBoxCosto.TabIndex = 70;
            // 
            // FormLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1357, 751);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLote";
            this.Text = "DETALLE DE COMPRA";
            this.Load += new System.EventHandler(this.FormLote_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtBoxCosto;
        private System.Windows.Forms.TextBox txtBoxFecha;
        private System.Windows.Forms.TextBox txtBoxDistribuidora;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidadPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidadPorPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaExpiracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
    }
}