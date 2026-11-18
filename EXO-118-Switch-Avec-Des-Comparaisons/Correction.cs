// ===================================================================================
//  ✅ CORRECTION — EXO 118 — switch avec des comparaisons (mention et âge)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        int note = 15;

        // Les branches sont testées de haut en bas, la PREMIÈRE qui correspond gagne.
        // On commence donc par la plus exigeante (>= 16) : si on mettait >= 10 en premier,
        // toutes les bonnes notes donneraient « Réussi ».
        // 15 : pas >= 16, mais >= 14 → "Bien"
        string mention = note switch
        {
            >= 16 => "Très bien",
            >= 14 => "Bien",
            >= 10 => "Réussi",
            _ => "Échec"        // _ attrape « tout le reste »
        };
        Console.WriteLine(mention);

        int age = 34;

        // 34 : pas < 18, mais < 65 → "adulte"
        string categorie = age switch
        {
            < 18 => "mineur",
            < 65 => "adulte",
            _ => "senior"
        };
        Console.WriteLine(categorie);
    }
}
