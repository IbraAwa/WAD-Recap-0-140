// ===================================================================================
//  ✅ CORRECTION — EXO 075 — Boxing : ranger dans un object
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 1.
        int quantite = 3;

        // 2. BOXING : l'int est mis dans une « boîte » de type object.
        //    object accepte n'importe quelle valeur, donc pas besoin de conversion.
        object boite = quantite;

        // 3. La boîte s'affiche normalement...
        Console.WriteLine(boite);

        // ...et GetType() montre que DANS la boîte, c'est toujours un int (System.Int32)
        Console.WriteLine(boite.GetType());
    }
}
