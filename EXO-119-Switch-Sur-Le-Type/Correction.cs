// ===================================================================================
//  ✅ CORRECTION — EXO 119 — switch sur le type d'une valeur
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // object? : peut contenir n'importe quel type... ou null
        object? valeur = 3.5;

        switch (valeur)
        {
            // Le cas le plus précis d'abord : un int ET négatif (when ajoute une condition)
            case int n when n < 0:
                Console.WriteLine($"Entier négatif {n}");
                break;

            // Les autres int (s'il était avant le cas précédent, celui-ci ne servirait jamais)
            case int n:
                Console.WriteLine($"Entier {n}");
                break;

            case double d:
                Console.WriteLine($"Décimal {d}");
                break;

            case null:
                Console.WriteLine("Aucune valeur (null)");
                break;
        }

        // Tests (change la valeur de départ et relance) :
        //   3.5  → Décimal 3,5
        //   -5   → Entier négatif -5
        //   42   → Entier 42
        //   null → Aucune valeur (null)
    }
}
