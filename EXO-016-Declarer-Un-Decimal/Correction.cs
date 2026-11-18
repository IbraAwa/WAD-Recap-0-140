// ===================================================================================
//  ✅ CORRECTION — EXO 016 — Déclarer un decimal (pour l'argent)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Dans le code : un POINT pour la virgule, et le suffixe m collé au nombre
        // pour dire à C# que c'est un decimal (le type adapté à l'argent).
        decimal prixBaguette = 1.20m;

        // À l'écran, le PC en français affiche une virgule : 1,20
        Console.WriteLine($"Une baguette coûte {prixBaguette} euros");

        // ❌ Erreur CS0664 : sans suffixe, 0.95 est un double, et C# refuse de le mettre
        //    dans un decimal. Il faut écrire 0.95m.
        // decimal prixCroissant = 0.95;
    }
}
