// ===================================================================================
//  ✅ CORRECTION — EXO 085 — Le NON : !
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : ! inverse un booléen.
        // Prédiction : le contraire de true est False, le contraire de false est True.
        Console.WriteLine(!true);
        Console.WriteLine(!false);

        // Étape 2 : le magasin n'est pas fermé → estFerme vaut false
        bool estFerme = false;

        // Étape 3 : !estFerme se lit "PAS fermé". Comme estFerme vaut false,
        // !estFerme vaut true → on entre dans le if.
        if (!estFerme)
        {
            Console.WriteLine("Le magasin est ouvert, entrez !");
        }
    }
}
