// ===================================================================================
//  ✅ CORRECTION — EXO 079 — Le if tout seul
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1.
        int age = 20;

        // 2. Le bloc { } ne s'exécute QUE si la condition (age >= 18) est vraie
        if (age >= 18)
        {
            Console.WriteLine("Tu peux voter");
        }

        // 3. En dehors du bloc du if : s'exécute dans TOUS les cas
        Console.WriteLine("Fin du programme");

        // 4. Avec age = 15 : la condition est fausse, le bloc du if est sauté.
        //    Seul « Fin du programme » s'affiche.
    }
}
