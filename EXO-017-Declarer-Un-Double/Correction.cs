// ===================================================================================
//  ✅ CORRECTION — EXO 017 — Déclarer un double
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un nombre à virgule sans suffixe est un double : pas besoin de lettre à la fin.
        // Dans le code, la virgule s'écrit avec un point.
        double distanceKm = 12.75;
        double temperature = 21.5;

        // À l'écran, le PC en français affiche une virgule
        Console.WriteLine($"Distance : {distanceKm} km");
        Console.WriteLine($"Température : {temperature} degrés");
    }
}
