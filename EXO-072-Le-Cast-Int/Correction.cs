// ===================================================================================
//  ✅ CORRECTION — EXO 072 — Le cast (int)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1.
        int nbCommandes = 8;
        int nbLivrees = 2;

        // 2. ❌ Erreur de compilation CS0266 :
        //    « Impossible de convertir implicitement le type 'float' en 'int' »
        //    100f / 8 * 2 donne un float (25), et C# refuse de le ranger tout seul dans un int.
        // int pct = 100f / nbCommandes * nbLivrees;

        // 3. Le cast (int) porte sur TOUT le calcul grâce aux parenthèses :
        //    on calcule d'abord 100f / 8 * 2 = 12,5 * 2 = 25 (aucune perte), puis on convertit en int.
        int pct = (int)(100f / nbCommandes * nbLivrees);
        Console.WriteLine($"{pct} %");
    }
}
