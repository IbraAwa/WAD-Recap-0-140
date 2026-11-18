// ===================================================================================
//  ✅ CORRECTION — EXO 045 — Le séparateur _ pour les grands nombres
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 8 milliards dépasse la limite d'un int (environ 2,1 milliards) : il faut un long
        long populationMondiale = 8_000_000_000;

        // 1 250 000 tient sans problème dans un int
        int habitantsBruxelles = 1_250_000;

        // De l'argent → decimal, avec le suffixe m (et un point pour la virgule dans le code)
        decimal prixVoiture = 24_999.99m;

        Console.WriteLine(populationMondiale);
        Console.WriteLine(habitantsBruxelles);
        Console.WriteLine(prixVoiture);

        // a) Le _ s'affiche-t-il à l'écran ?
        //    Non : le _ sert seulement à rendre le nombre plus lisible dans le CODE.
        //    C# l'ignore complètement, la valeur est la même que sans _.
    }
}
