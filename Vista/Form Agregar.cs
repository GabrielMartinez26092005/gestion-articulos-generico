using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAgregar : Form
    {
        private Articulo nuevo_articulo = new Articulo();
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            AgregarItemsComboBoxes();
        }
        private void AgregarItemsComboBoxes()
        {
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");
            cboMarca.Items.Add("Motorola");

            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Televisores");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Audio");
        }
        private bool ValidarComboBoxes()
        {
            try
            {
                if (cboMarca.SelectedItem == null)
                {
                    MessageBox.Show("El campo MARCA es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else if (cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("El campo CATEGORIA es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    switch (cboMarca.SelectedIndex)
                    {
                        case 0: // Samsung
                            nuevo_articulo.Marca.Id = 1;
                            break;
                        case 1: // Apple
                            nuevo_articulo.Marca.Id = 2;
                            break;
                        case 2: // Sony
                            nuevo_articulo.Marca.Id = 3;
                            break;
                        case 3: // Huawei
                            nuevo_articulo.Marca.Id = 4;
                            break;
                        default: // Motorola
                            nuevo_articulo.Marca.Id = 5;
                            break;
                    }
                    switch (cboCategoria.SelectedIndex)
                    {
                        case 0: // Celulares
                            nuevo_articulo.Categoria.Id = 1;
                            break;
                        case 1: // Televisores
                            nuevo_articulo.Categoria.Id = 2;
                            break;
                        case 2: // Media
                            nuevo_articulo.Categoria.Id = 3;
                            break;
                        default: // Audio
                            nuevo_articulo.Marca.Id = 4;
                            break;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                nuevo_articulo.CodigoArticulo = txtCodigo.Text;
                nuevo_articulo.Nombre = txtNombre.Text;
                nuevo_articulo.Descripcion = txtDescripcion.Text;
                nuevo_articulo.Imagen = txtUrlImagen.Text;
                nuevo_articulo.Precio = decimal.Parse(txtPrecio.Text);
                if (ValidarComboBoxes())
                    return;
                ArticuloNegocio articulo_negocio = new ArticuloNegocio();
                articulo_negocio.AgregarArticulo(nuevo_articulo);
                CargaExitosa(true);
            }
            catch (Exception)
            {
                CargaExitosa(false);
            }
        }
        public void CargaExitosa(bool respuesta)
        {
            if (respuesta)
                MessageBox.Show("Carga del artículo exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("La carga del artículo no fue exitosa. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
