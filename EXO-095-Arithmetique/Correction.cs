// ===================================================================================
//  ✅ CORRECTION — EXO 095 — Les opérateurs + - * / %
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int a = 17;
        int b = 5;

        // Étape 3 : prédictions
        //   a / b → 3  (entre deux int, la division est ENTIÈRE : 17 / 5 = 3, on perd le reste)
        //   a % b → 2  (le modulo donne le RESTE : 17 = 5 * 3 + 2)

        // Étape 2 : les calculs utilisent a et b ; {0} {1} {2} placent les valeurs dans le texte.
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
    }
}
