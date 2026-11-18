// ===================================================================================
//  ✅ CORRECTION — EXO 027 — Majuscules et minuscules comptent
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Même mot, mais pas les mêmes majuscules : pour C#, ce sont trois noms différents
        int age = 20;
        int Age = 25;
        int AGE = 35;

        Console.WriteLine($"age = {age}, Age = {Age}, AGE = {AGE}");

        // a) On a créé 3 variables différentes, car C# est sensible à la casse :
        //    une minuscule et une majuscule ne sont pas la même lettre pour lui.
        //    (En vrai, on évite ça : c'est très facile de se tromper de variable !)
    }
}
