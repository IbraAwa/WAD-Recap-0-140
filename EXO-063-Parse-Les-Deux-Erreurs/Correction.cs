// ===================================================================================
//  ✅ CORRECTION — EXO 063 — Les deux erreurs de Parse
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. 💥 System.FormatException : "12abc" contient des lettres, ce n'est pas un nombre
        // int x = int.Parse("12abc");

        // 2. 💥 System.OverflowException : 99999999999 est bien un nombre, mais il est
        //    TROP GRAND pour un int (le maximum est 2 147 483 647)
        // int y = int.Parse("99999999999");

        // 3.
        Console.WriteLine("Les deux lignes qui plantent sont en commentaire");

        // a) Différence entre les deux :
        //    - FormatException   → le texte n'est PAS un nombre (mauvais format : lettres, symboles...)
        //    - OverflowException → le texte EST un nombre, mais il ne rentre pas dans le type demandé
        //                          (il « déborde » : trop grand ou trop petit pour un int)
    }
}
