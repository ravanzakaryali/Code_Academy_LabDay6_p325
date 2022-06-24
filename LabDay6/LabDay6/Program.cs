using System;

namespace LabDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomSubString("revan",1,1));
        }
        public static string CustomSubString(string text, int startIndex)
        {
            string newText = "";
            for (int i = startIndex; i < text.Length; i++)
            {
                newText += text[i];
            }
            return newText;
        }
        public static string CustomSubString(string text, int startIndex, int lenght)
        {
            string newText = "";
            if(text.Length < startIndex + lenght)
            {
                return "Sehvdi";
            }
            for (int i = startIndex; i < lenght + startIndex; i++)
            {
                newText += text[i];
            }
            return newText;
        }
    }
}
