// ===================================================================================
//  ✅ CORRECTION — EXO 105 — Ternaire : majeur ou mineur (slide 121 n°3)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Write (sans retour à la ligne) : l'utilisateur tape sa réponse juste après le message
        Console.Write("Votre âge : ");

        // ReadLine renvoie du texte : int.Parse le transforme en nombre entier.
        // Le ! dit au compilateur « je sais que ReadLine ne renverra pas null ici » (slide 105).
        int age = int.Parse(Console.ReadLine()!);

        // Le ternaire choisit l'un des deux mots selon la condition
        string statut = age >= 18 ? "Majeur" : "Mineur";

        Console.WriteLine(statut);
    }
}
