using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace array.example
{
    class ChangeTiles
    {
        static void Main()
        {
            int Start = int.Parse(Console.ReadLine());
            int End = int.Parse(Console.ReadLine());
            int sum = 0;
            var isPrinted = false;
            StringBuilder buildCipher = new StringBuilder();
            var RemovedLetters = new List<char>();
            for (var a = 'a'; a <= 'e'; a++)
            {
                for (var b = 'a'; b <= 'e'; b++)
                {
                    for (var c = 'a'; c <= 'e'; c++)
                    {
                        for (var d = 'a'; d <= 'e'; d++)
                        {
                            for (var e = 'a'; e <= 'e'; e++)
                            {
                                for (int i = 0; i < 1; i++)
                                {
                                    buildCipher.Append(a);
                                    buildCipher.Append(b);
                                    buildCipher.Append(c);
                                    buildCipher.Append(d);
                                    buildCipher.Append(e);
                                    int length = buildCipher.ToString().Length;
                                    for (int letter = 0; letter < length; letter++)
                                    {
                                        if (RemovedLetters.Contains(buildCipher[letter]))
                                        {
                                            continue;
                                        }
                                        else RemovedLetters.Add(buildCipher[letter]);
                                    }
                                    for (int index = 1; index <= RemovedLetters.Count; index++)
                                    {
                                        switch (RemovedLetters[index - 1])
                                        {
                                            case 'a': sum += index * 5;break;
                                            case 'b': sum += index * -12; break;
                                            case 'c': sum += index * 47; break;
                                            case 'd': sum += index * 7; break;
                                            case 'e': sum += index * -32; break;
                                            default: break;
                                        }
                                    }
                                    if (sum >= Start && sum <= End)
                                    {
                                        isPrinted = true;
                                        Console.Write("{0}{1}{2}{3}{4} ",a,b,c,d,e);
                                    }
                                    buildCipher.Clear();
                                    RemovedLetters.Clear();
                                    sum = 0;
                                }
                            }
                           
                        }
                    }
                }
            }
            if (!isPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}