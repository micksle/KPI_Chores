﻿namespace Lab1_Alt.MainCode
{
    public interface ICryptography
    {
        void DoAction(string targetString, string encryptingKey, bool encrypt);
        string Cipher(string targetString, int key, bool encrypt);
    }
}