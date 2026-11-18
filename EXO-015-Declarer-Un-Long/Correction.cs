// ===================================================================================
//  ✅ CORRECTION — EXO 015 — Déclarer un long
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 8 milliards dépasse la limite d'un int (environ 2,1 milliards) : il faut un long
        long populationMondiale = 8000000000;
        Console.WriteLine($"Population mondiale : {populationMondiale}");

        // ❌ Erreur CS0266 : impossible de convertir un long en int.
        //    Le nombre est trop grand pour tenir dans un int.
        // int populationEnInt = 8000000000;
    }
}
