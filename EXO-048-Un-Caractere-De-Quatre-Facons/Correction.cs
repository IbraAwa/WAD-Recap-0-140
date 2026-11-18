// ===================================================================================
//  ✅ CORRECTION — EXO 048 — Un caractère de quatre façons
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        char c1 = 'A';            // la lettre, tout simplement
        char c2 = 'A';       // son code Unicode (\u + 4 chiffres hexadécimaux)
        char c3 = '\x41';         // son code hexadécimal (\x + chiffres hexadécimaux)
        char c4 = (char)65;       // le nombre 65 converti (cast) en char

        Console.WriteLine($"{c1} {c2} {c3} {c4}");

        // a) Que remarques-tu ? Pourquoi 65 ?
        //    Les 4 variables affichent la même lettre A : c'est le même caractère, écrit autrement.
        //    Pour l'ordinateur, un caractère est un NUMÉRO : A porte le numéro 65 dans la table
        //    des caractères (ASCII / Unicode). En hexadécimal, 65 s'écrit 41 → d'où A et \x41.
    }
}
