using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioMobile.ClassesMetier
{
    public class Livre
    {
        public int idLivre { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public GenreLivre genreLivre { get; set; }
        public ThemeLivre themeLivre { get; set; }
        public string Image { get; set; }
        public int quantite { get; set; }
    }
}
