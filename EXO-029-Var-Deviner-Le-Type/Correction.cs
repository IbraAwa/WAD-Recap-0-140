// ===================================================================================
//  ✅ CORRECTION — EXO 029 — var : laisser C# deviner le type
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Avec var, C# regarde la valeur à droite du = pour choisir le type.
        var nombre = 42;        // prédiction : int     (nombre entier)
        var nom = "Léa";        // prédiction : string  (texte entre " ")
        var prix = 9.99m;       // prédiction : decimal (à cause du suffixe m)

        // GetType() donne le « vrai nom » du type choisi par C#
        Console.WriteLine(nombre.GetType());   // System.Int32   = int
        Console.WriteLine(nom.GetType());      // System.String  = string
        Console.WriteLine(prix.GetType());     // System.Decimal = decimal
    }
}
