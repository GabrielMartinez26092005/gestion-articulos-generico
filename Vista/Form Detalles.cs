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
            lblId.Text = "ID: " + articulo.Id;
            lblCodigo.Text = "CODIGO: " + articulo.CodigoArticulo;
            lblNombre.Text = "NOMBRE: " + articulo.Nombre;
            lblDescripcion.Text = "DESCRIPCION: " + articulo.Descripcion;
            lblMarcaDescripcion.Text = "MARCA: " + articulo.Marca;
            lblMarcaId.Text = "MARCA ID: " + articulo.Marca.Id;
            lblCategoriaDescripcion.Text = "CATEGORIA: " + articulo.Categoria;
            lblCategoriaId.Text = "CATEGORIA ID: " + articulo.Categoria.Id;
            lblPrecio.Text = "PRECIO: $" + articulo.Precio;
        }
    }
}
