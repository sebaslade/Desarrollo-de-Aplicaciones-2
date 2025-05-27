namespace TestWindows_WCF_Ventas
{
    partial class frmFacturacionVendedor
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
            lblFecIngreso = new Label();
            label10 = new Label();
            lblApellido = new Label();
            lblSueldo = new Label();
            lblEmail = new Label();
            label12 = new Label();
            label6 = new Label();
            label8 = new Label();
            lblNombre = new Label();
            label4 = new Label();
            btnConsultar = new Button();
            dtpFecFin = new DateTimePicker();
            dtpFecIni = new DateTimePicker();
            label3 = new Label();
            txtCod = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtgFacturas = new DataGridView();
            lblRegistros = new Label();
            label14 = new Label();
            Num_fac = new DataGridViewTextBoxColumn();
            Fec_fac = new DataGridViewTextBoxColumn();
            Fec_can = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Raz_soc_cli = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).BeginInit();
            SuspendLayout();
            // 
            // lblFecIngreso
            // 
            lblFecIngreso.BorderStyle = BorderStyle.FixedSingle;
            lblFecIngreso.Location = new Point(508, 126);
            lblFecIngreso.Name = "lblFecIngreso";
            lblFecIngreso.Size = new Size(155, 26);
            lblFecIngreso.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(429, 132);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 19;
            label10.Text = "Fe. Ingreso:";
            // 
            // lblApellido
            // 
            lblApellido.BorderStyle = BorderStyle.FixedSingle;
            lblApellido.Location = new Point(429, 83);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(283, 26);
            lblApellido.TabIndex = 18;
            // 
            // lblSueldo
            // 
            lblSueldo.BorderStyle = BorderStyle.FixedSingle;
            lblSueldo.Location = new Point(785, 128);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(163, 26);
            lblSueldo.TabIndex = 17;
            lblSueldo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Location = new Point(97, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(273, 26);
            lblEmail.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(716, 134);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 15;
            label12.Text = "Sueldo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 87);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 14;
            label6.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 133);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 20;
            label8.Text = "Email:";
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(97, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(243, 26);
            lblNombre.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 87);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Nombre:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(746, 32);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(140, 23);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(542, 29);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(131, 23);
            dtpFecFin.TabIndex = 10;
            // 
            // dtpFecIni
            // 
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(312, 30);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(131, 23);
            dtpFecIni.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 34);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "F.Fin:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(97, 27);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 35);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "F.Inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Vendedor:";
            // 
            // dtgFacturas
            // 
            dtgFacturas.AllowUserToAddRows = false;
            dtgFacturas.AllowUserToDeleteRows = false;
            dtgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFacturas.Columns.AddRange(new DataGridViewColumn[] { Num_fac, Fec_fac, Fec_can, Estado, Total, Raz_soc_cli });
            dtgFacturas.Location = new Point(22, 189);
            dtgFacturas.Name = "dtgFacturas";
            dtgFacturas.ReadOnly = true;
            dtgFacturas.RowHeadersVisible = false;
            dtgFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFacturas.Size = new Size(954, 230);
            dtgFacturas.TabIndex = 24;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(878, 433);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 26);
            lblRegistros.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(798, 439);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 23;
            label14.Text = "Registros:";
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
            // Raz_soc_cli
            // 
            Raz_soc_cli.DataPropertyName = "Raz_soc_cli";
            Raz_soc_cli.HeaderText = "Razon Social Cliente";
            Raz_soc_cli.Name = "Raz_soc_cli";
            Raz_soc_cli.ReadOnly = true;
            // 
            // frmFacturacionVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 496);
            Controls.Add(dtgFacturas);
            Controls.Add(lblRegistros);
            Controls.Add(label14);
            Controls.Add(lblFecIngreso);
            Controls.Add(label10);
            Controls.Add(lblApellido);
            Controls.Add(lblSueldo);
            Controls.Add(lblEmail);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(lblNombre);
            Controls.Add(label4);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFecFin);
            Controls.Add(dtpFecIni);
            Controls.Add(label3);
            Controls.Add(txtCod);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFacturacionVendedor";
            Text = "frmFacturacionVendedor";
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecIngreso;
        private Label label10;
        private Label lblApellido;
        private Label lblSueldo;
        private Label lblEmail;
        private Label label12;
        private Label label6;
        private Label label8;
        private Label lblNombre;
        private Label label4;
        private Button btnConsultar;
        private DateTimePicker dtpFecFin;
        private DateTimePicker dtpFecIni;
        private Label label3;
        private TextBox txtCod;
        private Label label2;
        private Label label1;
        private DataGridView dtgFacturas;
        private Label lblRegistros;
        private Label label14;
        private DataGridViewTextBoxColumn Num_fac;
        private DataGridViewTextBoxColumn Fec_fac;
        private DataGridViewTextBoxColumn Fec_can;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Raz_soc_cli;
    }
}