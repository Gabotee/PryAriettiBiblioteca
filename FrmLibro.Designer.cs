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
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoDistribuidor = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoEditorial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoDistribuidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(32, 258);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 1;
            this.cmdAtras.Text = "Atras";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(181, 258);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 2;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(113, 294);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 45);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre ";
            // 
            // lblCodigoDistribuidor
            // 
            this.lblCodigoDistribuidor.AutoSize = true;
            this.lblCodigoDistribuidor.Location = new System.Drawing.Point(12, 177);
            this.lblCodigoDistribuidor.Name = "lblCodigoDistribuidor";
            this.lblCodigoDistribuidor.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoDistribuidor.TabIndex = 7;
            this.lblCodigoDistribuidor.Text = "Codigo Distribuidor";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Location = new System.Drawing.Point(12, 111);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(80, 13);
            this.lblCodigoEditorial.TabIndex = 6;
            this.lblCodigoEditorial.Text = "Codigo Editorial";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Location = new System.Drawing.Point(12, 144);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(71, 13);
            this.lblCodigoAutor.TabIndex = 8;
            this.lblCodigoAutor.Text = "Codigo Autor ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtCodigoEditorial
            // 
            this.txtCodigoEditorial.Location = new System.Drawing.Point(113, 111);
            this.txtCodigoEditorial.Name = "txtCodigoEditorial";
            this.txtCodigoEditorial.Size = new System.Drawing.Size(143, 20);
            this.txtCodigoEditorial.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Location = new System.Drawing.Point(113, 144);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(143, 20);
            this.txtCodigoAutor.TabIndex = 12;
            // 
            // txtCodigoDistribuidor
            // 
            this.txtCodigoDistribuidor.Location = new System.Drawing.Point(113, 177);
            this.txtCodigoDistribuidor.Name = "txtCodigoDistribuidor";
            this.txtCodigoDistribuidor.Size = new System.Drawing.Size(143, 20);
            this.txtCodigoDistribuidor.TabIndex = 13;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 341);
            this.Controls.Add(this.txtCodigoDistribuidor);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoEditorial);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoDistribuidor);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAtras);
            this.Name = "FrmLibro";
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoDistribuidor;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoEditorial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigoDistribuidor;
    }
}