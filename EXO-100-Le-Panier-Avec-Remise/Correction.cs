// ===================================================================================
//  ✅ CORRECTION — EXO 100 — Le panier avec remise (slide 121 n°1)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : double imposé ici (pas besoin de suffixe : 12.50 est déjà un double)
        double total = 0;

        // Étape 2 : on ajoute les trois articles
        total += 12.50;
        total += 7.99;
        total += 20;

        // Étape 3 : 10 % de remise → on garde 90 %
        total *= 0.9;
        Console.WriteLine("Total : " + total);

        // Étape 4 : le bon de 5
        total -= 5;
        Console.WriteLine("Après le bon : " + total);

        // a) Un double stocke les nombres en binaire (base 2), et beaucoup de nombres à virgule
        //    comme 0,9 ou 7,99 ne peuvent pas y être écrits exactement : ils sont arrondis.
        //    Ces minuscules erreurs s'accumulent au fil des calculs et finissent par se voir
        //    (31,441000000000003). Pour de l'argent, on préfère donc le type decimal (suffixe m).
    }
}
