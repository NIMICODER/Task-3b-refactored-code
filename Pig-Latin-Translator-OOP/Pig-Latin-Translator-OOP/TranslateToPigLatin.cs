using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_Translator_OOP
{
     public class TranslateToPigLatin
    {
      public  string TranslateToPigLat(string sentence)
        {
            string[] words = sentence.Split(' ');
            var result = string.Empty;

            foreach (var word in words)
            {
                bool isUpper = false;
                var firstChar = word[0];

                if (Char.IsUpper(firstChar))
                    isUpper = true;

                var temp = "";

                for (int i = 1; i < word.Length; i++)
                {
                    if (isUpper && i == 1)
                    {
                        temp += Char.ToUpper(word[i]);
                        continue;
                    }

                    temp += word[i];
                }

                temp += Char.ToLower(firstChar);
                temp += "ay";
                result += $"{temp} ";


            }

            return result;
        }
    }
}
