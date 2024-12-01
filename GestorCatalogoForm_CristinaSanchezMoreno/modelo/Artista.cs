using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCatalogoForm_CristinaSanchezMoreno.modelo
{
    internal class Artista
    {
        public const int MAX_STRING_BG = 30;
        public const int MAX_STRING_SM = 10;

        private string nombreGrupo;
        private int anioInicios;
        private string discografia;
        private int numDiscos;
        private GeneroMusical generoMusical;
        private bool estaActivo;
        private int imagen;

        public Artista() { }

        public Artista(string nombreGrupo, int anioInicios, string discografia, int numDiscos, GeneroMusical genero,
            bool estaActivo, int imagen)
        {
            NombreGrupo = nombreGrupo;
            AnioInicios = anioInicios;
            Discografia = discografia;
            NumDiscos = numDiscos;
            Genero = genero;
            EstaActivo = estaActivo;
            Imagen = imagen;
        }
        /*public Artista(string nombreGrupo, int anioInicios, string discografia, int numDiscos, GeneroMusical genero,
            bool estaActivo)
        {
            NombreGrupo = nombreGrupo;
            AnioInicios = anioInicios;
            Discografia = discografia;
            NumDiscos = numDiscos;
            Genero = genero;
            EstaActivo = estaActivo;
            
        }*/

        public string NombreGrupo
        {
            get { return nombreGrupo; }
            set { nombreGrupo = (value.Length <= MAX_STRING_BG) ? value : value.Substring(0, MAX_STRING_BG); }
        }

        public int Imagen { get; set; }
        public int AnioInicios { get; set; }
        public int NumDiscos { get; set; }
        public GeneroMusical Genero { get; set; }

        public string Discografia
        {
            get { return discografia; }
            set { discografia = (value.Length <= MAX_STRING_SM) ? value : value.Substring(0, MAX_STRING_SM); }
        }

        public bool EstaActivo { get; set; }

        public override string ToString()
        {
            string activo = (EstaActivo) ? "Actualmente se encuentra activo" : "Actualmente no se encuentra activo";

            return
                $"Nombre artístico: {NombreGrupo}, Año comienzo: {AnioInicios}, Número de discos: {NumDiscos}, Género musical: {Genero.ToString()}, Discografía: {Discografia}, {activo}";
        }
    }
}
