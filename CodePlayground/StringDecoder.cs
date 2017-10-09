using System;

namespace CodePlayGround
{
    public static class StringDecoder
    {
        /// <summary>
        /// Decodes a string in a form k[encodedstring] where k is a int and the encoded string between brackes can be any string even a k[encodedstring].
        /// In other words, it can be a recursive encoding
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string DecodeString(this string input)
        {
            var decodedstring = string.Empty;

            var opentags = 0;

            var innerstring = "";

            string numberText = "";


            for (int i = 0; i < input.Length; i++)
            {
                if (opentags > 0)
                {
                    innerstring += input[i];
                }
                else {
                    if(input[i] != '[' && input[i] != ']')
                        decodedstring += input[i];
                }
                if (input[i] == '[')
                {
                    opentags++;

                    if (opentags == 1)
                    {
                        innerstring = "";

                        numberText = "";

                        //take number before opening bracket
                        for (var j = i - 1; j >= 0 && char.IsDigit(input[j]); j--)
                        {
                            numberText = input[j] + numberText;
                            //removes the numbers from the decoded string
                            decodedstring = decodedstring.Remove(decodedstring.Length - 1);
                        }
                    }
                }

                if (input[i] == ']')
                {
                    opentags--;                    

                    //parses the current expression when the last ending bracket is closed
                    //multiplies innerstring by number 
                    if (opentags == 0)
                    {
                        //removes the last character which is a bracket 
                        innerstring = innerstring.Remove(innerstring.Length - 1);
                        var d = innerstring.DecodeString();
                        for (int k = 1; k <= int.Parse(numberText); k++ )
                            decodedstring += d;
                    }
                }


            }
            return decodedstring;
        }      
    }
}