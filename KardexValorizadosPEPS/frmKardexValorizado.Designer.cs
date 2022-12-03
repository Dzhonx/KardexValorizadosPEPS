
namespace KardexValorizadosPEPS
{
    partial class frmKardexValorizado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMovimiento = new System.Windows.Forms.ComboBox();
            this.lblTituloCabecera = new System.Windows.Forms.Label();
            this.pMantenimiento = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.pDetalle = new System.Windows.Forms.Panel();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntradaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntradaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntradaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalidaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalidaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalidaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldosCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldosValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldosTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pMantenimiento.SuspendLayout();
            this.pDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMovimiento
            // 
            this.cboMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovimiento.FormattingEnabled = true;
            this.cboMovimiento.Items.AddRange(new object[] {
            "Compra",
            "Venta"});
            this.cboMovimiento.Location = new System.Drawing.Point(25, 34);
            this.cboMovimiento.Name = "cboMovimiento";
            this.cboMovimiento.Size = new System.Drawing.Size(150, 21);
            this.cboMovimiento.TabIndex = 0;
            // 
            // lblTituloCabecera
            // 
            this.lblTituloCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCabecera.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCabecera.Location = new System.Drawing.Point(0, 0);
            this.lblTituloCabecera.Name = "lblTituloCabecera";
            this.lblTituloCabecera.Size = new System.Drawing.Size(941, 60);
            this.lblTituloCabecera.TabIndex = 1;
            this.lblTituloCabecera.Text = "KARDEX VALORIZADO - METODO PEPS";
            this.lblTituloCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMantenimiento
            // 
            this.pMantenimiento.Controls.Add(this.btnSalir);
            this.pMantenimiento.Controls.Add(this.btnRegistrar);
            this.pMantenimiento.Controls.Add(this.txtTotal);
            this.pMantenimiento.Controls.Add(this.lblTotal);
            this.pMantenimiento.Controls.Add(this.txtValor);
            this.pMantenimiento.Controls.Add(this.lblValorUnitario);
            this.pMantenimiento.Controls.Add(this.txtCantidad);
            this.pMantenimiento.Controls.Add(this.lblCantidad);
            this.pMantenimiento.Controls.Add(this.dtpFecha);
            this.pMantenimiento.Controls.Add(this.lblFecha);
            this.pMantenimiento.Controls.Add(this.lblConcepto);
            this.pMantenimiento.Controls.Add(this.cboMovimiento);
            this.pMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMantenimiento.Location = new System.Drawing.Point(0, 60);
            this.pMantenimiento.Name = "pMantenimiento";
            this.pMantenimiento.Size = new System.Drawing.Size(941, 125);
            this.pMantenimiento.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(778, 66);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 50);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(778, 9);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 50);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(357, 91);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 22);
            this.txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(357, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(191, 91);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 22);
            this.txtValor.TabIndex = 7;
            this.txtValor.Text = "0";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.Location = new System.Drawing.Point(191, 68);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.lblValorUnitario.TabIndex = 6;
            this.lblValorUnitario.Text = "Valor unitario";
            this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(25, 91);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 22);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(25, 68);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(191, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(191, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConcepto
            // 
            this.lblConcepto.Location = new System.Drawing.Point(25, 11);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(100, 20);
            this.lblConcepto.TabIndex = 1;
            this.lblConcepto.Text = "Concepto";
            this.lblConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pDetalle
            // 
            this.pDetalle.Controls.Add(this.dgvListado);
            this.pDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetalle.Location = new System.Drawing.Point(0, 185);
            this.pDetalle.Name = "pDetalle";
            this.pDetalle.Size = new System.Drawing.Size(941, 229);
            this.pDetalle.TabIndex = 3;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeColumns = false;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvListado.ColumnHeadersHeight = 40;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colConcepto,
            this.colEntradaCantidad,
            this.colEntradaValorUnitario,
            this.colEntradaTotal,
            this.colSalidaCantidad,
            this.colSalidaValorUnitario,
            this.colSalidaTotal,
            this.colSaldosCantidad,
            this.colSaldosValorUnitario,
            this.colSaldosTotal,
            this.colDisponible});
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(0, 0);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(941, 229);
            this.dgvListado.TabIndex = 0;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 62;
            // 
            // colConcepto
            // 
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            this.colConcepto.Width = 82;
            // 
            // colEntradaCantidad
            // 
            this.colEntradaCantidad.HeaderText = "E. Cantidad";
            this.colEntradaCantidad.Name = "colEntradaCantidad";
            this.colEntradaCantidad.ReadOnly = true;
            this.colEntradaCantidad.Width = 84;
            // 
            // colEntradaValorUnitario
            // 
            this.colEntradaValorUnitario.HeaderText = "E. V. Unitario";
            this.colEntradaValorUnitario.Name = "colEntradaValorUnitario";
            this.colEntradaValorUnitario.ReadOnly = true;
            this.colEntradaValorUnitario.Width = 91;
            // 
            // colEntradaTotal
            // 
            this.colEntradaTotal.HeaderText = "E. Total";
            this.colEntradaTotal.Name = "colEntradaTotal";
            this.colEntradaTotal.ReadOnly = true;
            this.colEntradaTotal.Width = 64;
            // 
            // colSalidaCantidad
            // 
            this.colSalidaCantidad.HeaderText = "S. Cantidad";
            this.colSalidaCantidad.Name = "colSalidaCantidad";
            this.colSalidaCantidad.ReadOnly = true;
            this.colSalidaCantidad.Width = 84;
            // 
            // colSalidaValorUnitario
            // 
            this.colSalidaValorUnitario.HeaderText = "S. V. Unitario";
            this.colSalidaValorUnitario.Name = "colSalidaValorUnitario";
            this.colSalidaValorUnitario.ReadOnly = true;
            this.colSalidaValorUnitario.Width = 91;
            // 
            // colSalidaTotal
            // 
            this.colSalidaTotal.HeaderText = "S. Total";
            this.colSalidaTotal.Name = "colSalidaTotal";
            this.colSalidaTotal.ReadOnly = true;
            this.colSalidaTotal.Width = 64;
            // 
            // colSaldosCantidad
            // 
            this.colSaldosCantidad.HeaderText = "Sal. Cantidad";
            this.colSaldosCantidad.Name = "colSaldosCantidad";
            this.colSaldosCantidad.ReadOnly = true;
            this.colSaldosCantidad.Width = 92;
            // 
            // colSaldosValorUnitario
            // 
            this.colSaldosValorUnitario.HeaderText = "Sal. V. Unitario";
            this.colSaldosValorUnitario.Name = "colSaldosValorUnitario";
            this.colSaldosValorUnitario.ReadOnly = true;
            this.colSaldosValorUnitario.Width = 99;
            // 
            // colSaldosTotal
            // 
            this.colSaldosTotal.HeaderText = "Sal. Total";
            this.colSaldosTotal.Name = "colSaldosTotal";
            this.colSaldosTotal.ReadOnly = true;
            this.colSaldosTotal.Width = 72;
            // 
            // colDisponible
            // 
            this.colDisponible.HeaderText = "Disponible";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.ReadOnly = true;
            this.colDisponible.Width = 88;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtTotalVentas);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.lblTotalVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 54);
            this.panel1.TabIndex = 4;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.Location = new System.Drawing.Point(248, 17);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(100, 20);
            this.lblTotalVentas.TabIndex = 9;
            this.lblTotalVentas.Text = "Total ventas (S/.)";
            this.lblTotalVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(473, 17);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(100, 20);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Total stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Location = new System.Drawing.Point(354, 16);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(113, 22);
            this.txtTotalVentas.TabIndex = 11;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(579, 16);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(113, 22);
            this.txtStock.TabIndex = 12;
            // 
            // frmKardexValorizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 468);
            this.Controls.Add(this.pDetalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pMantenimiento);
            this.Controls.Add(this.lblTituloCabecera);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKardexValorizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex Valorizado - PEPS";
            this.Load += new System.EventHandler(this.frmKardexValorizado_Load);
            this.pMantenimiento.ResumeLayout(false);
            this.pMantenimiento.PerformLayout();
            this.pDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMovimiento;
        private System.Windows.Forms.Label lblTituloCabecera;
        private System.Windows.Forms.Panel pMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pDetalle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntradaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntradaValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntradaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalidaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalidaValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalidaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldosCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldosValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldosTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponible;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotalVentas;
    }
}

