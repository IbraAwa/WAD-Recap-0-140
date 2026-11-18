// ===================================================================================
//  ✅ CORRECTION — EXO 087 — Mélanger && et || avec des parenthèses
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 2 : 17 ans, il a sa carte, il est VIP
        int age = 17;
        bool aSaCarteDIdentite = true;
        bool estVip = true;

        // Étape 3 : la règle est "VIP, OU (majeur ET carte)".
        // Les parenthèses regroupent les deux conditions qui vont ensemble :
        // être majeur sans carte (ou l'inverse) ne suffit pas.
        if (estVip || (age >= 18 && aSaCarteDIdentite))
        {
            Console.WriteLine("Entrée autorisée");
        }
        else
        {
            Console.WriteLine("Entrée refusée");
        }

        // Étape 4 : tests
        //   17 ans, carte, VIP      → true  || (false && true) = true  → Entrée autorisée
        //   17 ans, carte, pas VIP  → false || (false && true) = false → Entrée refusée
        //   20 ans, carte, pas VIP  → false || (true && true)  = true  → Entrée autorisée
    }
}
