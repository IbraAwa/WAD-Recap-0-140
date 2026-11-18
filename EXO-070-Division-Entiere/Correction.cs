// ===================================================================================
//  ✅ CORRECTION — EXO 070 — int / int : la virgule disparaît
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // a) Prédiction : 12 → int / int donne un int : la partie ,5 est perdue
        Console.WriteLine(100 / 8);

        // b) Prédiction : 12,5 → 100.0 est un double, le résultat est donc un double
        Console.WriteLine(100.0 / 8);

        // c) Prédiction : 12,5 → 100f est un float (suffixe f), le résultat est un float
        Console.WriteLine(100f / 8);
    }
}
