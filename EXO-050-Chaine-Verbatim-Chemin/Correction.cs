// ===================================================================================
//  ✅ CORRECTION — EXO 050 — La chaîne verbatim @ pour un chemin
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Chaîne « normale » : chaque \ doit être doublé
        string chemin1 = "C:\\Users\\Lea\\cours";

        // Chaîne verbatim (@ devant) : le \ n'est plus spécial, on l'écrit une seule fois
        string chemin2 = @"C:\Users\Lea\cours";

        // Les deux affichent exactement le même chemin : ils sont identiques
        Console.WriteLine(chemin1);
        Console.WriteLine(chemin2);

        // Avec @, \" ne marche plus : pour afficher un guillemet, on le double ("")
        Console.WriteLine(@"Il a dit ""bonjour""");
    }
}
