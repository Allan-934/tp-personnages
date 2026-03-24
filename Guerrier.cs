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
        ReccevoirDegats(degatsReduits);
    }

    public void Guerrier_AfficherEtat()
    {
        base.AfficherEtat();
        Console.WriteLine($"Armure: {armure}");
    }
}