using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WreidoTextOutput
{
    internal class Crypting : StringToCharAndCharToString
    {
        public void CryptConvert() 
        {
            {
                switch (CharInput)
                {
                    case 'A': return '4';
                    case 'a': return '4';
                    case 'O': return '0';
                    case 'o': return '0';
                    case 'I': return '1';
                    case 'i': return '1';
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
    }
}
