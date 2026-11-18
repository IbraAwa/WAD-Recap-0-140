// ===================================================================================
//  ✅ CORRECTION — EXO 089 — Le piège des if séparés
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int note = 17;

        // Étape 2 : 3 if SÉPARÉS → chaque if est testé, indépendamment des autres.
        // 17 est >= 16, >= 14 ET >= 10 : les 3 messages s'affichent.
        Console.WriteLine("-- mauvaise manière --");
        if (note >= 16)
        {
            Console.WriteLine("Très bien");
        }
        if (note >= 14)
        {
            Console.WriteLine("Bien");
        }
        if (note >= 10)
        {
            Console.WriteLine("Réussi");
        }

        // Étape 3 : avec else if, C# s'arrête au PREMIER cas vrai et saute les suivants.
        Console.WriteLine("-- bonne manière --");
        if (note >= 16)
        {
            Console.WriteLine("Très bien");
        }
        else if (note >= 14)
        {
            Console.WriteLine("Bien");
        }
        else if (note >= 10)
        {
            Console.WriteLine("Réussi");
        }

        // Étape 4 : mauvaise manière → 3 lignes ; bonne manière → 1 seule ligne.
    }
}
