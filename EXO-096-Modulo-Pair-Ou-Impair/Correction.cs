// ===================================================================================
//  ✅ CORRECTION — EXO 096 — Le modulo pour savoir si c'est pair
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : % donne le RESTE de la division
        Console.WriteLine(8 % 2); // 8 = 2 * 4 + 0 → reste 0
        Console.WriteLine(7 % 2); // 7 = 2 * 3 + 1 → reste 1

        // Étape 2 : un nombre est pair quand le reste de sa division par 2 vaut 0
        int nombre = 7;
        if (nombre % 2 == 0)
        {
            Console.WriteLine("pair");
        }
        else
        {
            Console.WriteLine("impair");
        }
    }
}
