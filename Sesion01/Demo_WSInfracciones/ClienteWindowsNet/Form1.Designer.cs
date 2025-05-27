namespace ClienteWindowsNet
{
    partial class Form1
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
            txtNumPlaca = new TextBox();
            btnConsultar = new Button();
            label2 = new Label();
            lblPropietario = new Label();
            label3 = new Label();
            lblMulta = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese placa:";
            // 
            // txtNumPlaca
            // 
            txtNumPlaca.Location = new Point(99, 54);
            txtNumPlaca.Name = "txtNumPlaca";
            txtNumPlaca.Size = new Size(211, 23);
            txtNumPlaca.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(327, 54);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 111);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Propietario:";
            // 
            // lblPropietario
            // 
            lblPropietario.BorderStyle = BorderStyle.FixedSingle;
            lblPropietario.Location = new Point(173, 107);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(331, 23);
            lblPropietario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 149);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Multa:";
            // 
            // lblMulta
            // 
            lblMulta.BorderStyle = BorderStyle.FixedSingle;
            lblMulta.Location = new Point(173, 146);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(165, 22);
            lblMulta.TabIndex = 3;
            lblMulta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 216);
            Controls.Add(lblMulta);
            Controls.Add(label3);
            Controls.Add(lblPropietario);
            Controls.Add(label2);
            Controls.Add(btnConsultar);
            Controls.Add(txtNumPlaca);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de la Multa de un vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumPlaca;
        private Button btnConsultar;
        private Label label2;
        private Label lblPropietario;
        private Label label3;
        private Label lblMulta;
    }
}
