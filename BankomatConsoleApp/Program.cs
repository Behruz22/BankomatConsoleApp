using BankomatConsoleApp;
using System.Text;

bool exit = true;

StringBuilder result = new StringBuilder();
BankomatDbContext context = new BankomatDbContext();

while (exit)
{
    Console.Write("Summani kiriting: ");
    bool summaBeauty = int.TryParse(Console.ReadLine(), out int summa);

    if (summaBeauty)
    {
        if (summa > 0)
        {
            if (summa % 5 == 0)
            {
                int temp100 = summa / 100;// 100 lar soni
                int temp50 = (summa % 100) / 50;// 50 lar soni
                int temp20 = ((summa % 100) % 50) / 20;// 20 lar soni
                int temp10 = (((summa % 100) % 50) % 20) / 10;// 10 lar soni 
                int temp5 = ((((summa % 100) % 50) % 20) % 10) / 5; // 5 lar soni

                if (temp100 != 0)
                    if (temp100 == 1)
                        result.Append("100+");
                    else
                        result.Append($"{temp100}*100+");

                if (temp50 != 0)
                    if (temp50 == 1)
                        result.Append("50+");
                    else
                        result.Append($"{temp50}*50+");

                if (temp20 != 0)
                    if (temp20 == 1)
                        result.Append("20+");
                    else
                        result.Append($"{temp20}*20+");

                if (temp10 != 0)
                    if (temp10 == 1)
                        result.Append("10+");
                    else
                        result.Append($"{temp10}*10+");

                if (temp5 != 0)
                    result.Append("5 ");

                result.Remove(result.Length - 1, 1);
                Console.WriteLine(result.ToString());

                context.Bankomats.Add(new Bankomat
                {
                    Input = summa,
                    Output = result.ToString()

                });
                context.SaveChanges();

                result.Clear();
                exit = false;

                #region 2-urunish
                //int temp20, temp10;
                //int temp100 = summa / 100;
                //int temp50 = (summa % 100)/50;
                //if (temp50 != 0)
                //{
                //    temp20 = (summa % 100) / 20;
                //    if (temp20 != 0)
                //    {
                //        temp10 = (summa % 100) / 10;
                //    }
                //    else
                //    {
                //        temp10 = (summa % 100) / 10;
                //    }
                //}
                //else
                //{
                //    temp20 = (summa % 100) / 20;
                //    if (temp20 != 0)
                //    {
                //        temp10 = (summa % 100) / 10;
                //    }
                //    else
                //    {
                //        temp10 = (summa % 100) / 10;
                //    }
                //}

                //int temp5 = summa % 10;
                //Console.WriteLine($"100 -> {temp100}");
                //Console.WriteLine($"50 -> {temp50}");
                //Console.WriteLine($"20 -> {temp20}");
                //Console.WriteLine($"10 -> {temp10}");
                //Console.WriteLine($"5 -> {temp5}");




                //int temp = summa / 100;
                //int temp2 = (summa % 100) / 10;
                //int temp3 = summa % 10;
                #endregion

                #region 1 Urunish
                //Console.WriteLine(temp);
                //Console.WriteLine(temp2);
                //Console.WriteLine(temp3);
                //if (temp != 0)
                //    result = $"{temp}*100";
                //if (temp2 != 0)
                //{
                //    if (temp2 >= 5)
                //    {
                //        temp2 -= 5;
                //        result += "+50";
                //        if (temp2 >= 2)
                //        {
                //            temp2 -= 2;
                //            result += "+20";
                //            if (temp2 >= 2)
                //            {
                //                temp2 -= 2;
                //                result += "+20";
                //            }
                //            if (temp2 >= 1)
                //            {
                //                temp2 -= 1;
                //                result += "+10";
                //            }
                //        }
                //        else
                //        {
                //            if (temp2 >= 1)
                //            {
                //                temp2 -= 1;
                //                result += "+10";
                //            }
                //        }

                //    }
                //    else
                //    {
                //        if (temp2 >= 2)
                //        {
                //            temp2 -= 2;
                //            result += "+20";
                //            if (temp2 >= 2)
                //            {
                //                temp2 -= 2;
                //                result += "+20";
                //            }
                //            else if (temp2 >= 1)
                //            {
                //                temp2 -= 1;
                //                result += "+10";
                //            }
                //        }
                //    }
                //}
                //if (temp3 != 0)
                //    result += "+5";
                //Console.WriteLine(result);
                #endregion
            }
            else
            {
                Console.WriteLine("Summa bilan amaliyotni amalga oshirib bo'lmaydi!");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("Manfiy summa kiritish mumkin emas!");
            Console.ReadKey();
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("Notog'ri qiymat kiritildi!");
        Console.ReadKey();
        Console.Clear();
    }
}

