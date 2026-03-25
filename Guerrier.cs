public class Guerrier : Personnage
{
    private int armure { get; set; } 

    public Guerrier(string nom, int pointDeVie, int armure) : base(nom, pointDeVie)
    {
        this.armure = armure; 
    }
    
   public void ReduitDegats(int degats)
    {
        int degatsReduits = degats - armure;
        if (degatsReduits < 0)
        {
            degatsReduits = 0;
        }
        RecevoirDegats(degatsReduits);
    }

    public void Attaquer(int Attaque)
    {
        Console.WriteLine($"{GetNom()} attaque avec {Attaque} pts d'attaque.");
    }

    public override void AfficherEtat()
    {
        Console.WriteLine($"Nom: {nom}, Hp: {pointDeVie}, Armure: {armure}");
    }
}