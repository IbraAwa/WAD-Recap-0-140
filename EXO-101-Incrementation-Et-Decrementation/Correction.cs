// ===================================================================================
//  ✅ CORRECTION — EXO 101 — ++ et --
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int commandes = 0;

        // Étape 2 : commandes++ ajoute exactement 1 (comme commandes += 1)
        commandes++;
        commandes++;
        commandes++;
        Console.WriteLine("Commandes : " + commandes);

        // Étape 3 : commandes-- retire exactement 1
        commandes--;
        Console.WriteLine("Commandes : " + commandes);
    }
}
