// ===================================================================================
//  ✅ CORRECTION — EXO 117 — Les patterns and, or, not
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. note n'est écrite qu'UNE fois : les deux comparaisons sont reliées par and
        int note = 15;
        bool reussi = note is >= 10 and <= 20;
        Console.WriteLine($"Réussi : {reussi}");

        // 2. Un char s'écrit entre apostrophes simples : 'e' (et pas "e").
        //    or : il suffit qu'UNE des valeurs corresponde.
        char lettre = 'e';
        bool voyelle = lettre is 'a' or 'e' or 'i' or 'o' or 'u';
        Console.WriteLine($"Voyelle : {voyelle}");

        // 3. Même test avec && : cette fois, il faut répéter note dans chaque comparaison
        bool reussiAvecEt = note >= 10 && note <= 20;
        Console.WriteLine($"Réussi (avec &&) : {reussiAvecEt}");
    }
}
