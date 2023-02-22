namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lab = new Laboratory();
            // lab.DoAction();
            var caesar = new CaesarsCipher();
            caesar.DoAction();
            // var newi = new New();
            // var smt = newi.EnryptString("this is simple string");
            // Console.WriteLine(smt);
            // var lastSmt = newi.DecryptString(smt);
            // Console.WriteLine(lastSmt);
        }
    }
}