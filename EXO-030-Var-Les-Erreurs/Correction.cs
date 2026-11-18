// ===================================================================================
//  ✅ CORRECTION — EXO 030 — Les erreurs avec var
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // ❌ Erreur CS0818 : une variable var doit être initialisée.
        //    Sans valeur à droite du =, C# ne peut pas deviner son type.
        // var x;

        // C# voit 42 : nombre devient un int
        var nombre = 42;
        Console.WriteLine(nombre);

        // ❌ Erreur CS0029 : impossible de convertir un string en int.
        //    nombre est un int pour toujours : on ne peut pas y ranger du texte.
        // nombre = "quarante-deux";

        // a) « Fortement typé » veut dire que la variable a quand même un type précis,
        //    choisi une fois pour toutes à la déclaration. var n'est qu'un raccourci
        //    d'écriture : ici, var nombre = 42; est exactement la même chose que int nombre = 42;
    }
}
