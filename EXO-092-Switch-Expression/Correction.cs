// ===================================================================================
//  ✅ CORRECTION — EXO 092 — L'expression switch
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int jour = 7;

        // Étape 2 : l'expression switch CALCULE une valeur qu'on range dans nomJour.
        // Chaque ligne associe une valeur (à gauche de =>) à un résultat (à droite).
        //   6 or 7 → accepte les deux valeurs
        //   _      → tous les autres cas (comme default)
        string nomJour = jour switch
        {
            1 => "Lundi",
            2 => "Mardi",
            3 => "Mercredi",
            4 => "Jeudi",
            5 => "Vendredi",
            6 or 7 => "Week-end",
            _ => "Autre jour"
        }; // c'est une affectation : point-virgule après l'accolade

        // Étape 3
        Console.WriteLine(nomJour);
    }
}
