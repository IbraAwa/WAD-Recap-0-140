// ===================================================================================
//  ✅ CORRECTION — EXO 065 — TryParse : convertir sans planter
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. Un texte qui contient bien un nombre
        string saisie1 = "25";

        // 2. TryParse renvoie true/false (ça a marché ou pas ?) → rangé dans reussi1.
        //    Le nombre converti est rangé dans age1, déclarée directement après le mot out.
        bool reussi1 = int.TryParse(saisie1, out int age1);

        // 3.
        Console.WriteLine($"Réussi : {reussi1}, âge : {age1}");

        // 4. Un texte qui n'est PAS un nombre : TryParse ne plante pas,
        //    il renvoie simplement false et met 0 dans age2.
        string saisie2 = "vingt-cinq";
        bool reussi2 = int.TryParse(saisie2, out int age2);
        Console.WriteLine($"Réussi : {reussi2}, âge : {age2}");
    }
}
