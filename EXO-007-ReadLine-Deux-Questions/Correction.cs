// ===================================================================================
//  ✅ CORRECTION — EXO 007 — Poser deux questions
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.Write("Votre prénom : ");
        string? prenom = Console.ReadLine();

        Console.Write("Votre ville : ");
        string? ville = Console.ReadLine();

        Console.WriteLine($"{prenom} habite à {ville}");
    }
}
