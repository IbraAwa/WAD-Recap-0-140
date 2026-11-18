// ===================================================================================
//  ✅ CORRECTION — EXO 107 — Ternaire : pair ou impair (slide 121 n°5)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.Write("Un nombre : ");
        int nombre = int.Parse(Console.ReadLine()!);

        // Un nombre pair divisé par 2 a un reste de 0 : nombre % 2 == 0 veut donc dire « pair »
        string parite = nombre % 2 == 0 ? "pair" : "impair";

        Console.WriteLine($"{nombre} est {parite}");
    }
}
