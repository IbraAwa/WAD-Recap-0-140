// ===================================================================================
//  ✅ CORRECTION — EXO 078 — Additionner deux nombres avec TryParse (slide 100)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. TryParse ne plante jamais : il renvoie true/false (gardé dans reussi1)
        //    et range le nombre dans nombre1 grâce à out.
        //    (TryParse accepte un texte null, donc pas besoin du ! ici)
        Console.Write("Premier nombre : ");
        bool reussi1 = int.TryParse(Console.ReadLine(), out int nombre1);

        // 2. Pareil pour le deuxième
        Console.Write("Deuxième nombre : ");
        bool reussi2 = int.TryParse(Console.ReadLine(), out int nombre2);

        // 3. && (ET) : la condition n'est vraie que si les DEUX conversions ont réussi
        if (reussi1 && reussi2)
        {
            Console.WriteLine($"{nombre1} + {nombre2} = {nombre1 + nombre2}");
        }
        else
        {
            Console.WriteLine("Un des deux n'est pas un nombre");
        }

        // 4. Si on tape abc : cette fois le programme ne plante PAS.
        //    TryParse renvoie false, on passe dans le else
        //    et on affiche « Un des deux n'est pas un nombre ».
    }
}
