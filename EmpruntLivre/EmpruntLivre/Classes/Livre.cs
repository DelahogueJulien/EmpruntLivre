using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpruntLivre.Classes
{
    public class Livre
    {
        private string _libelle;

        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }
        private string Auteur { get; set; }
        private string Categorie { get; set; }
        private string Editeur { get; set; }

        private Adherent _adherent;

        public Adherent Adherent
        {
            get { return _adherent; }
            set { _adherent = value; }
        }


        public Livre(string libelle, string auteur, string categorie, string editeur)
        {
            Libelle = libelle;
            Auteur = auteur;
            Categorie = categorie;
            Editeur = editeur;
            Adherent = null;
        }
        
    }

}
