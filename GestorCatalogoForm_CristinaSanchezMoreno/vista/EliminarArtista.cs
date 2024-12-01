using GestorCatalogoForm_CristinaSanchezMoreno.controlador;
using GestorCatalogoForm_CristinaSanchezMoreno.modelo;
using System;
using System.Collections;
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
    public partial class EliminarArtista : Form
    {
        public EliminarArtista()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
            cbGenero.DataSource = Enum.GetValues(typeof(GeneroMusical));
            cbGenero.SelectedIndex = -1;
        }
        // Listener del btn Aceptar que mediante el diccionario que recogemos, llamamos a la funcion del CtrlArtista
        // que nos filtrará la lista general y nos retornará los artistas encontrados
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> diccionarioObtenido = new Dictionary<String, String>();
            List<Artista> lista = new List<Artista>();

            diccionarioObtenido = obtenerDiccionarioDeTxtBox();
            lista = CtrlArtista.searchArtista(diccionarioObtenido);

            lstArtistasEncontrados.DataSource = null;
            lstArtistasEncontrados.DataSource = lista;

            if(lista.Count != 0)
            {
                btnEliminar.Enabled = true;
            }
        }
        // Listener de btnCancelar que borra todos los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            borrarCampos();
            lstArtistasEncontrados.DataSource = null;
        }
        // Listener del boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarArtista();
        }
        // Funcion que recoge los campos del Form y si no están vacíos los agrega a un diccionario que luego retornará
        private Dictionary<String, String> obtenerDiccionarioDeTxtBox()
        {
            Dictionary<String, String> diccionarioBusqueda = new Dictionary<String, String>();

            if (!string.IsNullOrEmpty(txtNombreArtista.Text))
            {
                diccionarioBusqueda.Add("NombreGrupo", txtNombreArtista.Text.ToLower());
            }
            if (!string.IsNullOrEmpty(txtAnioInicios.Text))
            {
                diccionarioBusqueda.Add("AnioInicios", txtAnioInicios.Text);
            }
            if (!string.IsNullOrEmpty(txtDiscografica.Text))
            {
                diccionarioBusqueda.Add("Discografia", txtDiscografica.Text.ToLower());
            }
            if (!string.IsNullOrEmpty(txtNumDiscos.Text))
            {
                diccionarioBusqueda.Add("NumDiscos", txtNumDiscos.Text);
            }
            if (cbGenero.SelectedIndex != -1)
            {
                GeneroMusical genero;
                genero = (GeneroMusical)cbGenero.SelectedIndex;
                diccionarioBusqueda.Add("Genero", genero.ToString());
            }
            if (rbSi.Checked == true)
            {
                diccionarioBusqueda.Add("EstaActivo", "True");
            }
            if (rbNo.Checked == true)
            {
                diccionarioBusqueda.Add("EstaActivo", "False");
            }

            return diccionarioBusqueda;
        }

        // Funcion que recoge la lista del ListBox, elimina el artista que el usuario ha seleccionado y muestra la lista sin dicho artista
        private void eliminarArtista()
        {
            List<Artista> lstEncontrada = new List<Artista>();
            int index;

            foreach (var item in lstArtistasEncontrados.Items)
            {
                lstEncontrada.Add((Artista)item);
            }

            index = lstArtistasEncontrados.SelectedIndex;

            if (index != -1)
            {
                Artista artistaSeleccionado = (Artista)lstArtistasEncontrados.Items[index];
                DialogResult borrar = MessageBox.Show($"¿Seguro de que quieres eliminar el artista {artistaSeleccionado.NombreGrupo}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (borrar == DialogResult.Yes)
                {
                    CtrlArtista.deleteArtistas(artistaSeleccionado);
                    lstEncontrada.Remove(artistaSeleccionado);
                    lstArtistasEncontrados.DataSource = lstEncontrada;
                    MessageBox.Show("El artista se ha eliminado correctamente", "Información");
                }
            }
        }
        // Funcion para borrar campos
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
