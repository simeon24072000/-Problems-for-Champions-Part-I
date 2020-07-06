using System;
using System.Text;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static StringBuilder YearDigits = new StringBuilder();
        static void Main()
        {
            int StartYear = int.Parse(Console.ReadLine());
            int EndYear = int.Parse(Console.ReadLine());
            int Weigth = int.Parse(Console.ReadLine());

            int year = 1900;
            var counter = 0;

            for (int years = StartYear; years <= EndYear; years++)
            {
                for (int months = 1; months <= 12; months++)
                {
                    if (months == 4 || months == 6 || months == 9 || months == 11)
                    {
                        SumMonthDigits(StartYear, EndYear, Weigth, ref counter, years, months, 30);
                    }
                    else if (months == 2)
                    {
                        if (year == years)
                        {
                            SumMonthDigits(StartYear, EndYear, Weigth, ref counter, years, months, 29);
                            year += 4;
                        }
                        else
                        {
                            SumMonthDigits(StartYear, EndYear, Weigth, ref counter, years, months, 28);
                        }
                    }
                    else
                    {
                        SumMonthDigits(StartYear, EndYear, Weigth, ref counter, years, months, 31);
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static void SumMonthDigits(int StartYear, int EndYear, int Weigth,
            ref int counter, int years, int months, int endDay)
        {
            for (int days = 1; days <= endDay; days++)
            {
                int Sumofdigits = 0;

                YearDigits.Append(days);
                YearDigits.Append(months);
                YearDigits.Append(years);

                string YearDigitsStr = YearDigits.ToString();
                int length = YearDigitsStr.Length;

                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (Sumofdigits > Weigth)
                        {
                            goto WeigthNotMatched;
                        }
                        else Sumofdigits += (YearDigitsStr[i] - '0') * (YearDigitsStr[j] - '0');
                    }
                }
                if (Sumofdigits == Weigth && years >= StartYear && years <= EndYear)
                {
                    counter++;
                    if (days >= 10)
                    {
                        if (months >= 10)
                        {
                            Console.WriteLine("{0}-{1}-{2}", days, months, years);
                        }
                        else Console.WriteLine("{0}-0{1}-{2}", days, months, years);
                    }
                    else if (days < 10)
                    {
                        if (months < 10)
                        {
                            Console.WriteLine("0{0}-0{1}-{2}", days, months, years);
                        }
                        else Console.WriteLine("0{0}-{1}-{2}", days, months, years);
                    }
                }

                WeigthNotMatched:;
                YearDigits.Clear();
            }
        }
    }
}
