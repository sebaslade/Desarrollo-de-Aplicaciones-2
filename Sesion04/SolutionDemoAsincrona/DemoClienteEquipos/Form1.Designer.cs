namespace DemoClienteEquipos
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
            lista1 = new ListBox();
            lista2 = new ListBox();
            btnSincrono = new Button();
            btnAsincrono = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lista1
            // 
            lista1.FormattingEnabled = true;
            lista1.ItemHeight = 15;
            lista1.Location = new Point(40, 36);
            lista1.Name = "lista1";
            lista1.Size = new Size(184, 319);
            lista1.TabIndex = 0;
            // 
            // lista2
            // 
            lista2.FormattingEnabled = true;
            lista2.ItemHeight = 15;
            lista2.Location = new Point(266, 36);
            lista2.Name = "lista2";
            lista2.Size = new Size(187, 319);
            lista2.TabIndex = 1;
            // 
            // btnSincrono
            // 
            btnSincrono.Location = new Point(579, 56);
            btnSincrono.Name = "btnSincrono";
            btnSincrono.Size = new Size(115, 39);
            btnSincrono.TabIndex = 2;
            btnSincrono.Text = "Sincrono";
            btnSincrono.UseVisualStyleBackColor = true;
            btnSincrono.Click += btnSincrono_Click;
            // 
            // btnAsincrono
            // 
            btnAsincrono.Location = new Point(579, 101);
            btnAsincrono.Name = "btnAsincrono";
            btnAsincrono.Size = new Size(115, 39);
            btnAsincrono.TabIndex = 2;
            btnAsincrono.Text = "Asincrono";
            btnAsincrono.UseVisualStyleBackColor = true;
            btnAsincrono.Click += btnAsincrono_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(579, 147);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 39);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 405);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAsincrono);
            Controls.Add(btnSincrono);
            Controls.Add(lista2);
            Controls.Add(lista1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consumiendo servicios Asincronos y Sincronos";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lista1;
        private ListBox lista2;
        private Button btnSincrono;
        private Button btnAsincrono;
        private Button btnLimpiar;
    }
}
