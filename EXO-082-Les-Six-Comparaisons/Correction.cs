// ===================================================================================
//  ✅ CORRECTION — EXO 082 — Les 6 opérateurs de comparaison
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int note = 12;

        // Étape 3 : prédictions (avant de lancer)
        //   note == 12 → True   (12 est bien égal à 12)
        //   note != 12 → False  (12 n'est PAS différent de 12)
        //   note < 10  → False  (12 n'est pas plus petit que 10)
        //   note <= 12 → True   (12 est égal à 12, donc "plus petit OU égal" est vrai)
        //   note > 15  → False  (12 n'est pas plus grand que 15)
        //   note >= 10 → True   (12 est plus grand que 10)

        // Étapes 2 et 4 : chaque comparaison donne un booléen (True ou False),
        // qu'on peut afficher directement. Les parenthèses autour de la comparaison
        // la font calculer AVANT de la coller au texte.
        Console.WriteLine("note == 12 : " + (note == 12));
        Console.WriteLine("note != 12 : " + (note != 12));
        Console.WriteLine("note < 10  : " + (note < 10));
        Console.WriteLine("note <= 12 : " + (note <= 12));
        Console.WriteLine("note > 15  : " + (note > 15));
        Console.WriteLine("note >= 10 : " + (note >= 10));

        // Rappel : = range une valeur (note = 12), == compare deux valeurs (note == 12).
    }
}
