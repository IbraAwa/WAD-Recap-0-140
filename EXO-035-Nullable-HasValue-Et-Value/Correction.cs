// ===================================================================================
//  ✅ CORRECTION — EXO 035 — HasValue et Value
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un entier qui peut être null : au départ, il ne contient rien
        int? noteExamen = null;

        // Prédiction : False, car la variable est vide (null)
        Console.WriteLine($"A une valeur : {noteExamen.HasValue}");

        // On lui donne maintenant une valeur
        noteExamen = 15;

        // HasValue devient True : il y a bien une valeur dedans
        Console.WriteLine($"A une valeur : {noteExamen.HasValue}");

        // Value donne la valeur elle-même (ici 15)
        Console.WriteLine($"La valeur : {noteExamen.Value}");
    }
}
