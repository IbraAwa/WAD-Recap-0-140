// ===================================================================================
//  ✅ CORRECTION — EXO 121 — L'opérateur as
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        object o = "Bonjour";

        // as essaie la conversion. Ici o contient bien un string, donc ça marche.
        // string? car as renvoie null quand la conversion est impossible.
        string? texte = o as string;
        Console.WriteLine(texte);

        // o ne contient pas un int : as ne plante pas, il renvoie simplement null.
        // int? (un int qui accepte null) peut recevoir ce null.
        int? nombre = o as int?;
        Console.WriteLine(nombre is null);

        // ❌ Erreur CS0077 : as ne marche qu'avec un type qui accepte null.
        //    Un int normal ne peut pas valoir null, donc as n'aurait rien à renvoyer en cas d'échec.
        // int entier = o as int;
    }
}
