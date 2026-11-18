// ===================================================================================
//  ✅ CORRECTION — EXO 031 — La portée d'une variable
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // a est créée en dehors des accolades du if
        int a = 1;

        // Ce bloc ne s'exécute que si a est plus grand que 0 (ici oui, car a vaut 1)
        if (a > 0)
        {
            // b est créée DANS les accolades : elle n'existe qu'ici
            int b = 2;
            Console.WriteLine(a + b);
        }

        // ❌ Erreur CS0103 : le nom b n'existe pas dans le contexte actuel.
        //    Après l'accolade fermante, b a disparu.
        // Console.WriteLine(b);

        // a) a est déclarée au niveau du dessus : elle existe dans ce niveau ET dans
        //    tous les blocs { } qu'il contient. b est déclarée dans le bloc du if :
        //    elle n'existe que entre ses accolades { }, et disparaît après.
    }
}
