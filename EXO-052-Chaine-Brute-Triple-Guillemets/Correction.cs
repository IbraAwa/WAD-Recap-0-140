// ===================================================================================
//  ✅ CORRECTION — EXO 052 — La chaîne brute avec trois guillemets
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Chaîne brute : on ouvre avec """ (puis on va à la ligne) et on ferme avec """.
        // Les guillemets du texte s'écrivent tels quels, sans les doubler ni mettre de \.
        // Les espaces placés AVANT les """ de fermeture sont retirés de chaque ligne :
        // { et } se retrouvent donc tout à gauche, et "nom" garde ses 4 espaces en plus.
        string json = """
            {
                "nom": "Léa",
                "ville": "Namur"
            }
            """;

        Console.WriteLine(json);

        string nom = "Léa";

        // Avec $ devant, les { } insèrent la valeur d'une variable, même dans une chaîne brute
        Console.WriteLine($"""Bonjour "{nom}" !""");
    }
}
