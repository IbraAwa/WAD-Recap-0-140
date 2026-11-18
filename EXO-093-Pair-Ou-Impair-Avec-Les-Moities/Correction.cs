// ===================================================================================
//  ✅ CORRECTION — EXO 093 — Pair ou impair avec les moitiés (slide 111)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : Write pour taper la réponse sur la même ligne, puis int.Parse
        // pour transformer le texte tapé en nombre entier.
        Console.Write("Un nombre : ");
        int nombre = int.Parse(Console.ReadLine()!);

        // Étape 2 : entre deux int, / fait une division ENTIÈRE : la partie après la virgule
        // est perdue. 10 / 2 = 5, mais 7 / 2 = 3 (et pas 3,5).
        int moitie = nombre / 2;

        // Étape 3 : si rien n'a été perdu, moitie + moitie redonne le nombre de départ.
        if (moitie + moitie == nombre)
        {
            Console.WriteLine("Le nombre est pair");
        }
        else
        {
            Console.WriteLine("Le nombre est impair");
        }

        // Étape 4 : tests
        //   10 → moitie = 5, 5 + 5 = 10  → Le nombre est pair
        //   7  → moitie = 3, 3 + 3 = 6 ≠ 7 → Le nombre est impair
    }
}
