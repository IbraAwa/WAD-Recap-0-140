// ===================================================================================
//  ✅ CORRECTION — EXO 109 — Coalesce ?? : une valeur de secours (slide 126 n°1)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // string? : le ? autorise le texte à valoir null sans avertissement
        string? surnom = null;

        // ?? : « surnom, ou "Pas de surnom" si surnom est null »
        Console.WriteLine(surnom ?? "Pas de surnom");

        // Avec   string? surnom = "Lulu";   la partie gauche n'est plus null : on affiche Lulu.
    }
}
