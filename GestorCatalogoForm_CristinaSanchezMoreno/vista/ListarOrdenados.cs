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
    public partial class ListarOrdenados : Form
    {
        public ListarOrdenados()
        {
            InitializeComponent();
        }

        // Listeners de los botones que segun el boton que pulsemos pasaremos un parametro u otro para ordenar la lista
        private void btnNombreGrupo_Click(object sender, EventArgs e)
        {
            CargarListaOrdenada("nombre grupo");
        }

        private void btnAnioInicios_Click(object sender, EventArgs e)
        {
            CargarListaOrdenada("año inicio");
        }

        private void btnDiscografica_Click(object sender, EventArgs e)
        {
            CargarListaOrdenada("discografia");
        }

        private void btnNumDiscos_Click(object sender, EventArgs e)
        {
            CargarListaOrdenada("numero de discos");
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            CargarListaOrdenada("genero");
        }

        private void btnActivo_Click(object sender, EventArgs e)
        {
            CargarListaOrdenada("activo");
        }

        // Funcion que recibirá el valor por el que queremos ordenar la lista, usará la función que tenemos en CtrlArtista
        // para ordenarla segun el parametro que le pasemos y nos lo mostrará en la ListBox
        private void CargarListaOrdenada(string atributo)
        {
            try
            {
                lstBoxArtistas.DataSource = null;
                lstBoxArtistas.DataSource = CtrlArtista.orderLista(atributo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista ordenada: {ex.Message}", "Error");
            }
        }
    }
}
