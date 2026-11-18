// ===================================================================================
//  ✅ CORRECTION — EXO 022 — Déclarer d'abord, donner la valeur ensuite
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Déclaration : on crée la « boîte » score, mais elle est encore vide
        int score;

        // Initialisation : on y range sa première valeur (pas de int devant, elle existe déjà)
        score = 0;

        Console.WriteLine($"Score de départ : {score}");
    }
}
