// ===================================================================================
//  ✅ CORRECTION — EXO 018 — Déclarer un float
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Le suffixe f indique à C# que ce nombre à virgule est un float
        float poidsKg = 2.5f;
        Console.WriteLine($"Poids : {poidsKg} kg");

        // ❌ Erreur CS0664 : sans suffixe, 1.5 est un double, et C# refuse de le mettre
        //    dans un float. Il faut écrire 1.5f.
        // float poidsSucre = 1.5;
    }
}
