// ===================================================================================
//  ✅ CORRECTION — EXO 059 — Convert.ToInt32 : du texte vers un nombre
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Entre guillemets : c'est du TEXTE, pas un nombre
        string quantiteTexte = "42";

        // 2. Texte + nombre = on COLLE les deux (concaténation) : "42" + 1 → "421"
        Console.WriteLine(quantiteTexte + 1);

        // 3. Convert.ToInt32 transforme le texte "42" en vrai nombre 42
        int quantite = Convert.ToInt32(quantiteTexte);

        // 4. Maintenant c'est un vrai nombre : + fait une addition → 43
        Console.WriteLine(quantite + 1);
    }
}
