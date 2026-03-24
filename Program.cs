namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        //Création dd'un personnage de base (Humain)
        Personnage p1 = new Personnage("Takemichi", 200);

        p1.AfficherEtat();

        p1.ReccevoirDegats(100); 
        
        p1.AfficherEtat();

        //Création d'un guerrier 

        Personnage g1 = new Guerrier ("Guts", 200, 100);

        // Création d'un magicien 

        Personnage m1 = new Magicien ("Geralt de Riv", 200, 100);

        // Affichage de l'état du guerrier et du magicien
        g1.AfficherEtat(); 
        m1.AfficherEtat();




    }
}
