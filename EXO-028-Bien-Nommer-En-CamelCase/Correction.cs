// ===================================================================================
//  ✅ CORRECTION — EXO 028 — Bien nommer ses variables (camelCase)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // camelCase : 1re lettre en minuscule, puis une majuscule au début de chaque mot
        string nomClient = "Dupont";             // NOMCLIENT          → nomClient
        string prenomClient = "Léa";             // Prenom_client      → prenomClient (pas de _)
        int nombreDeCommandes = 3;               // nombredecommandes  → nombreDeCommandes
        bool estMembre = true;                   // EstMembre          → estMembre

        Console.WriteLine($"{prenomClient} {nomClient} a passé {nombreDeCommandes} commandes (membre : {estMembre})");
    }
}
