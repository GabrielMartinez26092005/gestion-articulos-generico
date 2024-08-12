using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        private List<Articulo> lista_articulos;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }
        private void CargarDgv()
        {
            ArticuloNegocio articulo_negocio = new ArticuloNegocio();
            try
            {
                lista_articulos = articulo_negocio.CrearListaArticulo();
                dgvArticulos.DataSource = lista_articulos;
                OcultarColumnas();
                CargarImagen(dgvArticulos.Columns["Imagen"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            try
            {
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false;
                dgvArticulos.Columns["Imagen"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void CargarImagen(string imagen)
        {
            try
            {
                pboImagen.Load(imagen);
            }
            catch (Exception)
            {
                pboImagen.Load("https://imgs.search.brave.com/1Ndrcvo4NgB8EzJe6cJmYhQD15j4RAPEyzy2mg8NrUE/rs:fit:500:0:0:0/g:ce/aHR0cHM6Ly93d3cu/cHVibGljZG9tYWlu/cGljdHVyZXMubmV0/L3BpY3R1cmVzLzI4/MDAwMC92ZWxrYS9u/b3QtZm91bmQtaW1h/Z2UtMTUzODM4NjQ3/ODdsdS5qcGc");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo actual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(actual.Imagen);
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articulo_actual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormDetalles FormDetalles= new FormDetalles(articulo_actual);
                FormDetalles.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar form_agregar = new FormAgregar();
            form_agregar.ShowDialog();

        }
    }
}
