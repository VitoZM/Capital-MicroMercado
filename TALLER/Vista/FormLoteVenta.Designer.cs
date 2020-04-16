namespace TALLER.Vista
{
    partial class FormLoteVenta
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxTarjeta = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxCi = new System.Windows.Forms.TextBox();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.txtBoxVendedor = new System.Windows.Forms.TextBox();
            this.txtBoxCosto = new System.Windows.Forms.TextBox();
            this.txtBoxCambio = new System.Windows.Forms.TextBox();
            this.txtBoxPago = new System.Windows.Forms.TextBox();
            this.txtBoxEfectivo = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.SystemColors.Control;
            label9.Location = new System.Drawing.Point(618, 431);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(117, 16);
            label9.TabIndex = 67;
            label9.Text = "COSTO TOTAL:";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(3, 463);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 16);
            label10.TabIndex = 68;
            label10.Text = "CAMBIO:";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(3, 431);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(86, 16);
            label8.TabIndex = 69;
            label8.Text = "EFECTIVO:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(74, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 16);
            label3.TabIndex = 74;
            label3.Text = "VENDEDOR:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(74, 98);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 16);
            label1.TabIndex = 74;
            label1.Text = "CLIENTE:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(74, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 16);
            label2.TabIndex = 74;
            label2.Text = "FECHA Y HORA:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(228, 431);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 16);
            label5.TabIndex = 67;
            label5.Text = "PAGO:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(370, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(145, 16);
            label4.TabIndex = 76;
            label4.Text = "C.I. O NIT CLIENTE:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(139, 532);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 16);
            label6.TabIndex = 81;
            label6.Text = "DESCRIPCION:";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(424, 431);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(91, 16);
            label7.TabIndex = 84;
            label7.Text = "TARJETAS:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDetalle.Location = new System.Drawing.Point(17, 11);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(211, 24);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "DETALLE DE VENTA";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(label7);
            this.panel3.Controls.Add(this.txtBoxTarjeta);
            this.panel3.Controls.Add(this.btnReporte);
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(label6);
            this.panel3.Controls.Add(this.txtBoxDescripcion);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.txtBoxCi);
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(this.txtBoxFecha);
            this.panel3.Controls.Add(this.txtBoxCliente);
            this.panel3.Controls.Add(this.txtBoxVendedor);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.txtBoxCosto);
            this.panel3.Controls.Add(this.txtBoxCambio);
            this.panel3.Controls.Add(this.txtBoxPago);
            this.panel3.Controls.Add(this.txtBoxEfectivo);
            this.panel3.Controls.Add(label5);
            this.panel3.Controls.Add(label9);
            this.panel3.Controls.Add(label10);
            this.panel3.Controls.Add(label8);
            this.panel3.Controls.Add(this.dgvVenta);
            this.panel3.Controls.Add(this.lblDetalle);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 586);
            this.panel3.TabIndex = 66;
            // 
            // txtBoxTarjeta
            // 
            this.txtBoxTarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTarjeta.Location = new System.Drawing.Point(521, 421);
            this.txtBoxTarjeta.Name = "txtBoxTarjeta";
            this.txtBoxTarjeta.ReadOnly = true;
            this.txtBoxTarjeta.Size = new System.Drawing.Size(91, 31);
            this.txtBoxTarjeta.TabIndex = 85;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Silver;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(612, 11);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(230, 35);
            this.btnReporte.TabIndex = 83;
            this.btnReporte.Text = "IMPRIMIR";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.Silver;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(612, 481);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(230, 35);
            this.btnPagar.TabIndex = 82;
            this.btnPagar.Text = "PAGAR DEUDA";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(259, 509);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(333, 72);
            this.txtBoxDescripcion.TabIndex = 80;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(617, 542);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(210, 24);
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
            this.btnCancelar.Location = new System.Drawing.Point(612, 538);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 35);
            this.btnCancelar.TabIndex = 78;
            this.btnCancelar.Text = "CANCELAR VENTA";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxCi
            // 
            this.txtBoxCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCi.Location = new System.Drawing.Point(521, 97);
            this.txtBoxCi.Name = "txtBoxCi";
            this.txtBoxCi.ReadOnly = true;
            this.txtBoxCi.Size = new System.Drawing.Size(149, 20);
            this.txtBoxCi.TabIndex = 77;
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxFecha.Location = new System.Drawing.Point(203, 130);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.ReadOnly = true;
            this.txtBoxFecha.Size = new System.Drawing.Size(149, 20);
            this.txtBoxFecha.TabIndex = 75;
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCliente.Location = new System.Drawing.Point(203, 97);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.ReadOnly = true;
            this.txtBoxCliente.Size = new System.Drawing.Size(149, 20);
            this.txtBoxCliente.TabIndex = 75;
            // 
            // txtBoxVendedor
            // 
            this.txtBoxVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxVendedor.Location = new System.Drawing.Point(203, 62);
            this.txtBoxVendedor.Name = "txtBoxVendedor";
            this.txtBoxVendedor.ReadOnly = true;
            this.txtBoxVendedor.Size = new System.Drawing.Size(149, 20);
            this.txtBoxVendedor.TabIndex = 75;
            // 
            // txtBoxCosto
            // 
            this.txtBoxCosto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCosto.Location = new System.Drawing.Point(741, 421);
            this.txtBoxCosto.Name = "txtBoxCosto";
            this.txtBoxCosto.ReadOnly = true;
            this.txtBoxCosto.Size = new System.Drawing.Size(92, 31);
            this.txtBoxCosto.TabIndex = 70;
            // 
            // txtBoxCambio
            // 
            this.txtBoxCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCambio.Location = new System.Drawing.Point(104, 453);
            this.txtBoxCambio.Name = "txtBoxCambio";
            this.txtBoxCambio.ReadOnly = true;
            this.txtBoxCambio.Size = new System.Drawing.Size(92, 31);
            this.txtBoxCambio.TabIndex = 71;
            // 
            // txtBoxPago
            // 
            this.txtBoxPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPago.Location = new System.Drawing.Point(288, 421);
            this.txtBoxPago.Name = "txtBoxPago";
            this.txtBoxPago.ReadOnly = true;
            this.txtBoxPago.Size = new System.Drawing.Size(110, 31);
            this.txtBoxPago.TabIndex = 72;
            // 
            // txtBoxEfectivo
            // 
            this.txtBoxEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEfectivo.Location = new System.Drawing.Point(104, 421);
            this.txtBoxEfectivo.Name = "txtBoxEfectivo";
            this.txtBoxEfectivo.ReadOnly = true;
            this.txtBoxEfectivo.Size = new System.Drawing.Size(92, 31);
            this.txtBoxEfectivo.TabIndex = 72;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenta.ColumnHeadersHeight = 30;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaProducto,
            this.columnaPresentacion,
            this.columaPrecio,
            this.columnaCantidad,
            this.columnaCosto,
            this.columnaId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVenta.Location = new System.Drawing.Point(18, 175);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.Size = new System.Drawing.Size(824, 240);
            this.dgvVenta.TabIndex = 66;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaCodigo.HeaderText = "CODIGO";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // 
            // columnaProducto
            // 
            this.columnaProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaProducto.HeaderText = "PRODUCTO";
            this.columnaProducto.Name = "columnaProducto";
            this.columnaProducto.ReadOnly = true;
            this.columnaProducto.Width = 200;
            // 
            // columnaPresentacion
            // 
            this.columnaPresentacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaPresentacion.HeaderText = "PRESENTACION";
            this.columnaPresentacion.Name = "columnaPresentacion";
            this.columnaPresentacion.ReadOnly = true;
            this.columnaPresentacion.Width = 140;
            // 
            // columaPrecio
            // 
            this.columaPrecio.HeaderText = "PRECIO";
            this.columaPrecio.Name = "columaPrecio";
            this.columaPrecio.ReadOnly = true;
            this.columaPrecio.Width = 70;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "CANTIDAD";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.ReadOnly = true;
            this.columnaCantidad.Width = 85;
            // 
            // columnaCosto
            // 
            this.columnaCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaCosto.HeaderText = "COSTO";
            this.columnaCosto.Name = "columnaCosto";
            this.columnaCosto.ReadOnly = true;
            this.columnaCosto.Width = 70;
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "ID";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Visible = false;
            this.columnaId.Width = 43;
            // 
            // FormLoteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(889, 610);
            this.Controls.Add(this.panel3);
            this.Name = "FormLoteVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE DE VENTA";
            this.Load += new System.EventHandler(this.FormLoteVenta_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtBoxCosto;
        private System.Windows.Forms.TextBox txtBoxCambio;
        private System.Windows.Forms.TextBox txtBoxEfectivo;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.TextBox txtBoxFecha;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.TextBox txtBoxVendedor;
        private System.Windows.Forms.TextBox txtBoxPago;
        private System.Windows.Forms.TextBox txtBoxCi;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtBoxTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
    }
}