using Controlador;
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
    public partial class FormDetalles : Form 
    {
        private Articulo articulo;
        public FormDetalles(Articulo articulo_actual)
        {
            InitializeComponent();
            this.articulo = articulo_actual;
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            Helper.CargarImagenPbo(pboImagenDetalles, articulo.Imagen);
            lblIdResultado.Text = articulo.Id.ToString();
            lblCodigoResultado.Text = articulo.CodigoArticulo;
            lblNombreResultado.Text = articulo.Nombre;
            lblDescripcionResultado.Text = articulo.Descripcion;
            lblMarcaDescripcionResultado.Text = articulo.Marca.Descripcion;
            lblMarcaIdResultado.Text = articulo.Marca.Id.ToString();
            lblCategoriaDescripcionResultado.Text = articulo.Categoria.Descripcion;
            lblCategoriaIdResultado.Text = articulo.Categoria.Id.ToString();
            lblPrecioResultado.Text = articulo.Precio.ToString();
        }
    }
}
