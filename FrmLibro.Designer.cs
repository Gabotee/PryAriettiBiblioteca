namespace PryAriettiBiblioteca
{
    partial class FrmLibro
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
            this.lstMostrarLibro = new System.Windows.Forms.ListBox();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMostrarLibro
            // 
            this.lstMostrarLibro.FormattingEnabled = true;
            this.lstMostrarLibro.Location = new System.Drawing.Point(12, 12);
            this.lstMostrarLibro.Name = "lstMostrarLibro";
            this.lstMostrarLibro.Size = new System.Drawing.Size(352, 420);
            this.lstMostrarLibro.TabIndex = 0;
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(368, 41);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 1;
            this.cmdAtras.Text = "Atras";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(368, 12);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 2;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(370, 70);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 439);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.lstMostrarLibro);
            this.Name = "FrmLibro";
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMostrarLibro;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdSalir;
    }
}