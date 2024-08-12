using System;
using System.Collections.Generic;
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
                pboImagen.Load("https://imgs.search.brave.com/1Ndrcvo4NgB8EzJe6cJmYhQD15j4RAPEyzy2mg8NrUE/rs:fit:500:0:0:0/g:ce/aHR0cHM6Ly93d3cu/cHVibGljZG9tYWlu/cGljdHVyZXMubmV0/L3BpY3R1cmVzLzI4/MDAwMC92ZWxrYS9u/b3QtZm91bmQtaW1h/Z2UtMTUzODM4NjQ3/ODdsdS5qcGc");
            }
        }
        public static void AgregarItemsComboBoxes(ComboBox cboMarca, ComboBox cboCategoria)
        {
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");
            cboMarca.Items.Add("Motorola");

            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Televisores");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Audio");
        }

        public static bool ValidarComboBoxes(ComboBox cboMarca, ComboBox cboCategoria)
        {
            if (cboMarca.SelectedItem == null)
            {
                MessageBox.Show("El campo MARCA es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("El campo CATEGORIA es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        } 
        
        public static int DevolverIdMarca(ComboBox cboMarca)
        {
            int id_marca = 0;
            switch (cboMarca.SelectedIndex)
            {
                case 0: // Samsung
                    id_marca = 1;
                    break;
                case 1: // Apple
                    id_marca = 2;
                    break;
                case 2: // Sony
                    id_marca = 3;
                    break;
                case 3: // Huawei
                    id_marca = 4;
                    break;
                default: // Motorola
                    id_marca = 5;
                    break;
            }
            return id_marca;
        }
        public static int DevolverIdCategoria(ComboBox cboCategoria)
        {
            int id_categoria = 0;
            switch (cboCategoria.SelectedIndex)
            {
                case 0: // Celulares
                    id_categoria = 1;
                    break;
                case 1: // Televisores
                    id_categoria = 2;
                    break;
                case 2: // Media
                    id_categoria = 3;
                    break;
                default: // Audio
                    id_categoria = 4;
                    break;
            }
            return id_categoria;
        }

        public static void ResultadoCarga(bool respuesta, string mensaje)
        {
            if (respuesta)
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
