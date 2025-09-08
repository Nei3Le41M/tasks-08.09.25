using System;

class Program
{
    static void Main(string[] args)
    //№1
    {
        //Console.WriteLine("Введите число: ");
        //int number = int.Parse(Console.ReadLine());
        //if (number > 0)
        //{
        //    Console.WriteLine("Число положительное");
        //}
        //else if (number < 0)
        //{
        //    Console.WriteLine("Число отрицательное");
        //}
        //else
        //{
        //    Console.WriteLine("Число равно нулю");
        //}


        //{
        //    Console.WriteLine("Введите число: \nИли нажмине клавишу 'Q' для выхода.");
        //    while (true)
        //    {
        //        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        //        if (keyInfo.Key == ConsoleKey.Q)
        //        {
        //            Console.WriteLine("Выход из программы.");
        //            break;
        //        }
        //        Console.Write(keyInfo.KeyChar);
        //        string input = keyInfo.KeyChar + Console.ReadLine();

        //        if (int.TryParse(input, out int number))
        //            if (number > 0)
        //            {
        //                Console.WriteLine("Число положительное");
        //            }
        //            else if (number < 0)
        //            {
        //                Console.WriteLine("Число отрицательное");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Число равно нулю");
        //            }
        //    }
        //    Console.ReadKey();
        //}

        //№2
        //Console.WriteLine("Введите возраст: ");
        //string year = Console.ReadLine();
        //if (int.TryParse(year, out int age))
        //{
        //    if (age <= 12)
        //    {
        //        Console.WriteLine("Ребенок");
        //    }
        //    else if (age <= 17)
        //    {
        //        Console.WriteLine("Подросток");
        //    }
        //    else if (age > 17)
        //    {
        //        Console.WriteLine("Взрослый");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Ошибка! Введите число. ");
        //}

        //№3
        //Console.WriteLine("Введите число: ");
        //int number = int.Parse(Console.ReadLine());
        //if (number % 2 == 0)
        //{
        //    Console.WriteLine("Число четное");
        //}
        //else
        //{
        //    Console.WriteLine("Число нечетное");
        //}

        //№4
        //Console.WriteLine("Введите оценку по 100-балльной системе: ");
        //int grade = int.Parse(Console.ReadLine());
        //if (grade >= 90)
        //{
        //    Console.WriteLine("Отлично");
        //}
        //else if (grade >= 70)
        //{
        //    Console.WriteLine("Хорошо");
        //}
        //else if (grade >= 50)
        //{
        //    Console.WriteLine("Удовлетворительно");
        //}
        //else
        //{
        //    Console.WriteLine("Неудовлетворительно");
        //}

        //№5
        //Console.WriteLine("Введите два числа: ");
        //Console.WriteLine("Первое число: ");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Второе число: ");
        //int num2 = int.Parse(Console.ReadLine());
        //if (num1 > num2)
        //{
        //    Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
        //}
        //else if (num1 < num2)
        //{
        //    Console.WriteLine($"Второе число {num2} больше первого числа {num1}");
        //}
        //else
        //{
        //    Console.WriteLine("Числа равны");
        //}

        //№6
        //Console.WriteLine("Введите три числа: ");
        //Console.WriteLine("Первое число: ");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Второе число: ");
        //int num2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Третье число: ");
        //int num3 = int.Parse(Console.ReadLine());
        //if (num1 > num2 && num1 > num3)
        //{
        //    Console.WriteLine($"Первое число {num1} больше второго числа {num2} и третьего числа {num3}");
        //}
        //else if (num2 > num1 && num2 > num3)
        //{
        //    Console.WriteLine($"Второе число {num2} больше первого числа {num1} и третьего числа {num3}");
        //}
        //else if (num3 > num1 && num3 > num2)
        //{
        //    Console.WriteLine($"Третье число {num3} больше первого числа {num1} и второго числа {num2}");
        //}
        //else
        //{
        //    Console.WriteLine("Все числа равны");
        //}

        //№7
        //Console.WriteLine("Введите первое число: ");
        //double a = double.Parse(Console.ReadLine());

        //Console.WriteLine("Введите оператор(+, -, *, /): ");
        //string op = Console.ReadLine();

        //Console.WriteLine("Введите второе число: ");
        //double b = double.Parse(Console.ReadLine());

        //double result;

        //if (op == "+")
        //{
        //    result = a + b;
        //}
        //else if (op == "-")
        //{
        //    result = a - b;
        //}
        //else if (op == "*")
        //{
        //    result = a * b;
        //}
        //else if (op == "/")
        //{
        //    if (b != 0)
        //        result = a / b;
        //    else
        //    {
        //        Console.WriteLine("Ошибка деления на ноль!");
        //        return;
        //    }
        //}

        //else
        //{
        //    Console.WriteLine("Неизвестный оператор!");
        //    return;
        //}

        //Console.WriteLine("Результат: " + result);

        //№8
        //Console.WriteLine("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        //{
        //    Console.WriteLine(year + " — високосный год");
        //}
        //else
        //{
        //    Console.WriteLine(year + " — не високосный год");
        //}

        //dz
        //№1
        //Console.WriteLine("Введите число: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Анализ числа: {number}");
        //if (number > 0)
        //    Console.WriteLine("Натуарльное число");
        //else
        //    Console.WriteLine("Не натуральное число");

        //if (number % 2 == 0)
        //    Console.WriteLine("Четное число");
        //else
        //    Console.WriteLine("Нечетное число");

        //if (number > 1)
        //{
        //    if (NumCheck(number))
        //        Console.WriteLine("Число простое");
        //    else
        //        Console.WriteLine("Число простое");
        //}
        //else
        //{
        //    Console.WriteLine("Не является ни простым, ни составным");
        //}
    
        //static bool NumCheck(int num)
        //{
        //    var result = true;

        //    if (num > 1)
        //    {
        //        for (var i = 2u; i < num; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                result = false;
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        result = false;
        //    }

        //    return result;
        //}
    }
}