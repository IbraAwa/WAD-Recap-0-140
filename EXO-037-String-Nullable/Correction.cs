// ===================================================================================
//  ✅ CORRECTION — EXO 037 — string? : un texte qui peut être null
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // string? : ce texte a le droit d'être null (pas de texte du tout)
        string? surnom = null;

        // null s'affiche comme rien : on ne voit que « Surnom : »
        Console.WriteLine($"Surnom : {surnom}");

        // ⚠️ Avertissement CS8600 (souligné en vert) : on met null dans un string SANS ?.
        //    Ça compile, mais C# prévient : cette variable a été déclarée comme « jamais null ».
        // string nom = null;

        // Un string sans ? doit contenir un vrai texte
        string nom = "Dupont";
        Console.WriteLine($"Nom : {nom}");

        // a) Pourquoi   string? prenom = Console.ReadLine();   avec un ? ?
        //    Parce que Console.ReadLine() peut renvoyer null (par exemple s'il n'y a plus rien
        //    à lire, quand l'entrée est fermée). Le ? dit honnêtement « ce texte peut être null » ;
        //    sans lui, on aurait un avertissement.
    }
}
