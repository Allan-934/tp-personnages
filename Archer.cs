public class Archer : Personnage
{
    private int precision { get; set; } 

    public Archer(string nom, int pointDeVie, int precision) : base(nom, pointDeVie)
    {
        this.precision = precision; 
    }
    
   // methode tirer 
    public void Tirer(int Attaque)
    {
        Console.WriteLine($"{GetNom()} tire avec {Attaque} pts d'attaque et une précision de {precision}%.");
    }
    public override string ToString()
    {
        return $"Nom: {nom}, Hp: {pointDeVie}, Précision: {precision}%"; 
    }

    public override void AfficherEtat()
    {
        Console.WriteLine($"Nom: {nom}, Hp: {pointDeVie}, Précision: {precision}%");
    }
}