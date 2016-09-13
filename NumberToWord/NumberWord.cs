using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    class NumberWord
    {
        public string Words { get; }
        public string Number { get; }

        private Dictionary<string, string> onesAndTeensWordDict = new Dictionary<string, string>()
        {
            { "0", "" },
            { "1", "one" },
            { "2", "two" },
            { "3", "three" },
            { "4", "four" },
            { "5", "five" },
            { "6", "six" },
            { "7", "seven" },
            { "8", "eight" },
            { "9", "nine" },
            { "10", "ten" },
            { "11", "eleven" },
            { "12", "twelve" },
            { "13", "thirteen" },
            { "14", "fourteen" },
            { "15", "fifteen" },
            { "16", "sixteen" },
            { "17", "seventeen" },
            { "18", "eighteen" },
            { "19", "nineteen" },
        };

        private Dictionary<string, string> tensWordDict = new Dictionary<string, string>()
        {
            { "2", "twenty" },
            { "3", "thirty" },
            { "4", "forty" },
            { "5", "fifty" },
            { "6", "sixty" },
            { "7", "seventy" },
            { "8", "eighty" },
            { "9", "ninety" },
        };

        private string findWordsForHundreds(string number)
        {
            string lWords = "";
            if(number.Length == 1)
            {
                number = "00" + number;
            }
            else if(number.Length == 2)
            {
                number = "0" + number;
            }

            if(!number[0].Equals('0'))
            {
                lWords += onesAndTeensWordDict[number.Substring(0, 1)] + " hundred ";
            }

            if(number[1].Equals('1'))
            {
                lWords += onesAndTeensWordDict[number.Substring(1, 2)];
            }
            else if(number[1].Equals('0'))
            {
                lWords += onesAndTeensWordDict[number.Substring(2, 1)];
            }
            else
            {
                if(!number[2].Equals('0'))
                {
                    lWords += tensWordDict[number.Substring(1, 1)] + " " + onesAndTeensWordDict[number.Substring(2, 1)];
                }
                else
                {
                    lWords += tensWordDict[number.Substring(1, 1)];
                }
            }
            return lWords.TrimEnd(' ');
        }

        private string buildWords(string number)
        {
            number = number.TrimStart('0');
            int len = (int)Math.Ceiling((double)number.Length / 3.0);
            int start = number.Length % 3;
            if(start == 0)
            {
                start = 3;
            }
            string toReturn = "";
            switch (len)
            {
                case 22:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " vigintillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 21;
                case 21:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " novemdecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 20;
                case 20:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " octodecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 19;
                case 19:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " septendecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 18;
                case 18:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " sexdecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 17;
                case 17:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " quindecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 16;
                case 16:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " quattuordecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 15;
                case 15:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " trecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 14;
                case 14:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " duodecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 13;
                case 13:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " undecillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 12;
                case 12:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " decillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 11;
                case 11:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " nonillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 10;
                case 10:
                    toReturn += findWordsForHundreds(number.Substring(0, start)) + " octillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 9;
                case 9:
                    if(number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " septillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 8;
                case 8:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " sextillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 7;
                case 7:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " quintillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 6;
                case 6:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " quadrillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 5;
                case 5:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " trillion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 4;
                case 4:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " billion ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 3;
                case 3:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " million ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 2;
                case 2:
                    if (number.Substring(0, start) != "000")
                        toReturn += findWordsForHundreds(number.Substring(0, start)) + " thousand ";
                    number = number.Substring(start);
                    start = 3;
                    goto case 1;
                case 1:
                    toReturn += findWordsForHundreds(number);
                    break;
            }
            return toReturn;
        }

        public NumberWord(string number)
        {
            Words = buildWords(number);
            Number = number;
        }
        public string ToString()
        {
            return Words;
        }
    }
}
