// ===================================================================================
//  ✅ CORRECTION — EXO 086 — Le OU exclusif : ^
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Étape 2 : au départ, le client prend les deux
        bool prendDessert = true;
        bool prendCafe = true;

        // Étape 3 : ^ (OU exclusif) est vrai seulement si les deux valeurs sont DIFFÉRENTES,
        // c'est-à-dire l'un OU l'autre, mais pas les deux.
        bool menuValide = prendDessert ^ prendCafe;
        Console.WriteLine("Menu valide : " + menuValide);

        // Étape 4 : les 4 cas
        //   dessert et café  (true  ^ true)  → False (les deux : interdit)
        //   dessert seul     (true  ^ false) → True
        //   café seul        (false ^ true)  → True
        //   ni l'un ni l'autre (false ^ false) → False
    }
}
