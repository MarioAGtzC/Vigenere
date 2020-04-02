using System;

namespace Vigenere
{
    class Encryption
    {
        private string key;
        private string password;
        private char[] keyChar;
        private char[] passwordChar;
        private int[] keyInt;
        private int[] passwordInt;

        public Encryption(string key, string password)
        {
            this.key = key;
            this.password = password;
        }

        public string getNewKey()
        {
            getUpper();
            extendKey();
            return key;
        }

        public string getEncryption()
        {
            stringToChar();
            charToInt();
            getShifted();
            intToChar();
            charToString();
            return password;
        }

        private void getUpper()
        {
            key = key.ToUpper();
            password = password.ToUpper();
        }

        private void extendKey()
        {
            int keyLength = key.Length;
            int passwordLength = password.Length;

            if (passwordLength > keyLength)
            {
                key += key.Substring(0, passwordLength - keyLength);
            }
            else if (passwordLength < keyLength)
            {
                key = key.Substring(0, passwordLength);
            }
        }

        private void stringToChar()
        {
            keyChar = key.ToCharArray();
            passwordChar = password.ToCharArray();
        }

        private void charToInt()
        {
            keyInt = new int[password.Length];
            passwordInt = new int[password.Length];

            for (int i = 0; i < password.Length; i++)
            {
                passwordInt[i] = Convert.ToInt32(passwordChar[i]);
                keyInt[i] = Convert.ToInt32(keyChar[i]) - 65;
            }
        }

        private void getShifted()
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (passwordInt[i] >= 65 && passwordInt[i] <= 90)
                {
                    passwordInt[i] += keyInt[i];
                    if(passwordInt[i] > 90)
                    {
                        passwordInt[i] -= 26;
                    }
                }
                else
                {
                    passwordInt[i] += keyInt[i];
                    while (passwordInt[i] > 57)
                    {
                        passwordInt[i] -= 10;
                    }
                }
            }
        }

        private void intToChar()
        {
            for (int i = 0; i < password.Length; i++)
            {
                passwordChar[i] = Convert.ToChar(passwordInt[i]);
            }
        }

        private void charToString() => password = new string(passwordChar);
    }
}