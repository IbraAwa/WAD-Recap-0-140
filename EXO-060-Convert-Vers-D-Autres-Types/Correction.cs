// ===================================================================================
//  ✅ CORRECTION — EXO 060 — Convert vers double, bool, et l'arrondi
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Dans un TEXTE, la virgule suit la langue du PC : en français on écrit "3,14"
        Console.WriteLine(Convert.ToDouble("3,14"));

        // 2. Dans le CODE, un nombre à virgule s'écrit toujours avec un point : 9.7
        //    Prédiction : Convert.ToInt32 ARRONDIT au plus proche → 10 (et pas 9)
        Console.WriteLine(Convert.ToInt32(9.7));

        // 3. Vers bool : 0 donne False, n'importe quel autre nombre donne True
        Console.WriteLine(Convert.ToBoolean(1));
        Console.WriteLine(Convert.ToBoolean(0));
    }
}
