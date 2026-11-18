// ===================================================================================
//  ✅ CORRECTION — EXO 110 — Coalesce : une quantité de 1 par défaut (slide 126 n°2)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // decimal pour l'argent ; 2.50m garde les deux décimales à l'affichage
        decimal prixUnitaire = 2.50m;

        // int? : un entier qui a le droit de valoir null (« pas de quantité indiquée »)
        int? quantite = null;

        // (quantite ?? 1) : la quantité si elle existe, sinon 1.
        // Les parenthèses sont utiles : on veut d'abord choisir la quantité, PUIS multiplier.
        decimal total = prixUnitaire * (quantite ?? 1);

        Console.WriteLine($"Total : {total} euros");

        // Avec   int? quantite = 4;   on obtient   Total : 10,00 euros
    }
}
