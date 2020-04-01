namespace TALLER.CapaVista
{
    partial class FormVentas
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label vEND_IDLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtBoxPago = new System.Windows.Forms.ComboBox();
            this.txtBoxCosto = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtBoxCambio = new System.Windows.Forms.TextBox();
            this.txtBoxEfectivo = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxNombres = new System.Windows.Forms.TextBox();
            this.txtBoxCi = new System.Windows.Forms.TextBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListarVentas = new System.Windows.Forms.Button();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            vEND_IDLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(11, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 24);
            label2.TabIndex = 1;
            label2.Text = "DATOS VENTA";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(23, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 16);
            label3.TabIndex = 1;
            label3.Text = "CODIGO:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(32, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 24);
            label1.TabIndex = 1;
            label1.Text = "DATOS CLIENTE";
            // 
            // vEND_IDLabel
            // 
            vEND_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            vEND_IDLabel.AutoSize = true;
            vEND_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vEND_IDLabel.ForeColor = System.Drawing.SystemColors.Control;
            vEND_IDLabel.Location = new System.Drawing.Point(33, 49);
            vEND_IDLabel.Name = "vEND_IDLabel";
            vEND_IDLabel.Size = new System.Drawing.Size(70, 16);
            vEND_IDLabel.TabIndex = 1;
            vEND_IDLabel.Text = "CI O NIT:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(33, 80);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 16);
            label4.TabIndex = 1;
            label4.Text = "NOMBRES:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(437, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 16);
            label6.TabIndex = 1;
            label6.Text = "TELEFONO:";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(10, 419);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(86, 16);
            label8.TabIndex = 63;
            label8.Text = "EFECTIVO:";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.SystemColors.Control;
            label9.Location = new System.Drawing.Point(437, 419);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(117, 16);
            label9.TabIndex = 63;
            label9.Text = "COSTO TOTAL:";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(10, 451);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 16);
            label10.TabIndex = 63;
            label10.Text = "CAMBIO:";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.SystemColors.Control;
            label11.Location = new System.Drawing.Point(384, 536);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(70, 16);
            label11.TabIndex = 63;
            label11.Text = "CODIGO:";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = System.Drawing.SystemColors.Control;
            label13.Location = new System.Drawing.Point(226, 419);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(54, 16);
            label13.TabIndex = 63;
            label13.Text = "PAGO:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(label11);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.btnAlmacen);
            this.panel2.Controls.Add(this.txtBoxPago);
            this.panel2.Controls.Add(this.btnBuscarProducto);
            this.panel2.Controls.Add(this.dgvVenta);
            this.panel2.Controls.Add(this.txtBoxCosto);
            this.panel2.Controls.Add(this.txtBoxCodigo);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(this.txtBoxCambio);
            this.panel2.Controls.Add(label10);
            this.panel2.Controls.Add(label13);
            this.panel2.Controls.Add(this.txtBoxEfectivo);
            this.panel2.Controls.Add(label9);
            this.panel2.Controls.Add(this.btnProcesar);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 521);
            this.panel2.TabIndex = 66;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(538, 463);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 42);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Silver;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(664, 463);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 42);
            this.btnRegistrar.TabIndex = 66;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtBoxPago
            // 
            this.txtBoxPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPago.FormattingEnabled = true;
            this.txtBoxPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA",
            "CREDITO"});
            this.txtBoxPago.Location = new System.Drawing.Point(286, 411);
            this.txtBoxPago.Name = "txtBoxPago";
            this.txtBoxPago.Size = new System.Drawing.Size(110, 28);
            this.txtBoxPago.TabIndex = 65;
            this.txtBoxPago.SelectedValueChanged += new System.EventHandler(this.txtBoxPago_SelectedValueChanged);
            this.txtBoxPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPago_KeyDown);
            // 
            // txtBoxCosto
            // 
            this.txtBoxCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCosto.Location = new System.Drawing.Point(560, 409);
            this.txtBoxCosto.Name = "txtBoxCosto";
            this.txtBoxCosto.ReadOnly = true;
            this.txtBoxCosto.Size = new System.Drawing.Size(92, 31);
            this.txtBoxCosto.TabIndex = 64;
            this.txtBoxCosto.TextChanged += new System.EventHandler(this.txtBoxCosto_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(471, 535);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 64;
            // 
            // txtBoxCambio
            // 
            this.txtBoxCambio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCambio.Location = new System.Drawing.Point(111, 441);
            this.txtBoxCambio.Name = "txtBoxCambio";
            this.txtBoxCambio.ReadOnly = true;
            this.txtBoxCambio.Size = new System.Drawing.Size(92, 31);
            this.txtBoxCambio.TabIndex = 64;
            // 
            // txtBoxEfectivo
            // 
            this.txtBoxEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEfectivo.Location = new System.Drawing.Point(111, 409);
            this.txtBoxEfectivo.Name = "txtBoxEfectivo";
            this.txtBoxEfectivo.Size = new System.Drawing.Size(92, 31);
            this.txtBoxEfectivo.TabIndex = 64;
            this.txtBoxEfectivo.TextChanged += new System.EventHandler(this.txtBoxEfectivo_TextChanged);
            this.txtBoxEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxEfectivo_KeyDown);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Silver;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(664, 463);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(120, 42);
            this.btnProcesar.TabIndex = 62;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlmacen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.Silver;
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(578, 36);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(109, 35);
            this.btnAlmacen.TabIndex = 62;
            this.btnAlmacen.Text = "ALMACEN";
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlmacen.UseVisualStyleBackColor = false;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(279, 42);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(109, 35);
            this.btnBuscarProducto.TabIndex = 62;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVenta.ColumnHeadersHeight = 30;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaProducto,
            this.columnaContenido,
            this.columaPrecio,
            this.columnaCantidad,
            this.columnaCosto,
            this.columnaId});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVenta.Location = new System.Drawing.Point(15, 80);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVenta.Size = new System.Drawing.Size(769, 323);
            this.dgvVenta.TabIndex = 9;
            this.dgvVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellValueChanged);
            this.dgvVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvVenta_RowsRemoved);
            this.dgvVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVenta_KeyDown);
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCodigo.Location = new System.Drawing.Point(124, 54);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtBoxCodigo.TabIndex = 2;
            this.txtBoxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCodigo_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txtBoxTelefono);
            this.panel1.Controls.Add(this.txtBoxNombres);
            this.panel1.Controls.Add(this.txtBoxCi);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(vEND_IDLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 113);
            this.panel1.TabIndex = 65;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.Silver;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(602, 38);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(109, 35);
            this.btnRegistro.TabIndex = 68;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(303, 39);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(109, 34);
            this.btnBuscarCliente.TabIndex = 62;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTelefono.Location = new System.Drawing.Point(537, 79);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(174, 20);
            this.txtBoxTelefono.TabIndex = 2;
            // 
            // txtBoxNombres
            // 
            this.txtBoxNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNombres.Location = new System.Drawing.Point(131, 79);
            this.txtBoxNombres.Name = "txtBoxNombres";
            this.txtBoxNombres.Size = new System.Drawing.Size(281, 20);
            this.txtBoxNombres.TabIndex = 2;
            // 
            // txtBoxCi
            // 
            this.txtBoxCi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCi.Location = new System.Drawing.Point(131, 48);
            this.txtBoxCi.Name = "txtBoxCi";
            this.txtBoxCi.Size = new System.Drawing.Size(166, 20);
            this.txtBoxCi.TabIndex = 2;
            this.txtBoxCi.TextChanged += new System.EventHandler(this.txtBoxCi_TextChanged);
            this.txtBoxCi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCi_KeyDown);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCantidad.Location = new System.Drawing.Point(777, 680);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(10, 10);
            this.txtBoxCantidad.TabIndex = 66;
            this.txtBoxCantidad.TextChanged += new System.EventHandler(this.txtBoxCantidad_TextChanged);
            this.txtBoxCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCantidad_KeyDown);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(33, 658);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 42);
            this.btnLimpiar.TabIndex = 68;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnListarVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListarVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnListarVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarVentas.ForeColor = System.Drawing.Color.Silver;
            this.btnListarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarVentas.Location = new System.Drawing.Point(569, 658);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(257, 42);
            this.btnListarVentas.TabIndex = 68;
            this.btnListarVentas.Text = "LISTAR MIS VENTAS";
            this.btnListarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarVentas.UseVisualStyleBackColor = false;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
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
            this.columnaProducto.Width = 280;
            // 
            // columnaContenido
            // 
            this.columnaContenido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaContenido.HeaderText = "CONTENIDO";
            this.columnaContenido.Name = "columnaContenido";
            this.columnaContenido.ReadOnly = true;
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
            this.columnaId.Width = 41;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(851, 730);
            this.Controls.Add(this.btnListarVentas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormVentas";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxCi;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxNombres;
        private System.Windows.Forms.TextBox txtBoxCosto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtBoxCambio;
        private System.Windows.Forms.TextBox txtBoxEfectivo;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.ComboBox txtBoxPago;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListarVentas;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
    }
}