namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        //Création dd'un personnage de base (Humain)
        Personnage p1 = new Personnage("Takemichi", 200);

        p1.AfficherEtat();

        // Partie 5 : Le personnage reçoit des dégâts
        p1.RecevoirDegats(100);

        p1.AfficherEtat();

        // Partie 5 : Le personnage reçoit des dégâts mais les pointts de vie diminuent moins 
        p1.RecevoirDegats(50, 25);

        p1.AfficherEtat();

        //Création d'un guerrier 

        Guerrier g1 = new Guerrier("Guts", 200, 100);
        g1.Attaquer(50);

        // Création d'un magicien 

        Magicien m1 = new Magicien("Geralt de Riv", 200, 100);
        m1.LancerSort(30);

        // Affichage de l'état du guerrier et du magicien
        g1.AfficherEtat();
        m1.AfficherEtat();

        // Creation d'une liste de personnages et ajout du guerrier et du magicien à la liste
        List<Personnage> personnages = new List<Personnage> { g1, m1 };

        Personnage pers2 = m1;
        if (pers2 is Guerrier mg1) 
        {
            mg1.Attaquer(30);
        }
        else
        {
            Console.WriteLine($"{pers2.GetNom()} n'est pas un guerrier.");
        }

        // Affichage de la liste des personnages
        foreach (var personnage in personnages)
        {
            personnage.AfficherEtat();

            if (personnage is Guerrier g)
            {
                g.Attaquer(20);
            }

            else if (personnage is Magicien m)
            {
                m.LancerSort(10);
            }
        }
    }
}
