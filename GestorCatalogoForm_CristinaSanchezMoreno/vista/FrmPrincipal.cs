using GestorCatalogoForm_CristinaSanchezMoreno.controlador;
using GestorCatalogoForm_CristinaSanchezMoreno.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCatalogoForm_CristinaSanchezMoreno
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CtrlArtista.getControlador();
            cbGenero.DataSource = Enum.GetValues(typeof(GeneroMusical));
            cbGenero.SelectedIndex = -1;
            mostrarPrimerArtista();
        }
        // Listeners de los botones del menu de la ventana que mostrarán los nuevos formularios
        private void darAltaBanda_Click(object sender, EventArgs e)
        {
            DarAltaBanda newBanda = new DarAltaBanda(this);
            newBanda.Show();
        }

        private void darAltaSolista_Click(object sender, EventArgs e)
        {
            DarAltaSolista newSolista = new DarAltaSolista(this);
            newSolista.Show();
        }

        private void buscarArtista_Click(object sender, EventArgs e)
        {
            BuscarArtista buscarArtist = new BuscarArtista();
            buscarArtist.Show();
        }

        private void eliminarArtista_Click(object sender, EventArgs e)
        {
            EliminarArtista eliminarArtista = new EliminarArtista();
            eliminarArtista.Show();
        }

        private void listarOrdenados_Click(object sender, EventArgs e)
        {
            ListarOrdenados listar = new ListarOrdenados();
            listar.Show();
        }
        // Listener para mostrar al siguiente de la lista 
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            CtrlArtista.siguienteArtista();
            mostrarArtistaActual();
            if(CtrlArtista.siguienteArtista == null)
            {
                btnSiguiente.Enabled = false;
            }
        }
        // Listener para mostrar el anterior artista de la lista
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CtrlArtista.anteriorArtista();
            mostrarArtistaActual();
        }

        // Funcion que inicializa la lista en el primer artista tras iniciar el programa, en caso de que no haya lista, se mostrarán los campos vacios
        public void mostrarPrimerArtista()
        {
            if (CtrlArtista.getListaArtistas().Count > 0)
            {
                Artista art = CtrlArtista.getPrimerArtista();
                if (art != null)
                {
                    setData(art);
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = true;
                }
                else
                {
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                }
            }
        }
        // Función que nos mostrará al siguiente artista de la lista
        private void mostrarArtistaActual()
        {
            Artista art = CtrlArtista.getArtistaActual();
            setData(art);

            btnAnterior.Enabled = !CtrlArtista.esPrimerEmpleado();
            btnSiguiente.Enabled = !CtrlArtista.esUltimoArtista();

        }
        // Función que recogerá los datos del artista y nos los mostrará en el campo que le toque
        private void setData(Artista art)
        {
            var valoresGenero = Enum.GetValues(typeof(GeneroMusical));

            if (art == null)
            {
                borrarCampos();
            }
            else
            {
                //Mostrar los campos que usaremos de auxiliar para cambiar entre los atributos de ArtistaSolista y ArtistaBanda
                txtAux1.Visible = true;
                txtAux2.Visible = true;


                txtNombreArtista.Text = art.NombreGrupo;
                txtAnioInicios.Text = art.AnioInicios.ToString();
                txtDiscografica.Text = art.Discografia;
                txtNumDiscos.Text = art.NumDiscos.ToString();

                cbGenero.SelectedIndex = Array.IndexOf(valoresGenero, art.Genero);
                Boolean estaActivo = (art.EstaActivo) ? rbSi.Checked = true : rbNo.Checked = true;

                if (art.Imagen != 0)
                {
                    pbImagen.Image = Image.FromFile($"CarpetaImagenes/{art.Imagen}.jpg");
                }

                // label y texto auxiliares que cambiarán dependiendo de si el artista es banda o solista
                if (art is ArtistaSolista a)
                {
                    lblAux1.Text = "Nombre real:";
                    lblAux2.Text = "Instrumento principal:";

                    txtAux1.Text = a.NombreReal;
                    txtAux2.Text = a.InstrumentoPrincipal;
                }
                if (art is ArtistaBanda b)
                {
                    lblAux1.Text = "Lista miembros:";
                    lblAux2.Text = "Numero de integrantes:";

                    txtAux1.Text = b.LstMiembros;
                    txtAux2.Text = b.NumIntegrantes.ToString();
                }
            }
        }
        //Listener que nos guardará la lista modificada
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult borrar = MessageBox.Show($"¿Seguro de que desea guardar el cátalogo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (borrar == DialogResult.Yes)
            {
                CtrlCatalogo.escribirArchivo(CtrlArtista.getListaArtistas());
                MessageBox.Show("El catálogo se ha guardado correctamente. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Funcion que nos borrará los campos.
        private void borrarCampos()
        {
            txtNombreArtista.Text = string.Empty;
            txtAnioInicios.Text = string.Empty;
            txtDiscografica.Text = string.Empty;
            txtNumDiscos.Text = string.Empty;
            cbGenero.SelectedIndex = -1;
            rbNo.Checked = false;
            rbSi.Checked = false;
        }
    }
}
