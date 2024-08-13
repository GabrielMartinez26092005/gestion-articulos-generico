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
                Helper.CargarImagenPbo(pboImagenPrincipal, dgvArticulos.Columns["Imagen"].ToString());
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
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (!validarSeleccionado())
            {
                Articulo actual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Helper.CargarImagenPbo(pboImagenPrincipal, actual.Imagen);
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (!validarSeleccionado())
            {
                Articulo articulo_seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormDetalles FormDetalles= new FormDetalles(articulo_seleccionado);
                FormDetalles.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar form_agregar = new FormAgregar();
            form_agregar.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validarSeleccionado())
            {
                Articulo articulo_seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormModificar form_modificar = new FormModificar(articulo_seleccionado);
                form_modificar.ShowDialog();
            }
        }
        private bool validarSeleccionado()
        {
            if (dgvArticulos.CurrentRow != null)
                return false;
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarSeleccionado())
                {
                    Articulo articulo_seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloNegocio articulo_negocio = new ArticuloNegocio();
                    if (Helper.Advertencia("¿Seguro desea eliminar un articulo?", "Eliminar"))
                        return;
                    articulo_negocio.EliminarArticulo(articulo_seleccionado);
                    Helper.ResultadoCarga(true, "La eliminacion fue exitosa");
                }
            }
            catch (Exception ex)
            {
                Helper.ResultadoCarga(false, ex.ToString());
            }
            
        }
    }
}
