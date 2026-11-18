// ===================================================================================
//  ✅ CORRECTION — EXO 071 — Le bug des 24 % au lieu de 25 %
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1.
        int nbCommandes = 8;
        int nbLivrees = 2;

        // 2. D'abord 100 / nbCommandes, puis × nbLivrees
        int pct = 100 / nbCommandes * nbLivrees;

        // 3.
        Console.WriteLine($"{pct} %");

        // 4. Pourquoi 24 % au lieu de 25 % ?
        //    - Étape 1 : 100 / 8 → les deux sont des int, c'est une division ENTIÈRE :
        //                12,5 devient 12 (la partie ,5 est jetée).
        //    - Étape 2 : 12 * 2 = 24.
        //    Le ,5 perdu à l'étape 1 a été multiplié par 2 → on a perdu 1 % au total.
    }
}
