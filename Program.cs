using System;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задание 1
        
            // PrintHeader("Лабораторная работа 8");
            // PrintHeader("Проверка заголовка");
            

            
            // Задание 2
            
            // Console.WriteLine($"Max(5, 10) = {Max(5, 10)}");
            // Console.WriteLine($"IsEven(4) = {IsEven(4)}");
            // Console.WriteLine($"IsEven(7) = {IsEven(7)}");
            // Console.WriteLine($"IsEven(0) = {IsEven(0)}");
            

            
            // Задание 3
          
            // int[] arr = { 120, 45, 300, 80, 15, 210 };
            // Console.WriteLine($"Average: {Average(arr):F2}");
            // Console.WriteLine($"CountGreater(100): {CountGreater(arr, 100)}");
            

            
            // Задание 4
            
            // Console.WriteLine($"0 C = {ToFahrenheit(0)} F");
            // Console.WriteLine($"100 C = {ToFahrenheit(100)} F");
            // Console.WriteLine($"37 C = {ToFahrenheit(37)} F");
            

            
            // Задание 5
        
            // Console.WriteLine($"Factorial(5) = {Factorial(5)}");
            // Console.Write("Простые числа от 2 до 50: ");
            // for (int i = 2; i <= 50; i++) {
            //     if (IsPrime(i)) Console.Write(i + " ");
            // }
            // Console.WriteLine();
           

            
            // Задание 6
            
            // int num1 = ReadPositive("Введите первое положительное число: ");
            // int num2 = ReadPositive("Введите второе положительное число: ");
            // Console.WriteLine($"Сумма: {num1 + num2}");
           

           
            // Дополнительное задание
            
            // Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}");
            // Console.WriteLine($"Lcm(4, 6) = {Lcm(4, 6)}");
            

            
            // Итоговая задача: Меню-калькулятор
            
            MenuCalculator();
            
        }

        // Методы

        // Задание 1
        static void PrintLine()
        {
            Console.WriteLine("⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐");
        }

        static void PrintHeader(string title)
        {
            PrintLine();
            Console.WriteLine(title);
            PrintLine();
        }

        // Задание 2.1
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Задание 2.2
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        // Задание 3
        static double Average(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int sum = 0;
            foreach (int num in arr) sum += num;
            return (double)sum / arr.Length;
        }

        static int CountGreater(int[] arr, int limit)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num > limit) count++;
            }
            return count;
        }

        // Задание 4
        static double ToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        // Задание 5
        static long Factorial(int n)
        {
            if (n <= 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++) result *= i;
            return result;
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Задание 6
        static int ReadPositive(string message)
        {
            int number;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
            return number;
        }

        // Дополнительное задание
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Lcm(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }

        // Итоговая задача
        static void MenuCalculator()
        {
            int choice;
            do
            {
                Console.WriteLine("Меню-калькулятор");
                Console.WriteLine("1. Сложить два числа");
                Console.WriteLine("2. Найти максимум из двух чисел");
                Console.WriteLine("3. Факториал числа");
                Console.WriteLine("4. Проверить число на простоту");
                Console.WriteLine("5. НОД и НОК двух чисел");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");
                
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Нет такого пункта");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        int n1 = ReadPositive("Введите первое число: ");
                        int n2 = ReadPositive("Введите второе число: ");
                        Console.WriteLine($"Сумма: {n1 + n2}");
                        break;
                    case 2:
                        int m1 = ReadPositive("Введите первое число: ");
                        int m2 = ReadPositive("Введите второе число: ");
                        Console.WriteLine($"Максимум: {Max(m1, m2)}");
                        break;
                    case 3:
                        int f = ReadPositive("Введите число для факториала: ");
                        Console.WriteLine($"Факториал: {Factorial(f)}");
                        break;
                    case 4:
                        int p = ReadPositive("Введите число для проверки: ");
                        Console.WriteLine($"Простое? {IsPrime(p)}");
                        break;
                    case 5:
                        int g1 = ReadPositive("Введите первое число: ");
                        int g2 = ReadPositive("Введите второе число: ");
                        Console.WriteLine($"НОД: {Gcd(g1, g2)}, НОК: {Lcm(g1, g2)}");
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта");
                        break;
                }
            } while (choice != 0);
        }
    }
}