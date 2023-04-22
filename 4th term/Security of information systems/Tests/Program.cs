namespace Tests
{
    class Program
    {
        public static void Main()
        {
            var str = "恲㼠뤡왥瞻预缊㱷䷥핖眞ӳ紑ꠓ䖰曆᭛擼烳쇞頙쾾㪾沈핡悘Ȝ✊盇젨൳㡛䉂";
            var seed = 146855;
            Random random = new Random(seed);
            byte[] gamma = new byte[str.Length];
            random.NextBytes(gamma);

            byte[] inputBytes = System.Text.Encoding.Unicode.GetBytes(str);
            byte[] encryptedBytes = new byte[inputBytes.Length];
            for (int i = 0; i < gamma.Length; i++)
            {
                encryptedBytes[i] = (byte)(inputBytes[i] ^ gamma[i]);
                Console.Write((int)str[i] + " - ");
            }
        }
    }
}