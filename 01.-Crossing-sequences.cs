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
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int startNum = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            var listTribonacci = new List<int> { first, second, third };
            var listStepSum = new List<int> { startNum };
            int index = 0;
            int stepmultiple = 1;
            while (third <= 1000000 || startNum <= 1000000)
            {
                int Sum = first + second + third;
                first = second;
                second = third;
                third = Sum;
                listTribonacci.Add(Sum);

                startNum += step * stepmultiple;

                listStepSum.Add(startNum);
                index++;

                if (index % 2 == 0)
                {
                    stepmultiple++;
                }
            }
            var found = false;
            for (int i = 0; i < listTribonacci.Count; i++)
            {
                for (int k = 0; k < listStepSum.Count; k++)
                {
                    if (listTribonacci[i] == listStepSum[k] &&
                        listTribonacci[i] <= 1000000)
                    {
                        found = true;
                        Console.WriteLine(listTribonacci[i]);
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}