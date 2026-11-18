// ===================================================================================
//  ✅ CORRECTION — EXO 084 — Le OU : ||
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 2 : 6 = samedi
        int jour = 6;

        // Étape 3 : || (OU) → la condition est vraie dès qu'AU MOINS UNE des deux parties est vraie.
        // Il faut répéter "jour ==" de chaque côté : C# ne comprend pas "jour == 6 || 7".
        if (jour == 6 || jour == 7)
        {
            Console.WriteLine("C'est le week-end !");
        }
        else
        {
            Console.WriteLine("Au travail !");
        }
    }
}
