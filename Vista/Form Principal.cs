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
            Helper.AgregarItemsComboBoxes(cboMarca, cboCategoria);
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
            if(form_agregar.ActualizarDGV())
                CargarDgv();
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validarSeleccionado())
            {
                Articulo articulo_seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormAgregar form_modificar = new FormAgregar(articulo_seleccionado);
                form_modificar.Text = "Modificar Articulo";
                form_modificar.ShowDialog();
                if(form_modificar.ActualizarDGV())
                    CargarDgv();
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
                    CargarDgv();
                }
            }
            catch (Exception ex)
            {
                Helper.ResultadoCarga(false, ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = (Marca)cboMarca.SelectedItem;
                Categoria categoria = (Categoria)cboCategoria.SelectedItem;
                List<Articulo> lista_filtrada = lista_articulos
                .Where(articulo => articulo.Marca.Id == marca.Id && articulo.Categoria.Id == categoria.Id)
                .ToList();
                dgvArticulos.DataSource = lista_filtrada;
                OcultarColumnas();
                Helper.CargarImagenPbo(pboImagenPrincipal, dgvArticulos.Columns["Imagen"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = lista_articulos;
            OcultarColumnas();
            Helper.AgregarItemsComboBoxes(cboMarca, cboCategoria);
        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrarNombre.Text.Trim().ToLower();
            List<Articulo> lista_filtrada;
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                lista_filtrada = lista_articulos.FindAll(articulo => articulo.Nombre.ToLower().Contains(filtro));
            }
            else
            {
                lista_filtrada = lista_articulos;
            }
            dgvArticulos.DataSource = lista_filtrada;
            OcultarColumnas();
        }

    }
}
