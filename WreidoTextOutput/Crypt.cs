using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WreidoTextOutput
{
    internal class Crypt
    {
        /*Attributes*/
        public string CryptInput { get; set; } = "";
        
        public void CryptConvert(string Input) 
        { 
            CryptInput = Input;
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
