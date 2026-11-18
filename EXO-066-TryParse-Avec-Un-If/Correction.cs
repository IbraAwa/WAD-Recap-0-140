// ===================================================================================
//  ✅ CORRECTION — EXO 066 — TryParse avec un if
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. On affiche la question sans retour à la ligne, puis on lit la réponse.
        //    string? : ReadLine peut renvoyer null, la variable a le droit d'être null.
        Console.Write("Votre âge : ");
        string? saisie = Console.ReadLine();

        // 2. TryParse renvoie true ou false : on s'en sert DIRECTEMENT comme condition du if.
        //    (TryParse accepte un texte null : dans ce cas il renvoie simplement false)
        if (int.TryParse(saisie, out int age))
        {
            // Conversion réussie : age contient le nombre tapé
            Console.WriteLine(age + 10);
        }
        else
        {
            // Conversion ratée (ex. : abc) : pas de plantage, on affiche un message
            Console.WriteLine("Pas un nombre");
        }

        // 3. Avec 30 → 40 ; avec abc → Pas un nombre
    }
}
