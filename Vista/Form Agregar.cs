using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;
using System.Configuration;

namespace Vista
{
    public partial class FormAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog imagen = null;
        private bool recargar_dgv = false;
        public FormAgregar()
        {
            InitializeComponent();
        }
        public FormAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        public bool ActualizarDGV()
        {
            return recargar_dgv;
        }
        private void FormAgregar_Load(object sender, EventArgs e)
        {
            Helper.AgregarItemsComboBoxes(cboMarca, cboCategoria);
            Helper.CargarImagenPbo(pboImagenAgregar, txtUrlImagen.Text);
            if (articulo != null)
            {
                txtCodigo.Text = articulo.CodigoArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.SelectedValue = articulo.Marca.Id;
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedValue = articulo.Categoria.Id;
                txtUrlImagen.Text = articulo.Imagen;
                txtPrecio.Text = articulo.Precio.ToString();
                Helper.CargarImagenPbo(pboImagenAgregar, articulo.Imagen);
            }
        }
        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            Helper.CargarImagenPbo(pboImagenAgregar, txtUrlImagen.Text);
        } 
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números, una coma y el carácter de control (como retroceso o delete)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }

            // Evita que se ingrese más de una coma
            if (e.KeyChar == ',' && txtPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }

            // Evita cualquier carácter de control innecesario
            if (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            imagen = new OpenFileDialog();
            imagen.Filter = "jpg|*.jpg;|png|*.png";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = imagen.FileName;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo_negocio = new ArticuloNegocio();
            try
            {
                if (ValidarEntradas())
                    return;
                if (articulo == null)
                    articulo = new Articulo();
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Imagen = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                if (imagen != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    string ruta_carpeta = ConfigurationManager.AppSettings["images-folder"];
                    string nombre_imagen = imagen.SafeFileName;
                    string destino = Path.Combine(ruta_carpeta, nombre_imagen);
                    int contador = 1;
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(nombre_imagen);
                    string extension = Path.GetExtension(nombre_imagen);
                    while (File.Exists(destino))
                    {
                        string tempFileName = $"{fileNameWithoutExtension}({contador}){extension}";
                        destino = Path.Combine(ruta_carpeta, tempFileName);
                        contador++;
                    }
                    File.Copy(imagen.FileName, destino);
                    articulo.Imagen = destino;
                }
                if (articulo.Id != 0)
                {
                    articulo_negocio.ModificarArticulo(articulo);
                    Helper.ResultadoCarga(true, "La modificacion del artículo fue exitosa.");
                    recargar_dgv = true;
                }
                else
                {
                    articulo_negocio.AgregarArticulo(articulo);
                    Helper.ResultadoCarga(true, "La carga del artículo fue exitosa.");
                    recargar_dgv = true;
                }
                Close();
            }
            catch (Exception)
            {
                Helper.ResultadoCarga(false, "Ha ocurrido un error. Por favor, inténtalo de nuevo.");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidarEntradas()
        {
            if (txtCodigo.Text == "")
            {
                Helper.Advertencia("El campo CODIGO es requerido.", "Advertencia");
                return true;
            }
            else if (txtNombre.Text == "")
            {
                Helper.Advertencia("El campo NOMBRE es requerido.", "Advertencia");
                return true;
            }
            else if (txtPrecio.Text == "" || txtPrecio.Text == ",")
            {
                Helper.Advertencia("El campo PRECIO es requerido.", "Advertencia");
                return true;
            }
            else
                return false;

        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
