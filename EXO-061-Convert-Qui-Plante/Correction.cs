// ===================================================================================
//  ✅ CORRECTION — EXO 061 — Convert qui plante : FormatException
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. "abc" n'est pas un nombre : Convert.ToInt32 ne sait pas quoi en faire.
        // 2. 💥 Le programme plante avec l'exception : System.FormatException
        //    (le texte n'a pas le bon FORMAT pour être un nombre)
        //    → ligne mise en commentaire pour que le programme puisse aller jusqu'au bout :
        // int nombre = Convert.ToInt32("abc");

        // 3. Le message affiché à la place
        Console.WriteLine("Convert ne sait pas convertir abc");
    }
}
