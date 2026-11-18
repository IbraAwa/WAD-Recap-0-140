// ===================================================================================
//  ✅ CORRECTION — EXO 111 — Coalesce en chaîne : le premier numéro dispo (slide 126 n°3)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        string? telPro = null;
        string? telPerso = "0470 12 34 56";

        // Les ?? se lisent de gauche à droite : on prend la PREMIÈRE valeur qui n'est pas null.
        // telPro est null → on essaie telPerso → il existe, on le garde.
        string numero = telPro ?? telPerso ?? "Aucun numéro";

        Console.WriteLine($"Numéro à appeler : {numero}");

        // Tests :
        //  - les deux à null       → Numéro à appeler : Aucun numéro
        //  - les deux remplis      → c'est telPro qui gagne, car il est écrit en premier
    }
}
