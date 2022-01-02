using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionStringMethod.CustomExtensions
{
    public static class StringExtensions
    {
        public static bool ContainsText(this string metin,string yazi)
        {
            int counter = 0;
            if(metin.Length<yazi.Length)
            {
                return false;
            }
            for(int i=0; i<metin.Length;i++)
            {
                if(metin.Length-i<yazi.Length)
                {
                    return false;
                }
                else
                {
                    for (int j = 0; j < metin.Length; j++)
                    {
                        if (metin[j + i] == yazi[j])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 0;
                            break;
                        }
                        if (counter == yazi.Length)
                        {
                            return true;
                        }
                    }


                } 
                    
            }
            return false;
         
        }

        public static bool StartWithText(this string metin, string yazi)
        {
            int counter = 0;
            if (metin.Length < yazi.Length)
            {
                return false;
            }
            for (int i = 0; i < yazi.Length; i++)
            {
                if (metin[i] == yazi[i])
                {
                    counter++;
                }
                else
                {
                    return false;
                }
                if (counter == yazi.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
