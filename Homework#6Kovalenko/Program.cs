// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)

{
    //// 1.Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
    //// Після отримання всіх значень програма має обчислити та вивести середній заробіток.

    //decimal averagePay = 0m;
    //decimal q = 0m;
    //string? nameWorker1;
    //decimal payWorker1;



    //for (int i = 1; i <= 3; i++)

    //{
    //    Console.Write("\nВведіть: Ім'я: ");
    //    nameWorker1 = Console.ReadLine();
    //    Console.Write("Введіть зарплату: ");
    //    payWorker1 = decimal.Parse(Console.ReadLine());
    //    Console.WriteLine("-------------------------");

    //    q = q + payWorker1;
    //    averagePay = q / i;
    //}

    //Console.WriteLine($"\nСередня заробітна плата становить {averagePay} ");


    ////2.Напишіть програму, яка будує графік за допомогою зірочок. Користувач повинен ввести кількість рядків графіка.
    ////Кожен рядок графіка має містити відповідну кількість зірочок.

    //Console.Write("Введіть кількість рядків:");
    //int Line = int.Parse(Console.ReadLine());

    //for (int i = Line; i >= 1; i--)
    //{
    //    for (int j = 1; j <= Line; j++)
    //        if (i > j)
    //        {
    //            Console.Write(" ");
    //        }
    //        else
    //        {
    //            Console.Write("*");
    //        }

    //    Console.WriteLine("");
    //}

    ////3.Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа.
    //// Просте число -це число, яке ділиться лише на 1 і на себе.

    //Console.Write("Введіть діпазон від 2 до : ");
    //int endNumber = int.Parse(Console.ReadLine());
    //for (int i = 2; i <= endNumber; i++)
    //{
    //    bool Number = true;
    //    for (int j = 2; j < i; j++)
    //    {
    //        if (i % j == 0)

    //        {
    //            Number = false;
    //        }
    //    }
    //    if (Number)
    //    {
    //        Console.Write("{0} ", i);
    //    }
    //}

    ////4.Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача.
    ////Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, 
    ////а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).

    ////5.Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі.
    ////Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

    //Console.Write("ВВедіть максимальне число: ");
    //int maxValue = int.Parse( Console.ReadLine());
    //int valueFibonache1 = 0;
    //int valueFibonache2 = 1;
    //int sumValue = 0;

    //while (sumValue < maxValue)
       
    //{
    //    sumValue = valueFibonache2 + valueFibonache1;
    //    valueFibonache1 = sumValue;

    //    if (sumValue > maxValue)
    //    {
    //        break;
    //    }
    //    else
    //    {
    //        Console.Write($" {sumValue}");
    //    }

    //    sumValue = valueFibonache2 + valueFibonache1;
    //    valueFibonache2 = sumValue;

    //    if (sumValue > maxValue)
    //    {
    //        break;
    //    }
    //    else
    //    {
    //        Console.Write($" {sumValue}");
    //    }

    //}





   Console.Write("\nExit: 1 - Yes / 2 - No ");

    int.TryParse((Console.ReadLine()), out int exit);

    if (exit == 1)

    { break; }

    else if (exit == 2)
    {
        Console.Clear();
        continue;
    }

    else { Console.WriteLine("\nIncorrect format!"); }
}
