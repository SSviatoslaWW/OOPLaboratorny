using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.CodeDom;
using System.Windows.Forms;

namespace laboratorna__11
{
    internal class ComplexNumber : MyString
    {
        public double RealPart { get; private set; }
        public double ImagonaryPart { get; private set; }

        string pattern = @"^([+-]?\d+([.,]\d+)?)?([+-]\d+([.,]\d+)?)i$";

        public ComplexNumber(string complexNumber) : base(complexNumber)
        {
            if (isValidComplexNumber())
            {
                ParseComplexNumber();
            }
            else
            {
                RealPart = 0;
                ImagonaryPart = 0;
                MyStringWithChar = "0+0i";
            }
        }


        private bool isValidComplexNumber()
        {
            return Regex.IsMatch(MyStringWithChar, pattern);
        }

        private void ParseComplexNumber()
        {
            Match match = Regex.Match(MyStringWithChar.Replace(".",","), pattern);
            RealPart = double.Parse(match.Groups[1].Value);
            ImagonaryPart = double.Parse(match.Groups[3].Value);
        }

        public static bool operator ==(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return firstNumber.RealPart == secondNumber.RealPart &&
                firstNumber.ImagonaryPart == secondNumber.ImagonaryPart;
        }

        public static bool operator !=(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return !(firstNumber == secondNumber);
        }

        public static ComplexNumber operator +(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return new ComplexNumber($"{firstNumber.RealPart + secondNumber.RealPart}" +
                                     $"{(firstNumber.ImagonaryPart + secondNumber.ImagonaryPart >= 0 ? "+" : "")}" +
                                     $"{firstNumber.ImagonaryPart + secondNumber.ImagonaryPart}i");
        }

        public static ComplexNumber operator - (ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return new ComplexNumber($"{firstNumber.RealPart - secondNumber.RealPart}" +
                                     $"{(firstNumber.ImagonaryPart - secondNumber.ImagonaryPart >= 0 ? "+" : "")}" +
                                     $"{firstNumber.ImagonaryPart - secondNumber.ImagonaryPart}i");
        }

        public static ComplexNumber operator * (ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return new ComplexNumber($"{firstNumber.RealPart * secondNumber.RealPart - firstNumber.ImagonaryPart * secondNumber.ImagonaryPart}"+
                                     $"{(firstNumber.RealPart * secondNumber.ImagonaryPart + firstNumber.ImagonaryPart * secondNumber.RealPart >= 0 ? "+" : "")}" +
                                     $"{firstNumber.RealPart * secondNumber.ImagonaryPart + firstNumber.ImagonaryPart * secondNumber.RealPart}i");
        }

        public static ComplexNumber operator / (ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            double denominator = Math.Pow(secondNumber.RealPart, 2) + Math.Pow(secondNumber.ImagonaryPart, 2);
            if (denominator == 0)
            {
                throw new Exception("Неможлива операція ділення на нуль!!!");
            }
            else
            {
                double firstNumerator = Math.Round((firstNumber.RealPart * secondNumber.RealPart + 
                                        firstNumber.ImagonaryPart * secondNumber.ImagonaryPart) / denominator, 4);
                double secondNumerator = Math.Round((firstNumber.ImagonaryPart * secondNumber.RealPart - 
                                         firstNumber.RealPart * secondNumber.ImagonaryPart) / denominator, 4);
                return new ComplexNumber($"{firstNumerator}{(secondNumerator >= 0 ? "+" : "")}{secondNumerator}i");
            }
        }

        public double moduleComplexNumber()
        {
            return Math.Sqrt( Math.Pow(RealPart, 2) + Math.Pow(ImagonaryPart ,2));
        }

        public override string ToString()
        {
            return MyStringWithChar;
        }

    }
}
