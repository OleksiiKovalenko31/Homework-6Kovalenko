// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)

{ Console.Clear();
    Console.WriteLine("1.Обчислення середнього заробітку:");
    Console.WriteLine("2.Напишіть програму, яка будує графік за допомогою зірочок.");
    Console.WriteLine("3.Генерація простих чисел:");
    Console.WriteLine("4.Перевірка паролю:");
    Console.WriteLine("5.Генерація фібоначчівської послідовності:");
    Console.WriteLine("6.Калькулятор оплати праці за годину:");
    Console.WriteLine("7.Генерація таблиці множення для конкретного числа:");
    Console.WriteLine("8.Напишіть програму, яка перевіряє, чи є задане користувачем число простим.");
    Console.WriteLine("\nБудь яке інше число чи символ вихід з програми...");
    Console.Write("\nВиберіть завдання: ");

    int.TryParse(Console.ReadLine(), out int HomeWork);
    try
    {
        if (HomeWork == 1)
        {
            // 1.Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
            // Після отримання всіх значень програма має обчислити та вивести середній заробіток.
            Console.Clear();
            Console.WriteLine("1.Обчислення середнього заробітку:");

            decimal averagePay = 0m;
            decimal q = 0m;
            string? nameWorker1;
            decimal payWorker1;

            for (int i = 1; i <= 3; i++)

            {
                Console.Write("\nВведіть: Ім'я: ");
                nameWorker1 = Console.ReadLine();
                Console.Write("Введіть зарплату: ");
                payWorker1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------");

                q = q + payWorker1;
                averagePay = q / i;
            }

            Console.WriteLine($"\nСередня заробітна плата становить {averagePay} ");

        }
        if (HomeWork == 2)
        {
            //2.Напишіть програму, яка будує графік за допомогою зірочок. Користувач повинен ввести кількість рядків графіка.
            //Кожен рядок графіка має містити відповідну кількість зірочок.

            Console.Clear();
            Console.WriteLine("2.Напишіть програму, яка будує графік за допомогою зірочок.");
            Console.Write("\nВведіть кількість рядків:");
            int Line = int.Parse(Console.ReadLine());

            for (int i = Line; i >= 1; i--)
            {
                for (int j = 1; j <= Line; j++)
                    if (i > j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                Console.WriteLine("");
            }
        }

        if (HomeWork == 3)
        {
            //3.Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа.
            // Просте число -це число, яке ділиться лише на 1 і на себе.

            Console.Clear();
            Console.WriteLine("3.Генерація простих чисел:");
            Console.Write("\nВведіть діпазон від 2 до : ");
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= endNumber; i++)
            {
                bool Number = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)

                    {
                        Number = false;
                    }
                }
                if (Number)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        if (HomeWork == 4)
        {
            //4.Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача.
            //Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, 
            //а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).
            Console.Clear();
            Console.WriteLine("Нажаль лекції для  роботи з строками ще не було, а моїх знань бракує не можу виконати це завдання!");
            Console.ReadKey();
        }

        if (HomeWork == 5)
        {
            //5.Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі.
            //Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.
            Console.Clear();
            Console.WriteLine("5.Генерація фібоначчівської послідовності:");

            Console.Write("\nВВедіть максимальне число: ");
            int maxValue = int.Parse(Console.ReadLine());
            int valueFibonache1 = 0;
            int valueFibonache2 = 1;
            int sumValue = 0;

            while (sumValue < maxValue)

            {
                sumValue = valueFibonache2 + valueFibonache1;
                valueFibonache1 = sumValue;

                if (sumValue > maxValue)
                {
                    break;
                }
                else
                {
                    Console.Write($" {sumValue}");
                }

                sumValue = valueFibonache2 + valueFibonache1;
                valueFibonache2 = sumValue;

                if (sumValue > maxValue)
                {
                    break;
                }
                else
                {
                    Console.Write($" {sumValue}");
                }

            }
        }

        if (HomeWork == 6)
        {
            //6.Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день,
            // та розмір годинної ставки.
            // Після введення значень програма має обчислити та вивести оплату за день.
            Console.Clear();
            Console.WriteLine("6.Калькулятор оплати праці за годину:");

            Console.WriteLine("\nПрацівник Петров В.А. -- зварювальник: \n ");
            Console.Write("Кількість годин: ");
            int Hour = int.Parse(Console.ReadLine());

            Console.Write("Ставка за годину: ");
            decimal Pay = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"\nОплата за день становить {Pay * Hour} $");
        }
        if (HomeWork == 7)
        {
            //7.Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число,
            // а потім генерує таблицю множення для цього числа від 1 до 10.
            Console.Clear();
            Console.WriteLine("7.Генерація таблиці множення для конкретного числа:");

            Console.Write($"\nВведіть число: ");
            double Value = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Value} * {i} = {Value * i}");
            }
        }
        if (HomeWork == 8)
        {

            //8.Напишіть програму, яка перевіряє, чи є задане користувачем число простим.
            // Число вважається простим, якщо воно ділиться лише на 1 і на себе.
            Console.Clear();
            Console.WriteLine("8.Напишіть програму, яка перевіряє, чи є задане користувачем число простим.");

            bool prost = true;
            Console.Write("\nВведіть число: ");
            int prValue = int.Parse(Console.ReadLine());
            for (int i = 2; i <= prValue / 2; i++)
            {
                if (prValue % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine($"\nЧисло {prValue} просте");
            }
            else
            {
                Console.WriteLine($"\nЧисло {prValue} має дільники");
            }
        }
    }catch (FormatException enForm) { Console.WriteLine($"Введенний невірний формат {enForm}"); }
        catch (Exception en) { Console.WriteLine(en.Message); }
      


    // Керований вихід з програми
    Console.Write("\nExit: 1 - Yes / 2 - No ");

    int.TryParse((Console.ReadLine()), out int exit);


    if (exit == 1)

    { break; }

    else if (exit == 2)
    {
        Console.Clear();
        continue;
    }

    else
    { 
        Console.WriteLine("\nIncorrect format!");
        Console.ReadKey();
    }
}
