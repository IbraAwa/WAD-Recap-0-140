// ===================================================================================
//  ✅ CORRECTION — EXO 074 — Arrondir avec Math.Round
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Math.Round arrondit au plus proche, mais renvoie un double :
        //    le cast (int) sert ensuite à obtenir un vrai entier.
        Console.WriteLine((int)Math.Round(9.44));   // 9.44 → 9
        Console.WriteLine((int)Math.Round(9.99));   // 9.99 → 10

        // 2. Convert.ToInt32 arrondit lui aussi (contrairement au cast (int) qui coupe)
        Console.WriteLine(Convert.ToInt32(9.99));   // 10

        // 3. PIÈGE : pour un nombre pile au milieu (,5), Math.Round va par défaut vers
        //    le nombre PAIR le plus proche (« arrondi bancaire ») : 2.5 → 2 (et 3.5 → 4)
        Console.WriteLine(Math.Round(2.5));

        // Avec MidpointRounding.AwayFromZero, le ,5 s'éloigne de zéro : 2.5 → 3
        // (c'est l'arrondi « de l'école »)
        Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
    }
}
