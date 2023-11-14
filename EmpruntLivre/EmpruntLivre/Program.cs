using EmpruntLivre.Classes;

//Création des adhérents
Adherent adherent1 = new Adherent("Genereux","Gilles", "43, rue Reine Elisabeth", "57000");
Adherent adherent2 = new Adherent("Marier", "Pascal", "91, rue de Verdun", "93370");

//Creation des livres
Livre livre1 = new Livre("Evasion", "Jean-Pascal", "Aventure", "Editions Vérone");
Livre livre2 = new Livre("New Land", "Jean-Paul", "Fantasy", "Falcon éditions");

//Création de la liste des livres et des adhérents
List<Livre> LesLivres = new List<Livre>();
List<Adherent> LesAdherents = new List<Adherent>();

//Ajout des livres et des adhérents dans les listes
LesLivres.Add(livre1);
LesLivres.Add(livre2);
LesAdherents.Add(adherent1);
LesAdherents.Add(adherent2);

//Affiche les personnes qui ont emprunter un livre
void Afficher(List<Livre> LesLivres, List<Adherent> LesAdherents)
{
    foreach(Livre unLivre in LesLivres)
    {
        if(unLivre.Adherent is not null)
        {
            foreach(Adherent unAdherent in LesAdherents)
            {
                if(unLivre.Adherent.Nom == unAdherent.Nom)
                {
                  Console.WriteLine(unAdherent.Nom);
                }
            }
        }
    }
}

action:
Console.WriteLine("Que voulez-vous faire ?");
string response = Console.ReadLine();

//Lance la méthode associé à ce que veut faire l'utilisateur
if(response == "Emprunter")
{
    Console.WriteLine("Quel adhérent souhaite emprunter un livre ?");
    string adherent = Console.ReadLine();
    foreach(Adherent unAdherent in LesAdherents)
    {
        if (adherent == unAdherent.Nom)
        {
            unAdherent.EmprunterUnLivre(unAdherent, LesLivres);
        }
    }
}else if(response == "Rendre")
{
    Console.WriteLine("Quel adhérent souhaite rendre un livre ?");
    string adherent = Console.ReadLine();
    foreach (Adherent unAdherent in LesAdherents)
    {
        if (adherent == unAdherent.Nom)
        {
            unAdherent.RendreUnLivre(unAdherent, LesLivres);
        }
    }
}else if (response == "Afficher")
{
    Afficher(LesLivres, LesAdherents);
}
goto action;