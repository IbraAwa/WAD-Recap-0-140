// ===================================================================================
//  ✅ CORRECTION — EXO 115 — is avec une variable (pattern matching)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        object prix = 19.99;

        // « prix is double valeur » : si prix est un double, la variable valeur (de type double)
        // est créée et contient le nombre. Pas besoin de conversion (double) à part.
        if (prix is double valeur)
        {
            Console.WriteLine($"C'est un prix : {valeur}");
        }

        // Dans la même condition, on peut déjà utiliser la variable créée par is.
        // Elle doit porter un autre nom (montant) : valeur existe déjà plus haut.
        if (prix is double montant && montant > 10)
        {
            Console.WriteLine("C'est cher !");
        }
    }
}
