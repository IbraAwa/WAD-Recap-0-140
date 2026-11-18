// ===================================================================================
//  ✅ CORRECTION — EXO 054 — StringBuilder : construire un texte morceau par morceau
// ===================================================================================

// Le using se met tout en haut du fichier : il donne accès à System.Text, où vit StringBuilder.
// (Dans ton Program.cs, tu le mets AVANT la ligne Console.WriteLine du titre.)
using System.Text;

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // Un StringBuilder vide : un texte « en chantier »
        StringBuilder sb = new StringBuilder();

        // Chaque Append ajoute un morceau à la fin, sans créer un nouveau texte à chaque fois
        sb.Append("Le Petit Prince");
        sb.Append(" - ");
        sb.Append("Antoine de Saint-Exupéry");

        // Le chantier est fini : ToString() le transforme en vraie string
        string texte = sb.ToString();
        Console.WriteLine(texte);
    }
}
