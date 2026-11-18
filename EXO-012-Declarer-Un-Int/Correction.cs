// ===================================================================================
//  ✅ CORRECTION — EXO 012 — Déclarer un int
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Le type (int), le nom (age), puis la valeur rangée dedans (30)
        int age = 30;

        // Pas de guillemets : on veut la VALEUR de la variable, pas le mot « age »
        Console.WriteLine(age);

        // Avec le $ devant les guillemets, {age} est remplacé par la valeur de la variable
        Console.WriteLine($"Léa a {age} ans");
    }
}
