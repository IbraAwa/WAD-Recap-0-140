// ===================================================================================
//  ✅ CORRECTION — EXO 010 — Le format composite {0} {1}
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // {0} reçoit la 1re valeur ("Léa"), {1} la 2e (30)
        Console.WriteLine("{0} a {1} ans", "Léa", 30);

        // 3 valeurs : {0} = prénom, {1} = ville, {2} = nombre d'années
        Console.WriteLine("{0} habite à {1} depuis {2} ans", "Léa", "Namur", 5);
    }
}
