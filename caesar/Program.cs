using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Input the key: ");
            string keyString = Console.ReadLine();
            int key;
            //Check key
            bool success = int.TryParse(keyString, out key);
            if (success)
            {
                //Shift letters only

                int n = text.Length;
                //Change from text to ASCII values
                //var asciiValue = Encoding.ASCII.GetBytes(text);

                int[] newText = new int[n];
                char[] arr = new char[n];
                for (int i = 0; i < n; i++)
                {
                    var a = text[i];
                    //var b = asciiValue[i];
                                        
                    if (char.IsLetter(a))
                    {
                        var b = (int)a;
                        if (char.IsUpper(a))
                        {
                            if (b <= (90 - key))
                                newText[i] = b + key;
                            else
                                newText[i] = b + key - 26;
                        }
                        if (char.IsLower(a))
                        {
                            if (b <= (122 - key))
                                newText[i] = b + key;
                            else
                                newText[i] = b + key - 26;
                        }
                    }
                    else
                        newText[i] = (int)a;
                }
                //Convert form ASCII to char
                for (int i = 0; i < n; i++)
                {
                    arr[i] = (char)newText[i];
                    Console.WriteLine(arr[i]);
                }
                Console.ReadLine();
            }                
            else
                Console.WriteLine("Please input a valid key. A key must be a number.");
            
        }
    }
}
