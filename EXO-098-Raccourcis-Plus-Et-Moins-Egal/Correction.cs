// ===================================================================================
//  ✅ CORRECTION — EXO 098 — Les raccourcis += et -=
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : de l'argent → decimal (calculs exacts, pas d'erreurs d'arrondi).
        // Le suffixe m indique au compilateur que le nombre est un decimal.
        decimal total = 0m;

        // Étape 2 : total += x  veut dire  total = total + x
        total += 12.50m;
        total += 7.99m;
        total += 20m;

        // Étape 3
        Console.WriteLine("Total panier : " + total);

        // Étape 4 : total -= 5  veut dire  total = total - 5
        total -= 5m;
        Console.WriteLine("Après le bon : " + total);
    }
}
