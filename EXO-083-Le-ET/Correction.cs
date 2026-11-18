// ===================================================================================
//  ✅ CORRECTION — EXO 083 — Le ET : &&
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 2 : l'âge du client
        int age = 30;

        // && (ET) : la condition entière est vraie seulement si LES DEUX parties sont vraies.
        // "au moins 18" → age >= 18   ;   "moins de 65" → age < 65
        if (age >= 18 && age < 65)
        {
            Console.WriteLine("Tarif normal");
        }
        else
        {
            Console.WriteLine("Tarif réduit");
        }

        // Étape 3 : tests
        //   age = 30 → true && true   = true  → Tarif normal
        //   age = 12 → false && true  = false → Tarif réduit
        //   age = 70 → true && false  = false → Tarif réduit
    }
}
