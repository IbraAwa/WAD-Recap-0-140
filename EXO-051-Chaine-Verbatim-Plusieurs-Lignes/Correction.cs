// ===================================================================================
//  ✅ CORRECTION — EXO 051 — La chaîne verbatim @ sur plusieurs lignes
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Avec @, on peut aller à la ligne DANS le texte : les retours à la ligne sont gardés.
        // Les lignes 2 et 3 sont collées tout à gauche, sinon les espaces du début
        // feraient partie du texte (et s'afficheraient).
        string adresse = @"Léa Dupont
Rue de la Gare 12
5000 Namur";

        // Un seul WriteLine suffit pour les 3 lignes
        Console.WriteLine(adresse);
    }
}
