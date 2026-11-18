// ===================================================================================
//  ✅ CORRECTION — EXO 034 — int? : un nombre qui peut être vide
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Le ? après int veut dire : « cet entier a le droit d'être vide ».
        // null = pas de valeur du tout (ce n'est PAS 0 !).
        int? noteExamen = null;

        // null s'affiche comme... rien : on ne voit que « Note : »
        Console.WriteLine($"Note : {noteExamen}");

        // L'examen est passé : on met une vraie valeur dans la variable
        noteExamen = 15;
        Console.WriteLine($"Note : {noteExamen}");

        // Nullable<int> est la forme longue : c'est EXACTEMENT le même type que int?
        Nullable<int> autreNote = null;
        Console.WriteLine($"Autre note : {autreNote}");

        // ❌ Erreur CS0037 : impossible de convertir null en 'int'.
        //    Un int normal (sans ?) doit TOUJOURS contenir un nombre : il ne peut pas être vide.
        // int note = null;
    }
}
