// ===================================================================================
//  ✅ CORRECTION — EXO 114 — is : vérifier le type
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        object o = 42;

        // is renvoie true si o contient bien un int
        if (o is int)
        {
            // On ne peut pas calculer avec un object : on le convertit d'abord en int.
            // Grâce au test is juste au-dessus, on est sûr que cette conversion ne plantera pas.
            int nombre = (int)o;
            Console.WriteLine(nombre * 2);
        }

        // is renvoie un bool : on peut l'afficher directement. o contient un int, pas un string → False
        Console.WriteLine(o is string);
    }
}
