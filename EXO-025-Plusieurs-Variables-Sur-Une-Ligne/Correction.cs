// ===================================================================================
//  ✅ CORRECTION — EXO 025 — Déclarer plusieurs variables sur une ligne
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Le type int n'est écrit qu'une fois ; les variables sont séparées par une virgule
        int largeur = 10, hauteur = 20;

        Console.WriteLine($"Tableau de {largeur} cm sur {hauteur} cm");
    }
}
