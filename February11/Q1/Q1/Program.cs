using System;
using System.Collections.Generic;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainString = "eidbaooo";
            string miniString = "ab";
            var subString = "";
            List<string> subStringList = new List<string>();
            for (int i = 1; i < mainString.Length; i++)
            {
                for (int j = 0; j <= mainString.Length -i; j++)
                {
                    subString = mainString.Substring(j, i);
                    //subStringList.Add(subString);
                    Console.WriteLine(subString);
                }
            }


            //for (int i = 0; i <= mainString.Length; i++)
            
                if (subString == miniString)
                {
                    Console.WriteLine("True");
                   
                }
                else
                {
                    Console.WriteLine("False");
                }
            

            /*for (int i = 0; i < mainString.Length; i++)
            {
                if (subStringList[i].Equals(miniString))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }*/



            Console.ReadKey();
        }
    }
}
