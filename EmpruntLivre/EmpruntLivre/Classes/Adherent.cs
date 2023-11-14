using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpruntLivre.Classes
{
    public class Adherent
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string Prenom { get; set; }
        private string Adresse { get; set; }
        private string CodePostal { get; set; }

        public Adherent(string nom, string prenom, string adresse, string codePostal)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        //Associe un adherent et un livre lors d'un emprunt
        public void EmprunterUnLivre(Adherent unAdherent, List<Livre> LesLivres)
        {
            Console.WriteLine("Quel livre souhaitez-vous emprunter ?");
            string LivreVoulu = Console.ReadLine();

            foreach (Livre unLivre in LesLivres)
            {
                if (LivreVoulu == unLivre.Libelle && unLivre.Adherent == null)
                {
                    unLivre.Adherent = unAdherent;
                }else if(unLivre.Adherent is not null)
                {
                    Console.WriteLine("Ce livre est déjà avec quelqu'un");
                }
            }
        }
        //Remet la valeur à null lorsqu'un livre est rendu
        public void RendreUnLivre(Adherent unAdherent, List<Livre> LesLivres)
        {

            foreach (Livre unLivre in LesLivres)
            {
                if (unAdherent == unLivre.Adherent)
                {
                    unLivre.Adherent = null;
                }
            }
        }
    }
}
