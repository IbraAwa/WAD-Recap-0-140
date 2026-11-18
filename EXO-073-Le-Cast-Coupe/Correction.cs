// ===================================================================================
//  ✅ CORRECTION — EXO 073 — Le cast coupe, il n'arrondit pas
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Prédiction : 9 et 9.
        //    Le cast (int) COUPE simplement tout ce qui est après la virgule, il n'arrondit pas.

        // 2. 9.44 → on coupe ,44 → 9
        Console.WriteLine((int)9.44);

        // 9.99 → on coupe ,99 → 9 (et pas 10 !)
        Console.WriteLine((int)9.99);
    }
}
