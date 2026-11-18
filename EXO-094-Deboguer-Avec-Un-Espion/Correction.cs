// ===================================================================================
//  ✅ CORRECTION — EXO 094 — Déboguer : les espions
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int age = 70;

        // Étape 2 : pas besoin de if, la condition donne directement un booléen.
        // Étape 3 : mets le point d'arrêt (F9) sur la ligne ci-dessous, puis lance avec F5.
        //           Le programme s'arrête AVANT d'exécuter cette ligne.
        bool tarifNormal = age >= 18 && age < 65;

        // Étape 4 : sélectionne "age < 65" > clic droit > Ajouter un espion,
        //           puis pareil avec "age >= 18".
        // Étape 5 : valeurs observées dans la fenêtre Espion (avec age = 70) :
        //   age < 65   → false  (70 n'est pas moins de 65)  ← c'est elle qui fait tout rater
        //   age >= 18  → true   (70 est bien au moins 18)
        //   true && false = false → tarifNormal vaudra false. F5 pour finir.

        Console.WriteLine("Tarif normal : " + tarifNormal);
    }
}
