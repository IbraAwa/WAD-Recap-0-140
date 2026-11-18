// ===================================================================================
//  ✅ CORRECTION — EXO 104 — L'opérateur ternaire ? :
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        int age = 20;

        // condition ? valeur si vrai : valeur si faux
        // C'est un petit if ... else qui RENVOIE une valeur, qu'on range directement dans statut.
        string statut = age >= 18 ? "Majeur" : "Mineur";

        Console.WriteLine(statut);

        // Avec age = 12, la condition age >= 18 est fausse : statut vaut "Mineur".
    }
}
