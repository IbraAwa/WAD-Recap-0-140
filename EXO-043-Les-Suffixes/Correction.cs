// ===================================================================================
//  ✅ CORRECTION — EXO 043 — Les suffixes L, F, D, M et U
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // La lettre à la fin du nombre force son type :
        var a = 5L;      // L = long    (System.Int64)
        var b = 3.14F;   // F = float   (System.Single)
        var c = 3.14D;   // D = double  (System.Double)
        var d = 9.99M;   // M = decimal (System.Decimal), pour l'argent
        var e = 5U;      // U = uint    (System.UInt32), entier sans signe (jamais négatif)

        // Le texte avant la flèche est écrit tel quel ; le type vient de GetType()
        Console.WriteLine($"5L    -> {a.GetType()}");
        Console.WriteLine($"3.14F -> {b.GetType()}");
        Console.WriteLine($"3.14D -> {c.GetType()}");
        Console.WriteLine($"9.99M -> {d.GetType()}");
        Console.WriteLine($"5U    -> {e.GetType()}");
    }
}
