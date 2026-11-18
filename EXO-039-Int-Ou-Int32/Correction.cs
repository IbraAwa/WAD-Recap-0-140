// ===================================================================================
//  ✅ CORRECTION — EXO 039 — int ou Int32 : le même type
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // int est le mot-clé C#, Int32 est le nom « .NET » du même type
        int a = 5;
        Int32 b = 5;

        // GetType() donne le vrai nom du type : les deux affichent System.Int32
        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());

        // Même principe pour string : c'est un raccourci pour System.String
        string s = "Bonjour";
        Console.WriteLine(s.GetType());

        // a) int et Int32, est-ce le même type ?
        //    Oui : int est juste un raccourci (un alias) pour System.Int32.
        //    On préfère écrire int, c'est plus court et c'est l'usage en C#.
    }
}
