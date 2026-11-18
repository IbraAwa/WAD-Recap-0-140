// ===================================================================================
//  ✅ CORRECTION — EXO 038 — Déboguer : point d'arrêt et variables locales
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 🔴 Point d'arrêt (F9) sur la ligne ci-dessous, puis F5.
        //    La flèche jaune s'arrête AVANT d'exécuter la ligne : à ce moment, stock vaut 0
        //    dans « Variables locales » (la variable existe mais n'a pas encore reçu 10).
        int stock = 10;      // F10 → après cette ligne : stock = 10

        // On vend 3 articles : on retire 3 et on remet le résultat dans stock
        stock = stock - 3;   // F10 → après cette ligne : stock = 7

        // On reçoit une livraison de 5 articles
        stock = stock + 5;   // F10 → après cette ligne : stock = 12

        // F10 → « Stock final : 12 » s'affiche dans la console. Puis F5 pour finir (ou Maj+F5 pour arrêter).
        Console.WriteLine($"Stock final : {stock}");
    }
}
