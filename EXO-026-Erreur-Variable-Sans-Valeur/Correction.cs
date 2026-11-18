// ===================================================================================
//  ✅ CORRECTION — EXO 026 — L'erreur CS0165 : variable sans valeur
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // La boîte existe, mais elle est encore vide
        int compteur;

        // ❌ Erreur CS0165 : utilisation d'une variable locale non assignée.
        //    C# refuse d'afficher compteur car on ne lui a encore donné aucune valeur.
        // Console.WriteLine(compteur);

        // On lui donne une valeur : maintenant on peut l'utiliser
        compteur = 0;
        Console.WriteLine(compteur);
    }
}
