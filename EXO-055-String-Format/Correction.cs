// ===================================================================================
//  ✅ CORRECTION — EXO 055 — string.Format
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        string nom = "Léa";
        int age = 30;

        // D'abord le modèle avec ses trous {0} et {1}, puis les valeurs dans l'ordre :
        // nom remplace {0}, age remplace {1}.
        // string.Format ne fait rien s'afficher : il FABRIQUE le texte, qu'on range dans phrase.
        string phrase = string.Format("{0} a {1} ans", nom, age);

        Console.WriteLine(phrase);
    }
}
