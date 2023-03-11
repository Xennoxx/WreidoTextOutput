using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WreidoTextOutput
{
    internal class Crypt
    {
        public string PersonalUnlock = "";
        public void Crypting(string CryptInput)
        {
            char[] ConvertedCharArray = CryptInput.ToCharArray();
            for (int i = 0; i < ConvertedCharArray.Length; i++)
            {
                switch (ConvertedCharArray[i])
                {
                    case 'A': 
                        ConvertedCharArray[i] = '4';
                        break;
                    case 'a': 
                        ConvertedCharArray[i] = '4';
                        break;
                    case 'I': 
                        ConvertedCharArray[i] = '1';
                        break;
                    case 'i':
                        ConvertedCharArray[i] = '1';
                        break;
                    case 'Z':
                        ConvertedCharArray[i] = '7';
                        break;
                    case 'z':
                        ConvertedCharArray[i] = '7';
                        break;
                    case 'O':
                        ConvertedCharArray[i] = '0';
                        break;
                    case 'o':
                        ConvertedCharArray[i] = '0';
                        break;
                }
            }
            PersonalUnlock = String.Join("", ConvertedCharArray);
        }
        /*return string (Crypt.Select(x =>
        {
            switch (x)
            {
                case '0': return 'O';
                case '1': return 'I';
                case '5': return 'S';
                default: return x;
            }

        }).ToArray());*/
    }
}
