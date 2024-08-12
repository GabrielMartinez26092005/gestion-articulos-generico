using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Vista
{
    public partial class FormModificar : Form
    {
        private Articulo articulo_seleccionado;
        private Articulo articulo_modificado = new Articulo();
        public FormModificar(Articulo articulo_seleccionado)
        {
            InitializeComponent();
            this.articulo_seleccionado = articulo_seleccionado;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = articulo_seleccionado.CodigoArticulo;
            txtNombre.Text = articulo_seleccionado.Nombre;
            txtDescripcion.Text = articulo_seleccionado.Descripcion;
            txtUrlImagen.Text = articulo_seleccionado.Imagen;
            txtUrlImagen.Text = articulo_seleccionado.Imagen;
            txtPrecio.Text = articulo_seleccionado.Precio.ToString();
            Helper.AgregarItemsComboBoxes(cboMarca, cboCategoria);
            Helper.CargarImagenPbo(pboImagenModificar, articulo_seleccionado.Imagen);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                articulo_modificado.Id = articulo_seleccionado.Id;
                articulo_modificado.CodigoArticulo = txtCodigo.Text;
                articulo_modificado.Nombre = txtNombre.Text;
                articulo_modificado.Descripcion = txtDescripcion.Text;
                articulo_modificado.Imagen = txtUrlImagen.Text;
                articulo_modificado.Precio = decimal.Parse(txtPrecio.Text);
                if (Helper.ValidarComboBoxes(cboMarca, cboCategoria))
                    return;
                articulo_modificado.Marca.Id = Helper.DevolverIdMarca(cboMarca);
                articulo_modificado.Categoria.Id = Helper.DevolverIdCategoria(cboCategoria);
                ArticuloNegocio articulo_negocio = new ArticuloNegocio();
                articulo_negocio.ModificarArticulo(articulo_modificado);
                Helper.ResultadoCarga(true, "La modificacion del articulo fue exitosa.");
            }
            catch (Exception)
            {
                Helper.ResultadoCarga(false, "La carga del artículo no fue exitosa.Por favor, inténtalo de nuevo.");
            }
        }
        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            Helper.CargarImagenPbo(pboImagenModificar, txtUrlImagen.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
