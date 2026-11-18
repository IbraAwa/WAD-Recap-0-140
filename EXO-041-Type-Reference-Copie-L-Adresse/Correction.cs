// ===================================================================================
//  ✅ CORRECTION — EXO 041 — Type référence : on copie l'adresse
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // On crée UNE liste avec new, et on la remplit directement entre { }
        List<string> maListe = new List<string> { "pain", "lait" };

        // Pas de new ici : on ne crée PAS de deuxième liste.
        // On copie seulement l'adresse : les deux variables pointent sur la MÊME liste.
        List<string> listeDuColoc = maListe;

        // On ajoute café en passant par listeDuColoc...
        listeDuColoc.Add("café");

        // Prédiction : maListe contient pain, lait, café.
        // List est un type RÉFÉRENCE : maListe et listeDuColoc sont deux noms pour la même liste,
        // donc ce qu'on ajoute par l'une se voit aussi par l'autre (contrairement au int de l'EXO 040).

        // string.Join colle les éléments de la liste en les séparant par ", "
        Console.WriteLine(string.Join(", ", maListe));
    }
}
