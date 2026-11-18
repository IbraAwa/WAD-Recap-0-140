// ===================================================================================
//  ✅ CORRECTION — EXO 064 — Lire un nombre tapé par l'utilisateur
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Write (et pas WriteLine) : le curseur reste sur la même ligne pour la réponse
        Console.Write("Ton âge : ");

        // 2. En une seule instruction : ReadLine lit le texte tapé, int.Parse le transforme en entier.
        //    Le ! dit au compilateur « ReadLine ne renverra pas null ici » (sinon : souligné en vert).
        int age = int.Parse(Console.ReadLine()!);

        // 3. Le 40 est CALCULÉ à partir de age (age + 10), pas écrit en dur
        Console.WriteLine($"Dans 10 ans tu auras {age + 10} ans");

        // a) Si on tape abc : le programme PLANTE avec une System.FormatException,
        //    car int.Parse ne sait pas transformer "abc" en nombre.
        //    La ligne « Dans 10 ans... » ne s'affiche donc jamais.
    }
}
