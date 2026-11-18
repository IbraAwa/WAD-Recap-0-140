// ===================================================================================
//  ✅ CORRECTION — EXO 011 — Les commentaires
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        /*
           Prénom : Léa
           Date : 18/11/2026
           Exercice : EXO 011 - Les commentaires
        */
        // ↑ Tout ce qui est entre /* et */ est ignoré par C#, même sur plusieurs lignes.

        // Affiche le message d'accueil du cinéma
        Console.WriteLine("Bienvenue au cinéma");

        // Cette ligne a été mise en commentaire avec Ctrl+K puis Ctrl+C :
        // C# l'ignore, donc elle ne s'affiche pas quand on lance.
        // Console.WriteLine("Je ne dois pas m'afficher");
    }
}
