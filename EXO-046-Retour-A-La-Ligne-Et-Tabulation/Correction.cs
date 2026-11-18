// ===================================================================================
//  ✅ CORRECTION — EXO 046 — Retour à la ligne et tabulation dans un texte
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // \n = « passe à la ligne » : un seul WriteLine, mais deux lignes à l'écran
        Console.WriteLine("Ligne 1\nLigne 2");

        // \t = tabulation (comme la touche Tab) entre le produit et le prix,
        // et \n pour passer au produit suivant
        Console.WriteLine("Pain\t1,20\nLait\t0,95");
    }
}
