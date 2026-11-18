// ===================================================================================
//  ✅ CORRECTION — EXO 122 — L'ordre de priorité des calculs (slide 141 n°5)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Prédiction : 14
        // * passe avant + : 3 * 4 = 12, puis 2 + 12 = 14
        Console.WriteLine(2 + 3 * 4);

        // Prédiction : 20
        // Les parenthèses passent en premier : 2 + 3 = 5, puis 5 * 4 = 20
        Console.WriteLine((2 + 3) * 4);

        // Prédiction : 6
        // D'abord * / % (de gauche à droite) : 2 * 3 = 6, 8 / 4 = 2, 2 % 3 = 2
        // Puis + - (de gauche à droite) : 10 - 6 = 4, 4 + 2 = 6
        Console.WriteLine(10 - 2 * 3 + 8 / 4 % 3);
    }
}
