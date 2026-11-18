// ===================================================================================
//  ✅ CORRECTION — EXO 053 — Coller des textes avec +
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        string prenom = "Léa";
        string nom = "Dupont";

        // Entre deux textes, + les colle bout à bout : prénom + espace + nom
        string nomComplet = prenom + " " + nom;
        Console.WriteLine(nomComplet);

        // Ici, rien entre les deux : il manque l'espace
        string nomColle = prenom + nom;
        Console.WriteLine(nomColle);

        // a) Pourquoi « LéaDupont » est collé ?
        //    Parce que + colle les textes EXACTEMENT tels qu'ils sont, sans rien ajouter.
        //    Ni "Léa" ni "Dupont" ne contient d'espace : il faut l'ajouter nous-mêmes avec " ".
    }
}
