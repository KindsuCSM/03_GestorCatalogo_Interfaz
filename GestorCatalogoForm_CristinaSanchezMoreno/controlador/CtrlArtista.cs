using GestorCatalogoForm_CristinaSanchezMoreno.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace GestorCatalogoForm_CristinaSanchezMoreno.controlador
{
    internal class CtrlArtista
    {
        private static CtrlArtista instancia;
        private static List<Artista> lstArtistas;
        private static int indiceActual;
        public static int contadorImagenes;
        private static string PATH_CARPETA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CarpetaImagenes");

        //Constructor privado para crear el controlador ya que usamos el modelo singleton
        private  CtrlArtista()
        {
            // Inicializamos la lista que tendrá nuestra clase y que será la que la controle
            lstArtistas = CtrlCatalogo.leerArchivo();
            
            indiceActual = 0;
            contadorImagenes = 0;
            if (!Directory.Exists(PATH_CARPETA))
            {
                Directory.CreateDirectory(PATH_CARPETA);
            }

            foreach(Artista artista in lstArtistas)
            {
                if(contadorImagenes < artista.Imagen) 
                {
                    contadorImagenes = artista.Imagen;
                }
            }
        }
        // Función publica para obtener el controlador 
        public static CtrlArtista getControlador()
        {
            if(instancia == null)
            {
                instancia = new CtrlArtista(); ;
            }
            return instancia;
        }

        //Obtenemos el artista con el indice actual
        public static Artista getArtistaActual()
        {
            return lstArtistas[indiceActual];
        }

        //Sumamos uno al indice
        public static void siguienteArtista()
        {
            if(indiceActual < lstArtistas.Count)
            {
                indiceActual++;
            }
        }

        //Restamos uno al indice
        public static void anteriorArtista()
        {
            if(indiceActual > 0)
            {
                indiceActual--;
            }
        }

        //Obtenemos el primer artista de la lista y ponemos el indice en 0
        public static Artista getPrimerArtista()
        {
            indiceActual = 0;
            if(lstArtistas.Count == 0 || lstArtistas == null)
            {
                return null;
            }
            else
            {
                return lstArtistas[indiceActual];
            }
           
        }

        // Nos indica si el indice está en la ultima posición de la lista
        public static Boolean esUltimoArtista()
        {
            return indiceActual == lstArtistas.Count - 1;
        }

        // Nos indica si el indice está en la primera posicion de la lista
        public static Boolean esPrimerEmpleado()
        {
            return indiceActual == 0;
        }

        // Obtener la lista de artistas
        public static List<Artista> getListaArtistas()
        {
            return lstArtistas;
        }
        // Funcion para añadir artistaSolista a la lista
        public static void addArtistaSolista(ArtistaSolista artista)
        {
            lstArtistas.Add(artista);
        }
        // Funcion para añadir artistaBanda a la lista
        public static void addArtistaBanda(ArtistaBanda artista)
        {
            lstArtistas.Add(artista);
        }
        // Función para ordenar la lista según el parametro que le indiquemos
        public static List<Artista> orderLista(string atributo)
        { 
            List<Artista> lstOrdenada = new List<Artista>();
            switch (atributo)
            {
                case "nombre grupo":
                    lstOrdenada = lstArtistas.OrderBy(n => n.NombreGrupo).ToList();
                    break;
                case "año inicio":
                    lstOrdenada = lstArtistas.OrderBy(n => n.AnioInicios).ToList();
                    break;
                case "discografia":
                    lstOrdenada = lstArtistas.OrderBy(n => n.Discografia).ToList();
                    break;
                case "numero de discos":
                    lstOrdenada = lstArtistas.OrderBy(n => n.NumDiscos).ToList();
                    break;
                case "genero":
                    lstOrdenada = lstArtistas.OrderBy(n => n.Genero.ToString()).ToList();
                    break;
                case "activo":
                    lstOrdenada = lstArtistas.OrderBy(n => n.EstaActivo).ToList();
                    break;
            }

            return lstOrdenada;
        }
        // Esta funcion era para cuando no tenia Form: mostrar la lista por consola
        private static void mostrarLista(List<Artista> lista)
        {
            foreach (Artista artista in lista)
            {
                Console.WriteLine(artista);
            }
        }
        // Funcion para eliminar el artista, que se le pasa por parametro, de la lista
        public static void deleteArtistas(Artista artista)
        {
            lstArtistas.Remove(artista);
        }
        // Esta funcion era para cuando no tenia Form: mostrar la lista por consola y eliminar si quiere a uno 
        public static void buscarArtistaYEliminarUno(Dictionary<string, string> dicArtistas)
        {
            List<Artista> lstArtistasEncontrados = searchArtista(dicArtistas);

            mostrarLista(lstArtistasEncontrados);

            if (lstArtistasEncontrados.Count == 1)
            {
                Console.WriteLine("¿Desea eliminar el artista encontrado?(Si-No)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "si")
                {
                    lstArtistas.Remove(lstArtistasEncontrados[0]);
                }
            }
        }

        // Función para buscar un artista dentro de una lista usando un diccionario
        // y comparando valores, si pasa el filtro se añadirá a una lista auxiliar que retornará
        public static List<Artista> searchArtista(Dictionary<string, string> diccionario)
        {
            List<Artista> artistasFiltrados = new List<Artista>();
            bool cumpleRequisitos;

            foreach (Artista artista in lstArtistas)
            {
                cumpleRequisitos = true;
                foreach (KeyValuePair<string, string> valor in diccionario)
                {
                    string atributo = valor.Key;
                    string valorAtributo = valor.Value;
                    if (atributo.Equals("NombreGrupo"))
                    {
                        if (!artista.NombreGrupo.ToLower().Contains(valorAtributo))
                        {
                            cumpleRequisitos = false;
                            break;
                        }
                    }

                    if (atributo.Equals("AnioInicios"))
                    {
                        if (!artista.AnioInicios.Equals(Int32.Parse(valorAtributo)))
                        {
                            cumpleRequisitos = false;
                            break;
                        }
                    }

                    if (atributo.Equals("Discografia"))
                    {
                        if (!artista.Discografia.ToLower().Equals(valorAtributo))
                        {
                            cumpleRequisitos = false;
                            break;
                        }
                    }

                    if (atributo.Equals("NumDiscos"))
                    {
                        if (!artista.NumDiscos.Equals(Int32.Parse(valorAtributo)))
                        {
                            cumpleRequisitos = false;
                            break;
                        }
                    }

                    if (atributo.Equals("Genero"))
                    {
                        if (!artista.Genero.ToString().Equals(valorAtributo))
                        {
                            cumpleRequisitos = false;
                            break;
                        }
                    }

                    if (atributo.Equals("EstaActivo"))
                    {
                        if (!artista.EstaActivo.ToString().Equals(valorAtributo))
                        {
                            cumpleRequisitos = false;
                            break;
                        }
                    }
                }

                if (cumpleRequisitos)
                {
                    artistasFiltrados.Add(artista);
                }
            }

            return artistasFiltrados;
        }

        // Funcion que copia la imagen( que ha introducido el usuario en la ventana ) en la carpeta
        // especificada y la renombra segun el contador de imagenes declarado
        public static void convertirImagen(String path, int numImagen)
        {
            string nombreImagen = $"{numImagen}.jpg";
            string newPath = Path.Combine(PATH_CARPETA, nombreImagen);

            File.Copy(path, newPath, true);
        }
    }
}
