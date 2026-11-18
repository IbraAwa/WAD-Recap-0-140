// ===================================================================================
//  ✅ CORRECTION — EXO 088 — if ... else if ... else
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int note = 14;

        // Étape 2 : C# teste de haut en bas et s'arrête au PREMIER cas vrai.
        // On commence donc par le plus exigeant (16) : sinon une note de 17
        // serait déjà attrapée par ">= 10" et afficherait "Réussi".
        if (note >= 16)
        {
            Console.WriteLine("Très bien");
        }
        else if (note >= 14)
        {
            Console.WriteLine("Bien");
        }
        else if (note >= 10)
        {
            Console.WriteLine("Réussi");
        }
        else
        {
            // Aucun cas n'est vrai : moins de 10
            Console.WriteLine("Échec");
        }

        // Étape 3 : tests
        //   17 → Très bien   |   14 → Bien   |   11 → Réussi   |   5 → Échec
    }
}
