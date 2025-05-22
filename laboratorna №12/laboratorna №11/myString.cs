using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna__11
{
    internal class MyString:IMyInterface, ICloneable, IComparable<MyString>
    {
        string myStringWithChar;
        byte widthMyStringWithCharUTF8;


        public MyString()
        {
            MyStringWithChar = "";
        }

        public MyString(string myStringWithChar)
        {
            MyStringWithChar = myStringWithChar;
        }

        public MyString(char myStringWithChar)
        {
            MyStringWithChar = myStringWithChar.ToString();            
        }

        public byte searchSizeMyStringWithCharUTF8()
        {
            return (byte)System.Text.Encoding.UTF8.GetByteCount(myStringWithChar);
        }
        
        public void clearMyString()
        {
            myStringWithChar = "";
            widthMyStringWithCharUTF8 = 0;
        }

        public byte WidthMyStringWithCharUTF8
        {
            get{ return widthMyStringWithCharUTF8; }
        }

        public string MyStringWithChar
        {
            get { return myStringWithChar; }
            set 
            { 
                myStringWithChar = value;
                widthMyStringWithCharUTF8 = searchSizeMyStringWithCharUTF8();
            }
        }

        public override string ToString()
        {
            return $"Стрічка: {myStringWithChar}{Environment.NewLine}Довжина стрічки: {WidthMyStringWithCharUTF8}";
        }

        public int CompareTo(MyString other)
        {
            return WidthMyStringWithCharUTF8.CompareTo(other.WidthMyStringWithCharUTF8);
        }

        public object Clone()
        {
            return new MyString(myStringWithChar);
        }

        public static bool operator < (MyString myString1, MyString myString2)
        {
            return myString1.WidthMyStringWithCharUTF8 < myString2.WidthMyStringWithCharUTF8;
            
        }

        public static bool operator > (MyString myString1, MyString myString2)
        {
            return myString1.WidthMyStringWithCharUTF8 > myString2.WidthMyStringWithCharUTF8;
        }
    }
}
