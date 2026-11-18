// ===================================================================================
//  ✅ CORRECTION — EXO 008 — ReadKey : attendre une seule touche
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.WriteLine("Appuie sur n'importe quelle touche...");

        // Le programme attend UNE touche (pas besoin d'appuyer sur Entrée)
        Console.ReadKey();

        // La touche appuyée s'est affichée et le curseur est resté juste après : on revient à la ligne
        Console.WriteLine();

        Console.WriteLine("Touche reçue !");

        // a) ReadKey attend UNE SEULE touche et continue tout de suite, sans Entrée.
        //    ReadLine attend toute une ligne de texte et ne continue qu'après Entrée
        //    (et il renvoie le texte tapé, sous forme de string).
    }
}
