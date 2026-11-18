// ===================================================================================
//  ✅ CORRECTION — EXO 081 — if ... else avec ce que l'utilisateur tape
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : Write (sans Line) pour que la réponse se tape sur la même ligne
        Console.Write("Quelle température fait-il ? ");

        // ReadLine renvoie toujours du TEXTE : int.Parse le transforme en nombre entier
        // pour pouvoir le comparer avec 25.
        int temperature = int.Parse(Console.ReadLine()!);

        // Étape 2 : "dépasse 25 strictement" → > 25 (25 pile n'est pas "chaud")
        if (temperature > 25)
        {
            Console.WriteLine("Il fait chaud, prends de l'eau !");
        }
        else
        {
            // Étape 3 : tous les autres cas (25 ou moins)
            Console.WriteLine("Il ne fait pas trop chaud.");
        }
    }
}
