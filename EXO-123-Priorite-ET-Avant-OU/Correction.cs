// ===================================================================================
//  ✅ CORRECTION — EXO 123 — Priorité : && passe avant ||
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Prédiction : True
        // && est calculé AVANT || (comme * avant +) :
        // false && false = false, puis true || false = true
        Console.WriteLine(true || false && false);

        // Prédiction : False
        // Les parenthèses forcent le || en premier : true || false = true, puis true && false = false
        Console.WriteLine((true || false) && false);
    }
}
