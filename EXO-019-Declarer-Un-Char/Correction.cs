// ===================================================================================
//  ✅ CORRECTION — EXO 019 — Déclarer un char
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un char contient UN SEUL caractère, entre simples guillemets ' '
        char initiale = 'L';
        char groupe = 'B';

        Console.WriteLine($"Initiale : {initiale}, groupe : {groupe}");

        // ❌ Erreur CS0029 : "A" entre doubles guillemets est un string (un texte),
        //    pas un char. Il faut écrire 'A'.
        // char lettre = "A";
    }
}
