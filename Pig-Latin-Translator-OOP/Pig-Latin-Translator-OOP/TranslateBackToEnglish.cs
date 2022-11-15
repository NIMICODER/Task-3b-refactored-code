using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_Translator_OOP
{
    public class TranslateBackToEnglish
    {
        public string TranslateBackToEng(string sentence)
        {
            var result = string.Empty;
            string[] words = sentence.Trim().Split(' ');


            foreach (var word in words)
            {
                bool isUpper = false;

                if (Char.IsUpper(word[0]))
                    isUpper = true;

                string temp = "";
                char firstChar = word[word.Length - 3];

                if (isUpper)
                {
                    temp += Char.ToUpper(firstChar);
                }
                else
                    temp += firstChar;

                for (int i = 0; i < word.Length - 3; i++)
                {
                    temp += Char.ToLower(word[i]);
                }

                result += $"{temp} ";
            }

            return result;
        }
    }
}
