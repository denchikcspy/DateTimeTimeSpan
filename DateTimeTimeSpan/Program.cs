////a
//DateTime now = DateTime.Now;
//Console.WriteLine(DateTime.Now.ToString("dddd:d:MMMM:yy:mm"));
//Console.WriteLine();
////b
//Console.Write("Введіть рік народження (РРРР): ");
//int userYear = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введіть місяць народження (1-12): ");
//int userMonth = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введіть день народження (1-31): ");
//int userDay = Convert.ToInt32(Console.ReadLine());
//DateTime userBirthDate = new DateTime(userYear, userMonth, userDay);
//int ageYears = now.Year - userBirthDate.Year;
//if (now < userBirthDate.AddYears(ageYears))
//{
//    ageYears--;
//}

//int totalMonths = ((now.Year - userBirthDate.Year) * 12) + now.Month - userBirthDate.Month;
//if (now.Day < userBirthDate.Day)
//{
//    totalMonths--;
//}

//Console.WriteLine($"Вам років: {ageYears}");
//Console.WriteLine($"Всього місяців прожито: {totalMonths}");
//Console.WriteLine();
////c
//DateTime myBirthday = new DateTime(2011, 11, 29, 0, 0, 0);
//TimeSpan timeLived = now - myBirthday;
//Console.WriteLine($"Моя дата народження: {myBirthday.ToString("d")}");
//Console.WriteLine($"Я прожив(ла): {Math.Truncate(timeLived.TotalSeconds)} секунд");
//Console.WriteLine();
////d
//Console.Write("Введіть рік: ");
//int anyYear = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введіть місяць: ");
//int anyMonth = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введіть день: ");
//int anyDay = Convert.ToInt32(Console.ReadLine());

//DateTime UserDate = new DateTime(anyYear, anyMonth, anyDay);
//string dayOfWeekName = UserDate.ToString("dddd");
//Console.WriteLine($"Цей день — {dayOfWeekName}");
//Console.WriteLine();
DateTime time = DateTime.Now;
Console.WriteLine($"Сьогодні {time.ToString("dddd MMMM yyyy")}");
DateTime now = DateTime.Now;
Console.WriteLine(now); // Виклик без .ToString()







