// ===================================================================================
//  ✅ CORRECTION — EXO 067 — Conversion implicite : C# le fait tout seul
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1.
        int quantite = 3;

        // 2. int → long : un long est plus « grand » qu'un int, tout int rentre dedans
        //    sans rien perdre. C# convertit donc tout seul (conversion implicite).
        long stock = quantite;

        // 3. Même chose vers double et vers decimal : aucun risque de perte, rien à écrire
        double quantiteDouble = quantite;
        decimal quantiteDecimal = quantite;

        // 4.
        Console.WriteLine(stock);
        Console.WriteLine(quantiteDouble);
        Console.WriteLine(quantiteDecimal);
    }
}
