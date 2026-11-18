// ===================================================================================
//  ✅ CORRECTION — EXO 023 — Changer la valeur d'une variable
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        int age = 30;
        Console.WriteLine($"Âge : {age}");

        // Affectation : la variable existe déjà, on remplace juste sa valeur (sans int devant)
        age = 31;
        Console.WriteLine($"Âge : {age}");

        // ❌ Erreur CS0128 : une variable nommée age existe déjà ici.
        //    Avec int devant, on essaie d'en créer une deuxième avec le même nom.
        // int age = 32;
    }
}
