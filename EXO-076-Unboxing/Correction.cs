// ===================================================================================
//  ✅ CORRECTION — EXO 076 — Unboxing : ressortir de l'object
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1. On met l'entier 3 dans une boîte object (boxing)
        object boite = 3;

        // 2. UNBOXING : pour ressortir la valeur, on dit son type avec un cast (int)
        int quantite = (int)boite;
        Console.WriteLine(quantite);

        // 3. ❌ Erreur de compilation CS0266 :
        //    « Impossible de convertir implicitement le type 'object' en 'int' »
        //    Le compilateur ne sait pas ce qu'il y a dans la boîte : il exige un cast.
        // int q2 = boite;

        // 4. 💥 Plante à l'exécution : System.InvalidCastException
        //    Ça compile, mais la boîte contient un INT : on doit la ressortir
        //    avec EXACTEMENT ce type-là, pas en long.
        // long l = (long)boite;
    }
}
