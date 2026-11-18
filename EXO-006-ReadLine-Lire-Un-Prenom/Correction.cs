// ===================================================================================
//  ✅ CORRECTION — EXO 006 — ReadLine : lire un prénom
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Write (et pas WriteLine) : l'utilisateur tape sa réponse sur la même ligne
        Console.Write("Votre prénom : ");

        // Ce que l'utilisateur tape est rangé dans la variable prenom
        string? prenom = Console.ReadLine();

        // $ devant les guillemets + {prenom} = la valeur de la variable est insérée dans le texte
        Console.WriteLine($"Bonjour {prenom}");
    }
}
