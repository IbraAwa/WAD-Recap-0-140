// ===================================================================================
//  ✅ CORRECTION — EXO 057 — Formater un prix : N2, C et l'alignement
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Pour de l'argent, on choisit decimal (calculs exacts, pas d'erreurs d'arrondi).
        //    Le suffixe m indique au compilateur que 1234.5 est un decimal.
        decimal prix = 1234.5m;

        // 2. :N2 → 2 chiffres après la virgule + séparateur de milliers
        Console.WriteLine($"{prix:N2}");

        // 3. :C → format monnaie (le symbole € vient de la langue du PC)
        Console.WriteLine($"{prix:C}");

        // 4. La largeur se met après une virgule dans les { } :
        //    10 → zone de 10 caractères, texte collé à DROITE
        //    -10 → zone de 10 caractères, texte collé à GAUCHE
        string nom = "Léa";
        Console.WriteLine($"[{nom,10}]");
        Console.WriteLine($"[{nom,-10}]");
    }
}
