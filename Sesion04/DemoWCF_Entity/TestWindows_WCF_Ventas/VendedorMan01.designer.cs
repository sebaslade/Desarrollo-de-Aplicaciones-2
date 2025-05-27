namespace TestWindows_WCF_Ventas
{
    partial class VendedorMan01
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
            this.dtgVendedor = new System.Windows.Forms.DataGridView();
            this.Cod_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sue_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_ing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVendedor
            // 
            this.dtgVendedor.AllowUserToAddRows = false;
            this.dtgVendedor.AllowUserToDeleteRows = false;
            this.dtgVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_ven,
            this.Nom_ven,
            this.Ape_ven,
            this.Sue_ven,
            this.Fec_ing,
            this.Estado});
            this.dtgVendedor.Location = new System.Drawing.Point(13, 12);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.ReadOnly = true;
            this.dtgVendedor.RowHeadersVisible = false;
            this.dtgVendedor.RowTemplate.Height = 24;
            this.dtgVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVendedor.Size = new System.Drawing.Size(762, 416);
            this.dtgVendedor.TabIndex = 0;
            // 
            // Cod_ven
            // 
            this.Cod_ven.DataPropertyName = "Cod_ven";
            this.Cod_ven.HeaderText = "Codigo";
            this.Cod_ven.Name = "Cod_ven";
            this.Cod_ven.ReadOnly = true;
            // 
            // Nom_ven
            // 
            this.Nom_ven.DataPropertyName = "Nom_ven";
            this.Nom_ven.HeaderText = " Nombres";
            this.Nom_ven.Name = "Nom_ven";
            this.Nom_ven.ReadOnly = true;
            // 
            // Ape_ven
            // 
            this.Ape_ven.DataPropertyName = "Ape_ven";
            this.Ape_ven.HeaderText = "Apellidos";
            this.Ape_ven.Name = "Ape_ven";
            this.Ape_ven.ReadOnly = true;
            // 
            // Sue_ven
            // 
            this.Sue_ven.DataPropertyName = "Sue_ven";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Sue_ven.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sue_ven.HeaderText = "Sueldo (S/.)";
            this.Sue_ven.Name = "Sue_ven";
            this.Sue_ven.ReadOnly = true;
            // 
            // Fec_ing
            // 
            this.Fec_ing.DataPropertyName = "Fec_ing";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fec_ing.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fec_ing.HeaderText = "Fec. Ingreso";
            this.Fec_ing.Name = "Fec_ing";
            this.Fec_ing.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(538, 472);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(619, 472);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(700, 472);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(721, 431);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 23);
            this.lblRegistros.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registros:";
            // 
            // VendedorMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 507);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgVendedor);
            this.Name = "VendedorMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Vendedores";
            this.Load += new System.EventHandler(this.VendedorMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVendedor;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sue_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_ing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}