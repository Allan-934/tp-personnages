public class Personnage
{
    private protected string nom;
    private protected int pointDeVie;
    // Getters 
    public string GetNom()
    {
        return nom;
    }

    public int GetPointDeVie()
    {
        return pointDeVie;
    }
    // Setters
    public void SetNom(string nom)
    {
        this.nom = nom;
    }
    public void SetPointDeVie(int pointDeVie)
    {
        this.pointDeVie = pointDeVie;
    }
    // Constructeur pour initialiser le nom et les points de vie du personnage
    public Personnage(string nom, int pointDeVie)
    {
        this.nom = nom;
        this.pointDeVie = pointDeVie;
    }
    // Méthode pour recevoir des dégâts et réduire les points de vie du personnage
    public void ReccevoirDegats(int degats)
    {
        pointDeVie -= degats;
        if (pointDeVie < 0)
        {
            pointDeVie = 0;
        }
    }
    // Méthode pour afficher l'état actuel du personnage
    public virtual void AfficherEtat()
    {
        Console.WriteLine($"Nom: {nom}, Hp: {pointDeVie}");
    }
}