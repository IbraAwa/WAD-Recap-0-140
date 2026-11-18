// ===================================================================================
//  ✅ CORRECTION — EXO 068 — char vers int : le code de la lettre
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Un char s'écrit entre apostrophes ' ' (et pas entre guillemets)
        char lettre = 'A';

        // Un char est en réalité un numéro : on peut le ranger tel quel dans un int
        int code = lettre;
        Console.WriteLine($"{lettre} -> {code}");

        // 2. Même chose avec a minuscule : son code est différent (97, pas 65)
        lettre = 'a';
        code = lettre;
        Console.WriteLine($"{lettre} -> {code}");
    }
}
