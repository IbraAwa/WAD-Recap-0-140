// ===================================================================================
//  ✅ CORRECTION — EXO 036 — Value sur un null : le programme plante
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un entier qui peut être null : au départ, il est vide
        int? age = null;

        // 💥 Le programme PLANTE avec une InvalidOperationException
        //    (« Nullable object must have a value ») : on demande la valeur alors qu'il n'y en a pas.
        //    C'est pour ça qu'il faut vérifier HasValue AVANT d'utiliser Value.
        // Console.WriteLine(age.Value);

        // GetValueOrDefault() ne plante jamais : s'il n'y a pas de valeur,
        // il renvoie la valeur par défaut du type int, c'est-à-dire 0.
        Console.WriteLine(age.GetValueOrDefault());
    }
}
