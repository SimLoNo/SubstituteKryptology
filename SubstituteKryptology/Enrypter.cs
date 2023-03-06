using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteKryptology
{
    public class Enrypter
    {

        public string Encrypt(string text, int displaceAmount)
        {
            string returnText = "";
            char newSign;
            foreach (char sign in text)
            {
                int unicode = sign;
                if (unicode < 128)
                {
                    unicode += displaceAmount;
                    if (unicode > 127)
                    {
                        unicode -= 127;
                    }
                }
                else { continue; }

                newSign = System.Convert.ToChar(unicode);
                returnText+= newSign;
            }
            return returnText;
        }

        public string Decrypt(string text, int displaceAmount) 
        {
            string returnText = "";
            char newSign;
            foreach (char sign in text)
            {
                int unicode = sign;
                if (unicode < 128)
                {
                    unicode-= displaceAmount;
                    if (unicode < 1)
                    {
                        unicode +=127;

                    }
                }
                else { continue; }

                newSign = System.Convert.ToChar(unicode);
                returnText += newSign;

            }
            return returnText;
        }
    }
}
