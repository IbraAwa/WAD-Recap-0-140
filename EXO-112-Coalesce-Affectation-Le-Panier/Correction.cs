// ===================================================================================
//  ✅ CORRECTION — EXO 112 — Coalesce et affectation ??= (slide 126 n°4)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // List<string>? : le ? autorise le panier à valoir null (il n'existe pas encore)
        List<string>? panier = null;

        // ??= : panier est null, donc on lui donne une nouvelle liste vide
        panier ??= new List<string>();

        panier.Add("pain");

        // Prédiction : NON, le panier n'est pas remplacé.
        // Il n'est plus null (il contient déjà "pain"), donc ??= ne fait rien.
        panier ??= new List<string>();

        Console.WriteLine($"Nombre d'articles : {panier.Count}");

        // string.Join colle tous les éléments en les séparant par ", "
        Console.WriteLine(string.Join(", ", panier));
    }
}
