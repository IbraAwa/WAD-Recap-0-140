// ===================================================================================
//  ✅ CORRECTION — EXO 099 — Les raccourcis *= /= et %=
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1 : de l'argent → decimal
        decimal total = 40m;

        // Étape 2 : retirer 10 %, c'est garder 90 % → on multiplie par 0,9.
        // total *= 0.9m  veut dire  total = total * 0.9m  (40 * 0,9 = 36,0)
        total *= 0.9m;
        Console.WriteLine("Après remise : " + total);

        // Étape 3 : total /= 4  veut dire  total = total / 4  (36,0 / 4 = 9,0)
        total /= 4m;
        Console.WriteLine("Chacun paie : " + total);

        // Étape 4 : 130 minutes = 2 heures complètes (120 min) + 10 minutes.
        // minutes %= 60  veut dire  minutes = minutes % 60  → il reste 10
        int minutes = 130;
        minutes %= 60;
        Console.WriteLine("Minutes en plus : " + minutes);
    }
}
