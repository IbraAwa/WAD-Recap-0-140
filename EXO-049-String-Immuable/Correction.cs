// ===================================================================================
//  ✅ CORRECTION — EXO 049 — Un string ne se modifie pas
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        string titre = "Harry Potter";

        // ToUpper() ne modifie PAS titre : il fabrique un NOUVEAU texte en majuscules...
        // ...et comme on ne le range nulle part, ce nouveau texte est tout simplement perdu.
        titre.ToUpper();

        // Prédiction : « Harry Potter » (inchangé), car un string est immuable
        Console.WriteLine(titre);

        // Pour garder le résultat, il faut le ranger dans une variable
        string titreMajuscules = titre.ToUpper();
        Console.WriteLine(titreMajuscules);

        // Même chose ici : + crée un nouveau texte, qu'on remet dans titre
        // (titre « pointe » alors vers ce nouveau texte ; l'ancien n'a pas été modifié)
        titre = titre + " à l'école des sorciers";
        Console.WriteLine(titre);
    }
}
