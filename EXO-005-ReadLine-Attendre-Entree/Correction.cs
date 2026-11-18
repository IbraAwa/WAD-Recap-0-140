// ===================================================================================
//  ✅ CORRECTION — EXO 005 — ReadLine : attendre la touche Entrée
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.WriteLine("Appuie sur Entrée pour continuer...");

        // Le programme s'arrête ici tant que l'utilisateur n'a pas appuyé sur Entrée.
        // On ne garde pas ce qui a été tapé : on ne range le résultat dans aucune variable.
        Console.ReadLine();

        Console.WriteLine("Merci, on continue !");
    }
}
