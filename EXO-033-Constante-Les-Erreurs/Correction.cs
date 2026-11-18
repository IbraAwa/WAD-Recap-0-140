// ===================================================================================
//  ✅ CORRECTION — EXO 033 — Les erreurs avec une constante
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // C'est de l'argent : on prend un decimal (avec le suffixe m)
        const decimal PrixEntree = 11.50m;
        Console.WriteLine($"Prix d'entrée : {PrixEntree} euros");

        // ❌ Erreur CS0131 : la partie gauche d'une affectation doit être une variable.
        //    Une constante n'est pas une variable : sa valeur ne peut plus changer.
        // PrixEntree = 12m;

        // ❌ Erreur CS0145 : une constante doit recevoir une valeur dès sa déclaration.
        // const int Annee;
    }
}
