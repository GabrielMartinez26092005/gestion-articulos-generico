using Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public static class Helper
    {
        public static void CargarImagenPbo(PictureBox pboImagen, string imagen_url)
        {
            try
            {
                pboImagen.Load(imagen_url);
            }
            catch (Exception)
            {
                pboImagen.Image = Properties.Resources.not_found;

            }
        }
        public static void AgregarItemsComboBoxes(ComboBox cboMarca, ComboBox cboCategoria)
        {
            ArticuloNegocio articulo_negocio = new ArticuloNegocio();
            cboMarca.DataSource = articulo_negocio.CrearListaMarca();
            cboCategoria.DataSource = articulo_negocio.CrearListaCategoria();
        }
        public static void ResultadoCarga(bool respuesta, string mensaje)
        {
            if (respuesta)
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool Advertencia(string mensaje, string titulo)
        { 
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                return false;
            }
            return true;
        }
    }
}
