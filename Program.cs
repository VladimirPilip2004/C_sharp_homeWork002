// Урок 2. Массивы и функции в программировании

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// 1-й способ:
// Console.WriteLine("ведите число трёхзначное: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int firstCutRight = number / 10;
// int secondCutLeft = firstCutRight % 10;
// Console.WriteLine($"Вторая цифра числа {number} - это {secondCutLeft} ");

//2-й способ:
// Console.WriteLine("ведите число трёхзначное: ");
// string number = Console.ReadLine();

// if (number.Length == 3)
//     {
//         Console.WriteLine($"Вторая цифра числа {number} - это {number[1]}");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ трёхзначное. Введите трёхзначное число!");
//     }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

//1-й способ:

// Console.WriteLine("ведите любое целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100)
// {
//     Console.WriteLine($"Ошибка -1. Третьей цифры нет. Введите число больше двух знаков");
// }

// if (number > 99 && number < 1000)
// {
//     //number = number / 10;
//     //number = number / 10;
//     Console.WriteLine(number % 10);
// }

// if (number > 999)
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//         Console.WriteLine(number % 10); 
// }

// while (number.Length == 3)
// {
//     int numberSecond = number / 10;
//     Console.WriteLine(numberSecond);
//     numberSecond++;
// }

//2-й способ:
// Console.WriteLine("ведите любое целое число: ");
// string number = Console.ReadLine();

// if (number.Length >= 3)
//     {
//         Console.WriteLine($"Третья цифра числа {number} - это {number[2]}");
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры нет. Введите не менее трёхзначного числа!");
//     }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//--------------------------------------------------------
// Console.WriteLine("ведите число от 1 до 7: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int sunday = 1;
// int monday = 2;
// int tuesday = 3;
// int wensday = 4;
// int thursday = 5;
// int friday = 6;
// int suturday = 7;

// if (N>=1 && N<=7)
// {
//     if(N == 1 || N == 7)
//     {
//         Console.WriteLine($"{N}-й день является выходным");
//     }else{
//         Console.WriteLine($"{N}-й день является будним");
//     }
// }else{
//     Console.WriteLine("Ошибка! Ведите число от 1 до 7");
// }