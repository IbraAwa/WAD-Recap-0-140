// ===================================================================================
//  ✅ CORRECTION — EXO 047 — Afficher des guillemets et un antislash
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un " seul fermerait le texte : \" veut dire « un vrai guillemet à afficher »
        Console.WriteLine("Il a dit \"bonjour\"");

        // Le \ seul annonce un caractère spécial : \\ veut dire « un vrai antislash »
        Console.WriteLine("C:\\Users\\Lea\\Documents");

        // Même astuce pour un char : ' seul fermerait le caractère, donc on écrit \'
        char apostrophe = '\'';
        Console.WriteLine(apostrophe);
    }
}
