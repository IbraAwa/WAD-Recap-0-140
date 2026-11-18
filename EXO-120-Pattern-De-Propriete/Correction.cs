// ===================================================================================
//  ✅ CORRECTION — EXO 120 — Tester une propriété : { Length: > 5 }
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        string mot = "Bonjour";

        // { Length: > 5 } : on regarde DANS le mot sa propriété Length et on vérifie qu'elle est > 5
        if (mot is { Length: > 5 })
        {
            Console.WriteLine("Mot long");
        }
        else
        {
            Console.WriteLine("Mot court");
        }

        Console.WriteLine($"Longueur : {mot.Length}");

        // Avec "Salut" (5 lettres) : 5 n'est pas > 5 → Mot court, puis Longueur : 5
    }
}
