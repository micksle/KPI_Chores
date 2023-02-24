using Lab1.Probs;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var prob1 = new Prob1();
            // prob1.Method("Факт ґринджол: бій псюг вщух, з'їм шче яєць.", 2);
            var caesar = new CaesarsCipher();
            caesar.DoAction();
        }
    }
}