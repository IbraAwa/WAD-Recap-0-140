// ===================================================================================
//  ✅ CORRECTION — EXO 080 — if ... else
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : l'âge est un nombre entier → int
        int age = 15;

        // Étape 2 : la condition entre parenthèses donne true ou false.
        // "18 ans ou plus" s'écrit >= 18 (et pas > 18, sinon 18 serait "Mineur").
        if (age >= 18)
        {
            Console.WriteLine("Majeur");
        }
        else
        {
            // Le else s'exécute quand la condition est fausse
            Console.WriteLine("Mineur");
        }

        // Étape 3 : tests en changeant la valeur de age
        //   age = 15 → Mineur
        //   age = 18 → Majeur (18 >= 18 est vrai)
        //   age = 30 → Majeur
    }
}
