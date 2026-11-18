// ===================================================================================
//  ✅ CORRECTION — EXO 058 — ToString : transformer en texte
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. ToString() sans rien entre les parenthèses : le texte « brut » du nombre
        int age = 30;
        string ageTexte = age.ToString();
        Console.WriteLine(ageTexte);

        // 2. Un bool aussi sait se transformer en texte : true devient "True" (avec une majuscule)
        bool actif = true;
        Console.WriteLine(actif.ToString());

        // 3. On donne le format "N2" à ToString : le même que dans {prix:N2}
        double prix = 9.5;
        Console.WriteLine(prix.ToString("N2"));
    }
}
