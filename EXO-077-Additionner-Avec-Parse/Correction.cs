// ===================================================================================
//  ✅ CORRECTION — EXO 077 — Additionner deux nombres avec Parse (slide 100)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. On pose la question (Write : la réponse se tape sur la même ligne),
        //    puis on lit le texte et on le convertit en entier avec int.Parse.
        //    Le ! dit au compilateur que ReadLine ne renverra pas null ici.
        Console.Write("Premier nombre : ");
        int nombre1 = int.Parse(Console.ReadLine()!);

        // 2. Pareil pour le deuxième nombre
        Console.Write("Deuxième nombre : ");
        int nombre2 = int.Parse(Console.ReadLine()!);

        // 3. Tout vient des variables : rien n'est écrit en dur
        int somme = nombre1 + nombre2;
        Console.WriteLine($"{nombre1} + {nombre2} = {somme}");

        // 4. Si on tape abc : le programme PLANTE avec une System.FormatException,
        //    car int.Parse ne sait pas transformer "abc" en nombre.
    }
}
