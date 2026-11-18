// ===================================================================================
//  ✅ CORRECTION — EXO 113 — typeof et nameof (slide 126 n°5)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // typeof(int) donne les informations du type int.
        // Name = nom court (Int32), FullName = nom complet avec son espace de noms (System.Int32).
        // On voit que int n'est qu'un raccourci pour System.Int32.
        Console.WriteLine($"{typeof(int).Name} / {typeof(int).FullName}");
        Console.WriteLine($"{typeof(string).Name} / {typeof(string).FullName}");
        Console.WriteLine($"{typeof(decimal).Name} / {typeof(decimal).FullName}");

        // GetType() part d'une VALEUR : il donne le type réel de ce qui est rangé dans o.
        // 3.14 est un double, donc les deux types sont identiques → True
        object o = 3.14;
        Console.WriteLine(o.GetType() == typeof(double));

        // nameof donne le NOM de la variable tel qu'il est écrit dans le code ("age"), pas sa valeur (30)
        int age = 30;
        Console.WriteLine(nameof(age));
    }
}
