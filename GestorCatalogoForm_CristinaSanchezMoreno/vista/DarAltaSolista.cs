using GestorCatalogoForm_CristinaSanchezMoreno.controlador;
using GestorCatalogoForm_CristinaSanchezMoreno.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCatalogoForm_CristinaSanchezMoreno
{
    public partial class DarAltaSolista : Form
    {
        private static string rutaImagenOr;
        private FrmPrincipal frmPrincipal;
        public DarAltaSolista(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
            cbGenero.DataSource = Enum.GetValues(typeof(GeneroMusical));
            cbGenero.SelectedIndex = -1;
        }
        // Listener del button guardar, guarda el artista y controla de que se muestre en el frmPrincipal tras terminar con la ventana.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AddArtistaSolistaToList();
            frmPrincipal.mostrarPrimerArtista();
        }
        // Funcion que recoge los datos de los campos en el Form, convierte en nuevo artista y lo agrega a la lista de CtrlList
        private void AddArtistaSolistaToList()
        {
            String nombre;
            String anioInicios;
            int anioiniciosToInt;
            String discografica;
            String numDiscos;
            int numDiscosToInt;
            GeneroMusical genero;
            String nombreReal;
            String instrumentoPrincipal;
            int idImagen;

            String mensajeError = "";
            Boolean estaActivo = true;
            Boolean datosCorrectos = true;

            //Si no recogemos ninguna imagen, el id lo mandaremos en 0,
            //sino le añadiremos al contador de CtrlArtista +1 y copiaremos la imagen a nuestra carpeta
            if (pbImagen.Image == null)
            {
                idImagen = 0;
            }
            else
            {
                idImagen = ++CtrlArtista.contadorImagenes;
                CtrlArtista.convertirImagen(rutaImagenOr, idImagen);
            }

            //Recogemos los datos de los campos del Form y nos aseguramos de que sean del formato que necesitamos.
            //Si todo es correcto, se guarda un nuevo artista y se muestra un dialog de confirmación
            nombre = txtNombreArtista.Text;
            anioInicios = txtAnioInicios.Text;
            if (!int.TryParse(anioInicios, out anioiniciosToInt))
            {
                datosCorrectos = false;
                mensajeError += "| año de inicios |";
            }
            discografica = txtDiscografica.Text;
            numDiscos = txtNumDiscos.Text;
            if (!int.TryParse(numDiscos, out numDiscosToInt))
            {
                datosCorrectos = false;
                mensajeError += "| numero de discos |";
            }
            genero = (GeneroMusical)cbGenero.SelectedItem;
            if (rbSi.Checked == true) { estaActivo = true; }
            if (rbNo.Checked == true) { estaActivo = false; }
            nombreReal = txtNombreReal.Text;
            instrumentoPrincipal = txtInstrumentoPrincipal.Text;

            if (datosCorrectos)
            {
                CtrlArtista.addArtistaSolista(new ArtistaSolista(nombreReal, instrumentoPrincipal, nombre, anioiniciosToInt, discografica, numDiscosToInt, genero, estaActivo, idImagen));
                MessageBox.Show("El artista se ha agregado correctamente.", "Información");
                borrarCampos();
            }
            else
            {
                MessageBox.Show($"[{mensajeError}] debe ser un numero.", "Error");
            }
        }
        //Función para borrar los campos 
        private void borrarCampos()
        {
            txtNombreArtista.Text = string.Empty;
            txtAnioInicios.Text = string.Empty;
            txtDiscografica.Text = string.Empty;
            txtNumDiscos.Text = string.Empty;
            cbGenero.SelectedIndex = -1;
            rbNo.Checked = false;
            rbSi.Checked = false;
            txtNombreReal.Text = string.Empty;
            txtInstrumentoPrincipal.Text = string.Empty;
            pbImagen.Image = null;
        }
        // Listener del btn de cancelar: Borra los datos de los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            borrarCampos();
        }

        // Listener del btn de carga la imagen, nos muestra un dialog de la carpeta del sistema y recogemos una imagen
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {   // Para asegurarnos de que solo pueda introducir imagenes
                ofdCuadroArchivos.Filter = "Archivos de imagen (*.jpg;*.png)|*.jpg;*.png";
                ofdCuadroArchivos.Title = "Selecciona una imagen";
                if (ofdCuadroArchivos.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenOr = ofdCuadroArchivos.FileName;
                    pbImagen.Image = Image.FromFile(rutaImagenOr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no tiene el formato deseado. ");
            }
        }
    }
}
