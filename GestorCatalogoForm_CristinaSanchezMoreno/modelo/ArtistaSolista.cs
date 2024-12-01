using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCatalogoForm_CristinaSanchezMoreno.modelo
{
    internal class ArtistaSolista : Artista
    {
        public const int MAX_STRING_BG = 30;
        public const int MAX_STRING_SM = 20;


        private string nombreReal;
        private string instrumentoPrincipal;

        /*public ArtistaSolista(string nombreReal, string instrumentoPrincipal, string nombre,
            int anioInicios, string discografia, int numDiscos, GeneroMusical genero, bool estaActivo) :
            base(nombre, anioInicios, discografia, numDiscos, genero, estaActivo)
        {
            NombreReal = nombreReal;
            InstrumentoPrincipal = instrumentoPrincipal;
        }*/
        public ArtistaSolista(string nombreReal, string instrumentoPrincipal, string nombre,
            int anioInicios, string discografia, int numDiscos, GeneroMusical genero, bool estaActivo, int imagen) :
            base(nombre, anioInicios, discografia, numDiscos, genero, estaActivo, imagen)
        {
            NombreReal = nombreReal;
            InstrumentoPrincipal = instrumentoPrincipal;
        }

        public string NombreReal
        {
            get { return nombreReal; }
            set { nombreReal = (value.Length <= MAX_STRING_BG) ? value : value.Substring(0, MAX_STRING_BG); }
        }

        public string InstrumentoPrincipal
        {
            get { return instrumentoPrincipal; }
            set { instrumentoPrincipal = (value.Length <= MAX_STRING_SM) ? value : value.Substring(0, MAX_STRING_SM); }
        }

        public override string ToString()
        {
            return $"Solista: \t Nombre real: {NombreReal}, Instrumento principal: {InstrumentoPrincipal}, " +
                   base.ToString();
        }
    }
}
