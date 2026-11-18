// ===================================================================================
//  ✅ CORRECTION — EXO 062 — Parse : int.Parse, double.Parse, bool.Parse
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // On appelle Parse sur le type qu'on veut OBTENIR, et on lui donne le texte.

        // 1. texte → int
        int a = int.Parse("42");
        Console.WriteLine(a);

        // 2. texte → double (sur un PC en français, la virgule du texte est ",")
        double b = double.Parse("3,14");
        Console.WriteLine(b);

        // 3. texte → bool ("true" ou "True" sont acceptés)
        bool c = bool.Parse("true");
        Console.WriteLine(c);
    }
}
