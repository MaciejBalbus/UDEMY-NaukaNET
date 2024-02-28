using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Kata
{
    internal class Kata
    {
        //     "to jest taki tam test" -> "test tam taki jest to";
        //1.   "to jest taki tam test" -> ["to", "jest", "taki", "tam", "test"];
        //2.   ["to", "jest", "taki", "tam", "test"]  -> ["test", "tam", "taki", "jest", "to"];
        //3.   ["test", "tam", "taki", "jest", "to"] -> "test tam taki jest to"

        public static List<string> Potnij(string stringWejscie, char separator)
        {
            var rezultat = new List<string>();
            var biezacyIndex = 0;

            for (int i = 0; i < stringWejscie.Length;i++) 
            {
                if (stringWejscie[i]==separator)
                {
                    var slowo = stringWejscie.Substring(biezacyIndex, i - biezacyIndex);
                    rezultat.Add(slowo);
                    biezacyIndex=i+1;
                }
                else if(i== stringWejscie.Length -1)
                {
                    var slowo = stringWejscie.Substring(biezacyIndex, stringWejscie.Length - biezacyIndex);
                    rezultat.Add(slowo);
                }             
            }
            return rezultat;
        }

        public static List<string> Obroc (List<string> StringLista)
        {
            var rezultat = new List<string>();

            for(int i=StringLista.Count-1;i>=0;i--)
            {
                rezultat.Add(StringLista[i]);
            }
            return rezultat;
        }

        public static string Polacz(List<string> StringLista,char lacznik)
        {
            var sb = new StringBuilder();
            for(int i = 0; i < StringLista.Count; i++)
            {
                sb.Append(StringLista[i]);
                if (i != StringLista.Count - 1)
                {
                    sb.Append(lacznik);
                }
            }
            return sb.ToString();   
        }


        public static string ReverseWords(string str)
        {
            var pocieteSlowa = Potnij(str, ' ');
            var obroconeSlowa = Obroc(pocieteSlowa);
            var polaczoneSlowa = Polacz(obroconeSlowa,' ');
            return polaczoneSlowa;
        }
    }
}
