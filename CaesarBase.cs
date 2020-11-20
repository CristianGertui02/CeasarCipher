using System;
using System.Collections.Generic;
using System.Text;

namespace CeasarCipher
{
    public abstract class CaesarBase
    {
        protected int key { get; set; }

        private char cipher(char ch)
        {
            if (!char.IsLetter(ch))
                return ch;
            char offset;
            if (char.IsUpper(ch))
            {
                offset = 'A';
            }
            else
            {
                offset = 'a';
            }
            return (char)(((ch - offset + key) % 26) + offset);
        }

        protected string DoWork(string m)
        {
            string message = string.Empty; 
            foreach(char ch in m)
            {
                message += cipher(ch);
            }
            return message;
        }
    }
}
