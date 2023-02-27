namespace Security_of_information_systems.MainCode
{
    public abstract class Cryptography
    {
        public abstract void DoAction(string targetString, string encryptingKey, bool encrypt);
        public abstract string Cipher(string targetString, int key, bool encrypt);
    }
}