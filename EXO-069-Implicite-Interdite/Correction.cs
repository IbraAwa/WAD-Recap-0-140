// ===================================================================================
//  ✅ CORRECTION — EXO 069 — long vers int : refusé par C#
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1.
        long stock = 3000;

        // 2. ❌ Erreur de compilation CS0266 :
        //    « Impossible de convertir implicitement le type 'long' en 'int'.
        //      Une conversion explicite existe (un cast est-il manquant ?) »
        // int quantite = stock;

        // 3.
        Console.WriteLine(stock);

        // a) C# ne regarde pas la VALEUR (3000) mais le TYPE (long).
        //    Un long peut contenir des nombres bien trop grands pour un int :
        //    le ranger dans un int pourrait faire perdre des données.
        //    Par sécurité, C# refuse donc de le faire tout seul.
    }
}
