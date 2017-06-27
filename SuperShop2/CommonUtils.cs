using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    static class CommonUtils
    {
        static public string[] AddAdditionalString(string[] stringCollection, string additionalString)
        {
            string[] newcollection = new string[stringCollection.Length + 1];
            for (int i = 0; i < stringCollection.Length; i++)
            {
                newcollection[i] = stringCollection[i];
            }
            newcollection[newcollection.Length - 1] = additionalString;

            return newcollection;
        }
    }
}
