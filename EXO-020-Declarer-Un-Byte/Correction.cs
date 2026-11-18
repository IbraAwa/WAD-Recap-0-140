// ===================================================================================
//  ✅ CORRECTION — EXO 020 — Déclarer un byte (de 0 à 255)
// ===================================================================================

public static class Correction
{
    public static void LancerLaCorrection()
    {
        // 12 est entre 0 et 255 : il tient dans un byte
        byte ageDuChat = 12;
        Console.WriteLine($"Mon chat a {ageDuChat} ans");

        // ❌ Erreur CS0031 : la valeur 300 ne peut pas être convertie en byte,
        //    car un byte ne va que de 0 à 255.
        // byte tropGrand = 300;
    }
}
