namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Guts", 200);

        p1.AfficherEtat();

        p1.ReccevoirDegats(100); 
        
        p1.AfficherEtat();


    }
}
