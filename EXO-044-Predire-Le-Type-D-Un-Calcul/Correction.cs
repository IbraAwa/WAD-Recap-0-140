// ===================================================================================
//  ✅ CORRECTION — EXO 044 — Prédire le type d'un calcul (exercice slide 80)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Règle : le résultat prend le type « le plus grand » des valeurs du calcul.
        var a = 5 / 2;      // int / int        → 2   (int)     : division ENTIÈRE, la partie après la virgule est perdue
        var b = 5 / 2.0;    // int / double     → 2,5 (double)  : 2.0 est un double, donc tout le calcul passe en double
        var c = 5f / 2;     // float / int      → 2,5 (float)   : le f force 5 en float
        var d = 10m / 4;    // decimal / int    → 2,5 (decimal) : le m force 10 en decimal
        var e = 5L * 2;     // long * int       → 10  (long)    : le L force 5 en long
        var f = 'a' + 1;    // char + int       → 98  (int)     : un char est un nombre (son code) ; 'a' = 97, et 97 + 1 = 98

        // Le piège le plus courant : 5 / 2 donne 2 et non 2,5, car les deux nombres sont des int.
        // Et 'a' + 1 ne donne pas 'b' mais le nombre 98 (un int).

        Console.WriteLine($"{a} : {a.GetType()}");
        Console.WriteLine($"{b} : {b.GetType()}");
        Console.WriteLine($"{c} : {c.GetType()}");
        Console.WriteLine($"{d} : {d.GetType()}");
        Console.WriteLine($"{e} : {e.GetType()}");
        Console.WriteLine($"{f} : {f.GetType()}");
    }
}
