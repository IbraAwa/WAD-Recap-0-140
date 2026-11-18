// ===================================================================================
//  ✅ CORRECTION — EXO 003 — Sauter une ligne
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.WriteLine("Liste de courses :");

        // WriteLine sans texte : n'affiche rien, mais passe quand même à la ligne
        Console.WriteLine();

        Console.WriteLine("- pain");
        Console.WriteLine("- lait");
        Console.WriteLine("- oeufs");
    }
}
