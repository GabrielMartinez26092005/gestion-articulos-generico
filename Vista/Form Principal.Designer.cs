namespace Vista
{
    partial class FormPrincipal
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pboImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.lblFiltrarNombre = new System.Windows.Forms.Label();
            this.txtFiltrarNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(536, 251);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 51);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(599, 194);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pboImagenPrincipal
            // 
            this.pboImagenPrincipal.Location = new System.Drawing.Point(617, 51);
            this.pboImagenPrincipal.Name = "pboImagenPrincipal";
            this.pboImagenPrincipal.Size = new System.Drawing.Size(164, 194);
            this.pboImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboImagenPrincipal.TabIndex = 10;
            this.pboImagenPrincipal.TabStop = false;
            // 
            // lblFiltrarNombre
            // 
            this.lblFiltrarNombre.AutoSize = true;
            this.lblFiltrarNombre.Location = new System.Drawing.Point(12, 28);
            this.lblFiltrarNombre.Name = "lblFiltrarNombre";
            this.lblFiltrarNombre.Size = new System.Drawing.Size(75, 13);
            this.lblFiltrarNombre.TabIndex = 3;
            this.lblFiltrarNombre.Text = "Filtrar Nombre:";
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.Location = new System.Drawing.Point(87, 25);
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.Size = new System.Drawing.Size(167, 20);
            this.txtFiltrarNombre.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(490, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(293, 251);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalles.TabIndex = 6;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(374, 251);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(455, 251);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(363, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 293);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.lblFiltrarNombre);
            this.Controls.Add(this.pboImagenPrincipal);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Name = "FormPrincipal";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pboImagenPrincipal;
        private System.Windows.Forms.Label lblFiltrarNombre;
        private System.Windows.Forms.TextBox txtFiltrarNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

