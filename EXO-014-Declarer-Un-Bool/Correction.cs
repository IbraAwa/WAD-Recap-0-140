// ===================================================================================
//  ✅ CORRECTION — EXO 014 — Déclarer un bool
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un bool ne peut valoir que true (vrai) ou false (faux), sans guillemets
        bool estOuvert = true;
        bool estComplet = false;

        // On affiche les variables : on n'écrit pas True / False nous-mêmes dans le texte
        Console.WriteLine($"Magasin ouvert : {estOuvert}");
        Console.WriteLine($"Magasin complet : {estComplet}");

        // a) Dans le code on écrit true (en minuscules), mais à l'écran C# affiche True,
        //    avec une majuscule (et False pour false).
    }
}
