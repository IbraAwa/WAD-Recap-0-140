// ===================================================================================
//  ✅ CORRECTION — EXO 116 — is null, is not null et is 404
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. int? : un entier qui a le droit de valoir null. « is 404 » teste une valeur précise.
        int? code = 404;
        if (code is 404)
        {
            Console.WriteLine("Page introuvable");
        }

        // 2. « is null » : vrai quand la variable ne contient rien
        string? nom = null;
        if (nom is null)
        {
            Console.WriteLine("Pas de nom");
        }

        // 3. « is not null » : not inverse le test → vrai quand la variable contient quelque chose
        nom = "Léa";
        if (nom is not null)
        {
            Console.WriteLine(nom);
        }
    }
}
