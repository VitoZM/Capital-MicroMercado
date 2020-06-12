namespace TALLER.Vista
{
    partial class FormTarjetas
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label vEND_IDLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListarVentas = new System.Windows.Forms.Button();
            this.txtBoxEfectivo = new System.Windows.Forms.TextBox();
            this.txtBoxCostoTotal = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxBuscarCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxCapital = new System.Windows.Forms.TextBox();
            this.txtBoxMontoEfectivo = new System.Windows.Forms.TextBox();
            this.txtBoxMontoPrestado = new System.Windows.Forms.TextBox();
            this.txtBoxMontoDeuda = new System.Windows.Forms.TextBox();
            this.txtBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.txtBoxTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            vEND_IDLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.SystemColors.Control;
            label9.Location = new System.Drawing.Point(499, 268);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(117, 16);
            label9.TabIndex = 63;
            label9.Text = "COSTO TOTAL:";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.SystemColors.Control;
            label11.Location = new System.Drawing.Point(443, 536);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(70, 16);
            label11.TabIndex = 63;
            label11.Text = "CODIGO:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 24);
            label2.TabIndex = 1;
            label2.Text = "DATOS COMPRA";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(45, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 16);
            label3.TabIndex = 1;
            label3.Text = "CODIGO:";
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = System.Drawing.SystemColors.Control;
            label17.Location = new System.Drawing.Point(464, 56);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(154, 16);
            label17.TabIndex = 64;
            label17.Text = "MONTO PRESTADO:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 24);
            label1.TabIndex = 1;
            label1.Text = "CAJA TARJETAS";
            // 
            // label19
            // 
            label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.ForeColor = System.Drawing.SystemColors.Control;
            label19.Location = new System.Drawing.Point(464, 82);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(145, 16);
            label19.TabIndex = 1;
            label19.Text = "MONTO EFECTIVO:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(14, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 16);
            label4.TabIndex = 1;
            label4.Text = "MONTO DEUDA:";
            // 
            // vEND_IDLabel
            // 
            vEND_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            vEND_IDLabel.AutoSize = true;
            vEND_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vEND_IDLabel.ForeColor = System.Drawing.SystemColors.Control;
            vEND_IDLabel.Location = new System.Drawing.Point(14, 30);
            vEND_IDLabel.Name = "vEND_IDLabel";
            vEND_IDLabel.Size = new System.Drawing.Size(120, 16);
            vEND_IDLabel.TabIndex = 1;
            vEND_IDLabel.Text = "MONTO TOTAL:";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(21, 268);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(86, 16);
            label8.TabIndex = 63;
            label8.Text = "EFECTIVO:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(431, 3);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 24);
            label5.TabIndex = 65;
            label5.Text = "TARJETAS";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(464, 30);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(182, 16);
            label7.TabIndex = 1;
            label7.Text = "CAPITAL EN TARJETAS:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.btnListarVentas);
            this.panel2.Controls.Add(this.txtBoxEfectivo);
            this.panel2.Controls.Add(this.txtBoxTipo);
            this.panel2.Controls.Add(this.txtBoxCostoTotal);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(label9);
            this.panel2.Controls.Add(label11);
            this.panel2.Controls.Add(this.btnProcesar);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.btnBuscarProducto);
            this.panel2.Controls.Add(this.dgvVenta);
            this.panel2.Controls.Add(this.txtBoxBuscarCodigo);
            this.panel2.Controls.Add(label3);
            this.panel2.Location = new System.Drawing.Point(12, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 341);
            this.panel2.TabIndex = 73;
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnListarVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListarVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnListarVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarVentas.ForeColor = System.Drawing.Color.Silver;
            this.btnListarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarVentas.Location = new System.Drawing.Point(324, 268);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(152, 42);
            this.btnListarVentas.TabIndex = 74;
            this.btnListarVentas.Text = "LISTAR COMPRAS";
            this.btnListarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarVentas.UseVisualStyleBackColor = false;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
            // 
            // txtBoxEfectivo
            // 
            this.txtBoxEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEfectivo.Location = new System.Drawing.Point(144, 265);
            this.txtBoxEfectivo.Name = "txtBoxEfectivo";
            this.txtBoxEfectivo.Size = new System.Drawing.Size(149, 22);
            this.txtBoxEfectivo.TabIndex = 64;
            this.txtBoxEfectivo.TextChanged += new System.EventHandler(this.txtBoxEfectivo_TextChanged);
            // 
            // txtBoxCostoTotal
            // 
            this.txtBoxCostoTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCostoTotal.Location = new System.Drawing.Point(622, 265);
            this.txtBoxCostoTotal.Name = "txtBoxCostoTotal";
            this.txtBoxCostoTotal.ReadOnly = true;
            this.txtBoxCostoTotal.Size = new System.Drawing.Size(149, 22);
            this.txtBoxCostoTotal.TabIndex = 64;
            this.txtBoxCostoTotal.Text = "0";
            this.txtBoxCostoTotal.TextChanged += new System.EventHandler(this.txtBoxCostoTotal_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(530, 535);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 64;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Silver;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(791, 254);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(120, 42);
            this.btnProcesar.TabIndex = 62;
            this.btnProcesar.Text = "REGISTRAR";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(312, 12);
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
            this.dgvVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvVenta.ColumnHeadersHeight = 30;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaProducto,
            this.columnaContenido,
            this.columnaCantidad,
            this.columaPrecio,
            this.columnaCosto,
            this.columnaId});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVenta.Location = new System.Drawing.Point(3, 50);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvVenta.Size = new System.Drawing.Size(923, 198);
            this.dgvVenta.TabIndex = 9;
            this.dgvVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellValueChanged);
            this.dgvVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVenta_KeyDown);
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
            this.columnaCantidad.HeaderText = "CANTIDAD";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.Width = 91;
            // 
            // columaPrecio
            // 
            this.columaPrecio.HeaderText = "PRECIO UNIDAD";
            this.columaPrecio.Name = "columaPrecio";
            this.columaPrecio.Width = 77;
            // 
            // columnaCosto
            // 
            this.columnaCosto.HeaderText = "COSTO";
            this.columnaCosto.Name = "columnaCosto";
            this.columnaCosto.ReadOnly = true;
            this.columnaCosto.Width = 67;
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "ID";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Visible = false;
            this.columnaId.Width = 41;
            // 
            // txtBoxBuscarCodigo
            // 
            this.txtBoxBuscarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxBuscarCodigo.Location = new System.Drawing.Point(157, 24);
            this.txtBoxBuscarCodigo.Name = "txtBoxBuscarCodigo";
            this.txtBoxBuscarCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtBoxBuscarCodigo.TabIndex = 12;
            this.txtBoxBuscarCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxBuscarCodigo_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(label17);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.txtBoxCapital);
            this.panel1.Controls.Add(this.txtBoxMontoEfectivo);
            this.panel1.Controls.Add(this.txtBoxMontoPrestado);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.txtBoxMontoDeuda);
            this.panel1.Controls.Add(this.txtBoxMontoTotal);
            this.panel1.Controls.Add(label19);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(vEND_IDLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 111);
            this.panel1.TabIndex = 71;
            // 
            // txtBoxCapital
            // 
            this.txtBoxCapital.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCapital.Location = new System.Drawing.Point(669, 27);
            this.txtBoxCapital.Name = "txtBoxCapital";
            this.txtBoxCapital.ReadOnly = true;
            this.txtBoxCapital.Size = new System.Drawing.Size(213, 21);
            this.txtBoxCapital.TabIndex = 1;
            // 
            // txtBoxMontoEfectivo
            // 
            this.txtBoxMontoEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxMontoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMontoEfectivo.Location = new System.Drawing.Point(669, 79);
            this.txtBoxMontoEfectivo.Name = "txtBoxMontoEfectivo";
            this.txtBoxMontoEfectivo.ReadOnly = true;
            this.txtBoxMontoEfectivo.Size = new System.Drawing.Size(213, 21);
            this.txtBoxMontoEfectivo.TabIndex = 1;
            // 
            // txtBoxMontoPrestado
            // 
            this.txtBoxMontoPrestado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxMontoPrestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMontoPrestado.Location = new System.Drawing.Point(669, 53);
            this.txtBoxMontoPrestado.Name = "txtBoxMontoPrestado";
            this.txtBoxMontoPrestado.ReadOnly = true;
            this.txtBoxMontoPrestado.Size = new System.Drawing.Size(213, 21);
            this.txtBoxMontoPrestado.TabIndex = 1;
            // 
            // txtBoxMontoDeuda
            // 
            this.txtBoxMontoDeuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxMontoDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMontoDeuda.Location = new System.Drawing.Point(175, 53);
            this.txtBoxMontoDeuda.Name = "txtBoxMontoDeuda";
            this.txtBoxMontoDeuda.ReadOnly = true;
            this.txtBoxMontoDeuda.Size = new System.Drawing.Size(225, 21);
            this.txtBoxMontoDeuda.TabIndex = 1;
            // 
            // txtBoxMontoTotal
            // 
            this.txtBoxMontoTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMontoTotal.Location = new System.Drawing.Point(175, 27);
            this.txtBoxMontoTotal.Name = "txtBoxMontoTotal";
            this.txtBoxMontoTotal.ReadOnly = true;
            this.txtBoxMontoTotal.Size = new System.Drawing.Size(225, 21);
            this.txtBoxMontoTotal.TabIndex = 1;
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTarjetas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvTarjetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarjetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarjetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTarjetas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarjetas.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTarjetas.EnableHeadersVisualStyles = false;
            this.dgvTarjetas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 30);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarjetas.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTarjetas.Size = new System.Drawing.Size(932, 210);
            this.dgvTarjetas.TabIndex = 9;
            this.dgvTarjetas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjetas_CellDoubleClick);
            this.dgvTarjetas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTarjetas_KeyDown);
            // 
            // txtBoxTipo
            // 
            this.txtBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTipo.Location = new System.Drawing.Point(622, 303);
            this.txtBoxTipo.Name = "txtBoxTipo";
            this.txtBoxTipo.ReadOnly = true;
            this.txtBoxTipo.Size = new System.Drawing.Size(149, 22);
            this.txtBoxTipo.TabIndex = 64;
            this.txtBoxTipo.Text = "0";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(499, 306);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 16);
            this.lblTipo.TabIndex = 75;
            this.lblTipo.Text = "AMORTIZAR:";
            // 
            // FormTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1138, 710);
            this.Controls.Add(label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTarjetas);
            this.Name = "FormTarjetas";
            this.Text = "TARJETAS";
            this.Load += new System.EventHandler(this.FormTarjetas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxEfectivo;
        private System.Windows.Forms.TextBox txtBoxCostoTotal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.TextBox txtBoxBuscarCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxMontoEfectivo;
        private System.Windows.Forms.TextBox txtBoxMontoPrestado;
        private System.Windows.Forms.TextBox txtBoxMontoDeuda;
        private System.Windows.Forms.TextBox txtBoxMontoTotal;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.TextBox txtBoxCapital;
        private System.Windows.Forms.Button btnListarVentas;
        private System.Windows.Forms.TextBox txtBoxTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}