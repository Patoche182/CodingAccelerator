/*     03 - Air - 03


*/



class Couleur
{
    public int rouge;
    public int vert;
    public int bleu;

    public Couleur(int r, int vert, int bleu)
    {
        rouge = r;
        this.vert = vert;
        this.bleu = bleu;
    }
}

    class Air03
{
    static void Main()
    {
        Console.WriteLine("Epreuve de l'Air !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        Couleur vert = new Couleur(0, 255, 0);
        Console.WriteLine("Rouge: " + vert.rouge);
        Console.WriteLine("vert: " + vert.vert);
        Console.WriteLine("bleu: " + vert.bleu);
        Couleur violet = new Couleur(255, 0, 255);
        Console.WriteLine("Rouge: " + violet.rouge);
        Console.WriteLine("vert: " + violet.vert);
        Console.WriteLine("bleu: " + violet.bleu);

        Console.ReadKey();
    }
}