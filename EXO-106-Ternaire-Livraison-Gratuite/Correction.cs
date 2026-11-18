// ===================================================================================
//  ✅ CORRECTION — EXO 106 — Ternaire : la livraison gratuite (slide 121 n°4)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        Console.Write("Montant de la commande : ");

        // decimal : le type adapté à l'argent (pas d'erreurs d'arrondi comme avec double)
        decimal montant = decimal.Parse(Console.ReadLine()!);

        // Gratuit à partir de 50 (50 compris) donc >= ; sinon 4,95.
        // Le m après 4.95 indique que c'est un decimal (dans le code, on écrit toujours un point).
        decimal frais = montant >= 50 ? 0m : 4.95m;

        decimal total = montant + frais;

        Console.WriteLine($"Total à payer : {total} euros");
    }
}
