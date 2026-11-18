// ===================================================================================
//  ✅ CORRECTION — EXO 040 — Type valeur : on copie la valeur
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        int ageLea = 30;

        // On COPIE la valeur de ageLea (30) dans ageMarco :
        // ce sont deux « boîtes » séparées, chacune avec son propre 30
        int ageMarco = ageLea;

        // On change seulement la boîte de Marco
        ageMarco = 31;

        // Prédiction : Léa a toujours 30 ans.
        // int est un type VALEUR : modifier la copie (ageMarco) ne touche pas l'original (ageLea).
        Console.WriteLine($"Léa : {ageLea} ans");
        Console.WriteLine($"Marco : {ageMarco} ans");
    }
}
