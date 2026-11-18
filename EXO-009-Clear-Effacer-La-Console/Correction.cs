// ===================================================================================
//  ✅ CORRECTION — EXO 009 — Clear : effacer la console
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.WriteLine("Ce texte va disparaître");

        // On attend une touche (comme à l'exercice 8)
        Console.ReadKey();

        // Tout ce qui est affiché dans la console est effacé
        Console.Clear();

        Console.WriteLine("Écran propre !");

        // a) Le titre « EXO 009 - ... » a été affiché dans la console AVANT le Clear.
        //    Console.Clear() efface TOUT ce qui est à l'écran, sans faire de différence :
        //    le titre disparaît donc avec le reste.
    }
}
