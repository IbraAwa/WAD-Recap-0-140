// ===================================================================================
//  ✅ CORRECTION — EXO 090 — Le switch
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int jour = 3;

        // Étape 2 : le switch compare jour à chaque case, et exécute celui qui correspond.
        // Chaque case se termine par break : on sort du switch.
        switch (jour)
        {
            case 1:
                Console.WriteLine("Lundi");
                break;
            case 2:
                Console.WriteLine("Mardi");
                break;
            case 3:
                Console.WriteLine("Mercredi");
                break;
            case 4:
                Console.WriteLine("Jeudi");
                break;
            case 5:
                Console.WriteLine("Vendredi");
                break;
            case 6:
                Console.WriteLine("Samedi");
                break;
            case 7:
                Console.WriteLine("Dimanche");
                break;
            // Étape 3 : default = aucun case ne correspond (comme le else)
            default:
                Console.WriteLine("Jour inconnu");
                break;
        }

        // Étape 4 : tests
        //   3 → Mercredi   |   7 → Dimanche   |   9 → Jour inconnu
    }
}
