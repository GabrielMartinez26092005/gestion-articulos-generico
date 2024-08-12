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
            CargarImagen(articulo.Imagen);
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
        public void CargarImagen(string imagen)
        {
            try
            {
                pboImagenDetalles.Load(imagen);
            }
            catch (Exception)
            {
                pboImagenDetalles.Load("https://imgs.search.brave.com/1Ndrcvo4NgB8EzJe6cJmYhQD15j4RAPEyzy2mg8NrUE/rs:fit:500:0:0:0/g:ce/aHR0cHM6Ly93d3cu/cHVibGljZG9tYWlu/cGljdHVyZXMubmV0/L3BpY3R1cmVzLzI4/MDAwMC92ZWxrYS9u/b3QtZm91bmQtaW1h/Z2UtMTUzODM4NjQ3/ODdsdS5qcGc");
            }
        }
    }
}
