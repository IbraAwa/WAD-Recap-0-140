// ===================================================================================
//  ✅ CORRECTION — EXO 004 — Write : écrire sans revenir à la ligne
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.Write("Bonjour ");   // l'espace à la fin sépare les deux mots
        Console.Write("à tous");     // s'écrit juste à la suite, sur la même ligne
        Console.WriteLine();         // on revient à la ligne sans rien afficher
        Console.WriteLine("Deuxième ligne");

        // a) Console.Write affiche le texte et laisse le curseur juste après (même ligne).
        //    Console.WriteLine affiche le texte PUIS passe à la ligne suivante.
    }
}
