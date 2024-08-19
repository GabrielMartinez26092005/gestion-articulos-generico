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
        private Articulo articulo = null;    
        public FormAgregar()
        {
            InitializeComponent();
        }
        public FormAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo; 
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo_negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Imagen = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    articulo_negocio.ModificarArticulo(articulo);
                    Helper.ResultadoCarga(true, "La modificacion del artículo fue exitosa.");
                    Close();
                }
                else
                {
                    articulo_negocio.AgregarArticulo(articulo);
                    Helper.ResultadoCarga(true, "La carga del artículo fue exitosa.");
                    Close();
                }
            }
            catch (Exception)
            {
                Helper.ResultadoCarga(false, "Ha ocurrido un error. Por favor, inténtalo de nuevo.");
            }
        }
        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            Helper.CargarImagenPbo(pboImagenAgregar, txtUrlImagen.Text);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
