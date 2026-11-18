// ===================================================================================
//  ✅ CORRECTION — EXO 102 — ++x ou x++ ?
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // PRÉ-incrémentation (++x) : x augmente D'ABORD, puis sa nouvelle valeur est donnée à a.
        // x passe de 5 à 6, puis a reçoit 6.
        int x = 5;
        int a = ++x;

        // POST-incrémentation (y++) : b reçoit D'ABORD l'ancienne valeur de y, puis y augmente.
        // b reçoit 5, puis y passe de 5 à 6.
        int y = 5;
        int b = y++;

        // Prédiction : a = 6, x = 6 / b = 5, y = 6
        // Dans les deux cas la variable finit à 6 : seul le moment où on la lit change.
        Console.WriteLine($"a = {a}, x = {x}");
        Console.WriteLine($"b = {b}, y = {y}");
    }
}
