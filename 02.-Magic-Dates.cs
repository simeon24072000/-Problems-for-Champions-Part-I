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
            int StartYear = int.Parse(Console.ReadLine());
            int EndYear = int.Parse(Console.ReadLine());
            int Weigth = int.Parse(Console.ReadLine());
            //DateTime start = DateTime.Now;
            int year = 1900;
            StringBuilder YearDigits = new StringBuilder();
            int length = 0;
            string YeardigitsStr = "";
            int Sumofdigits = 0;
            var counter = 0;
            var isMore = false;

            for (int years = StartYear; years <= EndYear; years++)
            {
                for (int months = 1; months <= 12; months++)
                {
                    if (months == 4 || months == 6 || months == 9 || months == 11 )
                    {
                        for (int days = 1; days <= 30; days++)
                        {
                            YearDigits.Append(days);
                            YearDigits.Append(months);
                            YearDigits.Append(years);
                            YeardigitsStr = YearDigits.ToString();
                            length = YeardigitsStr.Length;
                            for (int i = 0; i < length; i++)
                            {
                                for (int j = i + 1; j < length; j++)
                                {
                                    if (Sumofdigits > Weigth)
                                    {
                                        isMore = true;
                                        break;
                                    }
                                    else Sumofdigits += (YeardigitsStr[i] - '0') * (YeardigitsStr[j] - '0');
                                }
                                if (isMore)
                                {
                                    break;
                                }
                            }
                            if (Sumofdigits == Weigth && (years >= StartYear && years <= EndYear))
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
                                else if(days < 10)
                                {
                                    if (months < 10)
                                    {
                                        Console.WriteLine("0{0}-0{1}-{2}", days, months, years);
                                    }
                                    else Console.WriteLine("0{0}-{1}-{2}", days, months, years);
                                }

                            }
                            YearDigits.Clear();
                            Sumofdigits = 0;
                            isMore = false;
                        }
                    }
                    else if (months == 2)
                    {
                        if (year == years)
                        {
                            for (int days = 1; days <= 29; days++)
                            {
                                YearDigits.Append(days);
                                YearDigits.Append(months);
                                YearDigits.Append(years);
                                YeardigitsStr = YearDigits.ToString();
                                length = YeardigitsStr.Length;
                                for (int i = 0; i < length; i++)
                                {
                                    for (int j = i + 1; j < length; j++)
                                    {
                                        if (Sumofdigits > Weigth)
                                        {
                                            isMore = true;
                                            break;
                                        }
                                        else Sumofdigits += (YeardigitsStr[i] - '0') * (YeardigitsStr[j] - '0');
                                    }
                                    if (isMore)
                                    {
                                        break;
                                    }
                                }
                                if (Sumofdigits == Weigth && (years >= StartYear && years <= EndYear))
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
                                YearDigits.Clear();
                                Sumofdigits = 0;
                                isMore = false;
                            }
                            year += 4;
                        }
                        else
                        {
                            for (int days = 1; days <= 28; days++)
                            {
                                YearDigits.Append(days);
                                YearDigits.Append(months);
                                YearDigits.Append(years);
                                YeardigitsStr = YearDigits.ToString();
                                length = YeardigitsStr.Length;
                                for (int i = 0; i < length; i++)
                                {
                                    for (int j = i + 1; j < length; j++)
                                    {
                                        if (Sumofdigits > Weigth)
                                        {
                                            isMore = true;
                                            break;
                                        }
                                        else Sumofdigits += (YeardigitsStr[i] - '0') * (YeardigitsStr[j] - '0');
                                    }
                                    if (isMore)
                                    {
                                        break;
                                    }
                                }
                                if (Sumofdigits == Weigth && (years >= StartYear && years <= EndYear))
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
                                YearDigits.Clear();
                                Sumofdigits = 0;
                                isMore = false;
                            }
                        }
                    }
                    else
                    {
                        for (int days = 1; days <= 31; days++)
                        {
                            YearDigits.Append(days);
                            YearDigits.Append(months);
                            YearDigits.Append(years);
                            YeardigitsStr = YearDigits.ToString();
                            length = YeardigitsStr.Length;
                            for (int i = 0; i < length; i++)
                            {
                                for (int j = i + 1; j < length; j++)
                                {
                                    if (Sumofdigits > Weigth)
                                    {
                                        isMore = true;
                                        break;
                                    }
                                    else Sumofdigits += (YeardigitsStr[i] - '0') * (YeardigitsStr[j] - '0');
                                }
                                if (isMore)
                                {
                                    break;
                                }
                            }
                            if (Sumofdigits == Weigth && (years >= StartYear && years <= EndYear))
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
                            YearDigits.Clear();
                            Sumofdigits = 0;
                            isMore = false;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
            //DateTime end = DateTime.Now;
            //Console.WriteLine(end - start);
        }
    }
}