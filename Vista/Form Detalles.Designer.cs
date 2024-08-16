namespace Vista
{
    partial class FormDetalles
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
            this.pboImagenDetalles = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarcaDescripcion = new System.Windows.Forms.Label();
            this.lblCategoriaDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoriaId = new System.Windows.Forms.Label();
            this.lblMarcaId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // pboImagenDetalles
            // 
            this.pboImagenDetalles.Location = new System.Drawing.Point(386, 30);
            this.pboImagenDetalles.Name = "pboImagenDetalles";
            this.pboImagenDetalles.Size = new System.Drawing.Size(359, 322);
            this.pboImagenDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboImagenDetalles.TabIndex = 1;
            this.pboImagenDetalles.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 155);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "DESCRIPCION:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblMarcaDescripcion
            // 
            this.lblMarcaDescripcion.AutoSize = true;
            this.lblMarcaDescripcion.Location = new System.Drawing.Point(12, 257);
            this.lblMarcaDescripcion.Name = "lblMarcaDescripcion";
            this.lblMarcaDescripcion.Size = new System.Drawing.Size(48, 13);
            this.lblMarcaDescripcion.TabIndex = 6;
            this.lblMarcaDescripcion.Text = "MARCA:";
            // 
            // lblCategoriaDescripcion
            // 
            this.lblCategoriaDescripcion.AutoSize = true;
            this.lblCategoriaDescripcion.Location = new System.Drawing.Point(12, 206);
            this.lblCategoriaDescripcion.Name = "lblCategoriaDescripcion";
            this.lblCategoriaDescripcion.Size = new System.Drawing.Size(72, 13);
            this.lblCategoriaDescripcion.TabIndex = 7;
            this.lblCategoriaDescripcion.Text = "CATEGORIA:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 308);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblCategoriaId
            // 
            this.lblCategoriaId.AutoSize = true;
            this.lblCategoriaId.Location = new System.Drawing.Point(12, 219);
            this.lblCategoriaId.Name = "lblCategoriaId";
            this.lblCategoriaId.Size = new System.Drawing.Size(86, 13);
            this.lblCategoriaId.TabIndex = 9;
            this.lblCategoriaId.Text = "CATEGORIA ID:";
            // 
            // lblMarcaId
            // 
            this.lblMarcaId.AutoSize = true;
            this.lblMarcaId.Location = new System.Drawing.Point(12, 270);
            this.lblMarcaId.Name = "lblMarcaId";
            this.lblMarcaId.Size = new System.Drawing.Size(62, 13);
            this.lblMarcaId.TabIndex = 10;
            this.lblMarcaId.Text = "MARCA ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID:";
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 380);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMarcaId);
            this.Controls.Add(this.lblCategoriaId);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoriaDescripcion);
            this.Controls.Add(this.lblMarcaDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pboImagenDetalles);
            this.Name = "FormDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.Detalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboImagenDetalles;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarcaDescripcion;
        private System.Windows.Forms.Label lblCategoriaDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoriaId;
        private System.Windows.Forms.Label lblMarcaId;
        private System.Windows.Forms.Label lblId;
    }
}