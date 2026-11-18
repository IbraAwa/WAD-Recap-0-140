// ===================================================================================
//  ✅ CORRECTION — EXO 032 — Les constantes (const)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // const = la valeur est fixée à la déclaration et ne pourra plus jamais changer.
        // Les constantes s'écrivent en PascalCase (majuscule au début de chaque mot).
        const double TauxTva = 0.21;
        const int JoursParSemaine = 7;
        const string Ecole = "BStorm";

        Console.WriteLine($"TVA : {TauxTva}");
        Console.WriteLine($"Jours par semaine : {JoursParSemaine}");
        Console.WriteLine($"École : {Ecole}");
    }
}
