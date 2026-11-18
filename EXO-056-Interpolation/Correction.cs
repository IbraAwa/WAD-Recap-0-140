// ===================================================================================
//  ✅ CORRECTION — EXO 056 — L'interpolation avec $
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        string nom = "Léa";
        int age = 30;

        // Le $ devant les guillemets : ce qui est entre { } est remplacé par la valeur de la variable
        Console.WriteLine($"{nom} a {age} ans");

        // Entre { } on peut aussi mettre un petit calcul : age + 10 est calculé (40) puis inséré.
        // La variable age, elle, vaut toujours 30.
        Console.WriteLine($"Dans 10 ans, {nom} aura {age + 10} ans");
    }
}
