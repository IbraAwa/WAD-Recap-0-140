// ===================================================================================
//  ✅ CORRECTION — EXO 021 — Choisir le bon type
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // string : le titre est un texte
        string titre = "Titanic";

        // int : une année est un nombre entier
        int annee = 1997;

        // double : une durée est un nombre à virgule (pas de l'argent)
        double dureeHeures = 3.25;

        // decimal : c'est un prix, donc de l'argent (ne pas oublier le suffixe m)
        decimal prixTicket = 11.50m;

        // char : la salle est une seule lettre, entre ' '
        char salle = 'C';

        // bool : la réponse est oui ou non (ici non, donc false)
        bool estEn3D = false;

        Console.WriteLine($"Titre : {titre}");
        Console.WriteLine($"Année : {annee}");
        Console.WriteLine($"Durée : {dureeHeures} heures");
        Console.WriteLine($"Prix : {prixTicket} euros");
        Console.WriteLine($"Salle : {salle}");
        Console.WriteLine($"En 3D : {estEn3D}");
    }
}
