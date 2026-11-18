// ===================================================================================
//  ✅ CORRECTION — EXO 103 — Prédire commandes++ et ++commandes (slide 121 n°2)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        int commandes = 2;

        // commandes++ (POST) : a reçoit l'ancienne valeur (2), PUIS commandes passe à 3.
        int a = commandes++;

        // ++commandes (PRÉ) : commandes passe D'ABORD de 3 à 4, PUIS b reçoit 4.
        int b = ++commandes;

        // Prédiction : a = 2, b = 4, commandes = 4
        // (commandes a été augmentée deux fois : 2 → 3 → 4)
        Console.WriteLine($"a = {a}, b = {b}, commandes = {commandes}");
    }
}
