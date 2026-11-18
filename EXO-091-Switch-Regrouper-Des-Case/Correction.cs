// ===================================================================================
//  ✅ CORRECTION — EXO 091 — Regrouper des case
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 1
        int jour = 6;

        switch (jour)
        {
            // Étape 2 : on empile case 6 et case 7 l'un sous l'autre, SANS code entre eux.
            // Les deux partagent alors le même bloc : le message n'est écrit qu'une fois.
            case 6:
            case 7:
                Console.WriteLine("Week-end");
                break;
            // Étape 3 : tous les autres jours
            default:
                Console.WriteLine("Semaine");
                break;
        }
    }
}
