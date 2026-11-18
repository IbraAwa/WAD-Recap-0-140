// ===================================================================================
//  ✅ CORRECTION — EXO 024 — Ajouter quelque chose à une variable
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        int points = 0;
        Console.WriteLine($"Points : {points}");

        // C# calcule d'abord la droite avec l'ANCIENNE valeur (0 + 10),
        // puis range le résultat (10) dans points
        points = points + 10;
        Console.WriteLine($"Points : {points}");

        // Même chose : 10 + 10 = 20
        points = points + 10;
        Console.WriteLine($"Points : {points}");
    }
}
