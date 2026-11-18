// ===================================================================================
//  ✅ CORRECTION — EXO 042 — Le type des valeurs écrites dans le code
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Avec var, C# choisit le type à partir de la valeur écrite :
        var a = 5;        // nombre entier sans virgule        → int    (System.Int32)
        var b = 'a';      // un seul caractère entre apostrophes → char   (System.Char)
        var c = 3.14;     // nombre à virgule sans suffixe      → double (System.Double)
        var d = "Test";   // texte entre guillemets             → string (System.String)

        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());
        Console.WriteLine(c.GetType());
        Console.WriteLine(d.GetType());
    }
}
