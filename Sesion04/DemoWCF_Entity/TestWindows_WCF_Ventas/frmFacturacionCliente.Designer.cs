namespace TestWindows_WCF_Ventas
{
    partial class frmFacturacionCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCod = new TextBox();
            label2 = new Label();
            dtpFecIni = new DateTimePicker();
            label3 = new Label();
            dtpFecFin = new DateTimePicker();
            btnConsultar = new Button();
            label4 = new Label();
            lblRS = new Label();
            label6 = new Label();
            lblRUC = new Label();
            label8 = new Label();
            lblDir = new Label();
            label10 = new Label();
            lblUbigeo = new Label();
            label12 = new Label();
            lblDeuda = new Label();
            dtgFacturas = new DataGridView();
            label14 = new Label();
            lblRegistros = new Label();
            Num_fac = new DataGridViewTextBoxColumn();
            Fec_fac = new DataGridViewTextBoxColumn();
            Fec_can = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Cod_ven = new DataGridViewTextBoxColumn();
            ApellNom_ven = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(112, 21);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 29);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "F.Inicio:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(327, 24);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(131, 23);
            dtpFecIni.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 28);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "F.Fin:";
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(557, 23);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(131, 23);
            dtpFecFin.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(761, 26);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(140, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 77);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Razon social:";
            // 
            // lblRS
            // 
            lblRS.BorderStyle = BorderStyle.FixedSingle;
            lblRS.Location = new Point(112, 77);
            lblRS.Name = "lblRS";
            lblRS.Size = new Size(361, 26);
            lblRS.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 77);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 4;
            label6.Text = "RUC:";
            // 
            // lblRUC
            // 
            lblRUC.BorderStyle = BorderStyle.FixedSingle;
            lblRUC.Location = new Point(557, 77);
            lblRUC.Name = "lblRUC";
            lblRUC.Size = new Size(194, 26);
            lblRUC.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 122);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 4;
            label8.Text = "Direccion:";
            // 
            // lblDir
            // 
            lblDir.BorderStyle = BorderStyle.FixedSingle;
            lblDir.Location = new Point(112, 122);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(361, 26);
            lblDir.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 122);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 4;
            label10.Text = "Ubicacion:";
            // 
            // lblUbigeo
            // 
            lblUbigeo.BorderStyle = BorderStyle.FixedSingle;
            lblUbigeo.Location = new Point(557, 122);
            lblUbigeo.Name = "lblUbigeo";
            lblUbigeo.Size = new Size(420, 26);
            lblUbigeo.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 168);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 4;
            label12.Text = "Deuda:";
            // 
            // lblDeuda
            // 
            lblDeuda.BorderStyle = BorderStyle.FixedSingle;
            lblDeuda.Location = new Point(112, 168);
            lblDeuda.Name = "lblDeuda";
            lblDeuda.Size = new Size(163, 26);
            lblDeuda.TabIndex = 4;
            lblDeuda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgFacturas
            // 
            dtgFacturas.AllowUserToAddRows = false;
            dtgFacturas.AllowUserToDeleteRows = false;
            dtgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFacturas.Columns.AddRange(new DataGridViewColumn[] { Num_fac, Fec_fac, Fec_can, Estado, Total, Cod_ven, ApellNom_ven });
            dtgFacturas.Location = new Point(12, 208);
            dtgFacturas.Name = "dtgFacturas";
            dtgFacturas.ReadOnly = true;
            dtgFacturas.RowHeadersVisible = false;
            dtgFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFacturas.Size = new Size(954, 230);
            dtgFacturas.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(775, 447);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 4;
            label14.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(868, 446);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 26);
            lblRegistros.TabIndex = 4;
            // 
            // Num_fac
            // 
            Num_fac.DataPropertyName = "Num_Fac";
            Num_fac.HeaderText = "Nro. factura";
            Num_fac.Name = "Num_fac";
            Num_fac.ReadOnly = true;
            // 
            // Fec_fac
            // 
            Fec_fac.DataPropertyName = "Fecha_Fac";
            Fec_fac.HeaderText = "Fecha facturacion";
            Fec_fac.Name = "Fec_fac";
            Fec_fac.ReadOnly = true;
            // 
            // Fec_can
            // 
            Fec_can.DataPropertyName = "Fecha_Can";
            Fec_can.HeaderText = "Fecha cancelacion";
            Fec_can.Name = "Fec_can";
            Fec_can.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Est_Des";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total (S/.)";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Cod_ven
            // 
            Cod_ven.DataPropertyName = "Cod_Ven";
            Cod_ven.HeaderText = "Cod. vendedor";
            Cod_ven.Name = "Cod_ven";
            Cod_ven.ReadOnly = true;
            // 
            // ApellNom_ven
            // 
            ApellNom_ven.DataPropertyName = "ApeNom_Ven";
            ApellNom_ven.HeaderText = "Apellidos y nombres vendedor";
            ApellNom_ven.Name = "ApellNom_ven";
            ApellNom_ven.ReadOnly = true;
            // 
            // frmFacturacionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 492);
            Controls.Add(dtgFacturas);
            Controls.Add(lblUbigeo);
            Controls.Add(label10);
            Controls.Add(lblRUC);
            Controls.Add(lblRegistros);
            Controls.Add(lblDeuda);
            Controls.Add(label14);
            Controls.Add(lblDir);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(lblRS);
            Controls.Add(label4);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFecFin);
            Controls.Add(dtpFecIni);
            Controls.Add(label3);
            Controls.Add(txtCod);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFacturacionCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Servicios Cliente Factura";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCod;
        private Label label2;
        private DateTimePicker dtpFecIni;
        private Label label3;
        private DateTimePicker dtpFecFin;
        private Button btnConsultar;
        private Label label4;
        private Label lblRS;
        private Label label6;
        private Label lblRUC;
        private Label label8;
        private Label lblDir;
        private Label label10;
        private Label lblUbigeo;
        private Label label12;
        private Label lblDeuda;
        private DataGridView dtgFacturas;
        private Label label14;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Num_fac;
        private DataGridViewTextBoxColumn Fec_fac;
        private DataGridViewTextBoxColumn Fec_can;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Cod_ven;
        private DataGridViewTextBoxColumn ApellNom_ven;
    }
}