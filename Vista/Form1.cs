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
    public partial class Principal : Form
    {
        private List<Articulo> lista_articulos;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CargarDvg();
        }
        private void CargarDvg()
        {
            ArticuloNegocio articulo_negocio = new ArticuloNegocio();
            try
            {
                lista_articulos = articulo_negocio.CrearListaArticulo();
                dvgArticulos.DataSource = lista_articulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
