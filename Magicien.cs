public class Magicien : Personnage
{
    private int mana { get; set; }

    public Magicien(string nom, int pointDeVie, int mana) : base(nom, pointDeVie) 
    {
        this.mana = mana;
    }

    public void LancerSort(int coutMana)
    {
        if (mana >= coutMana)
        {
            mana -= coutMana;
            Console.WriteLine($"{GetNom()} a utilisé un sort et a utilisé {coutMana} points de mana.");
        }
        else
        {
            Console.WriteLine($"{GetNom()} n'a pas assez de mana pour utiliser ce sort.");
        }
    }

    public override void AfficherEtat()
    {
        Console.WriteLine($"Nom: {nom}, Hp: {pointDeVie}, Mana: {mana}");
    }
}