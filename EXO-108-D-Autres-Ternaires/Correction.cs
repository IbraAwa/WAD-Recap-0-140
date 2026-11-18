// ===================================================================================
//  ✅ CORRECTION — EXO 108 — D'autres ternaires (slide 122)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. « au moins un article » = stock >= 1 (ou stock > 0)
        int stock = 0;
        Console.WriteLine(stock >= 1 ? "En stock" : "Rupture");

        // 2. « avant 12h » = heure < 12 ; 14 n'est pas < 12 donc on prend la valeur « si faux »
        int heure = 14;
        Console.WriteLine(heure < 12 ? "Bonjour" : "Bon après-midi");

        // 3. Ici le ternaire renvoie un NOMBRE : les deux branches doivent être des nombres.
        //    10 % du prix = prix * 0.1 (un dixième)
        double prix = 120;
        double remise = prix >= 100 ? prix * 0.1 : 0;
        Console.WriteLine($"Remise : {remise}");
    }
}
