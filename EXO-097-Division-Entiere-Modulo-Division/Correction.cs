// ===================================================================================
//  ✅ CORRECTION — EXO 097 — Division entière, modulo et division (slide 141 n°1)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int a = 5;
        int b = 2;

        // Étape 2 : entre deux int, / donne la division ENTIÈRE (5 / 2 = 2)
        Console.WriteLine("Division entière : " + a / b);

        // % donne le reste : 5 = 2 * 2 + 1
        Console.WriteLine("Modulo : " + a % b);

        // Étape 3 : (double)a transforme a en 5,0 AVANT la division.
        // Comme un des deux est un nombre à virgule, la division garde la virgule : 2,5
        Console.WriteLine("Division : " + (double)a / b);
    }
}
