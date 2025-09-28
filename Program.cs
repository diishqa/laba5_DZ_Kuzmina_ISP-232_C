using System.Numerics;

namespace laba5_DZ_Kuzmina_ISP_232_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //Console.WriteLine("1. - Ничего");
            //Console.WriteLine("2. -  void ShowWelcomeMessage()");
            //Console.WriteLine("3. - Метод вызовет ошибку компиляции");
            //Console.WriteLine("4. - void PrintNumber(int number)");
            //Console.WriteLine("5. - PrintMessage('Hello, World!')");
            //задание 2
            //void GreetUser(string name)
            //{
            //    Console.WriteLine($"Привет, {name}! Добпро пожаловать в программу!");
            //}
            //Console.Write("Введите ваше имя: ");
            //string usname = Console.ReadLine();
            //GreetUser(usname);
            //задание 3
            //void AddNumbers(int n, int m)
            //{
            //    Console.WriteLine($"Сумма чисел: {n + m}");
            //}
            //Console.WriteLine("Введите 2 числа: ");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //AddNumbers(num1, num2 );
            //задание 4
            //void IsEven(int n)
            //{
            //    if (n % 2 == 0)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //    }
            //}
            //Console.Write("Введите число: ");
            //int num=Convert.ToInt32(Console.ReadLine());
            //IsEven(num);
            //задание 5
            //void FindMax(int[] chis)
            //{
            //    int max= 0;
            //    foreach (int i in chis)
            //    {
            //        if (i > max)
            //        {
            //            max= i;
            //        }
            //    }
            //    Console.WriteLine($"Наибольшее занчение: {max}");
            //}
            //int[] nums = [2, 6, 12, 86, 43, 1, 34, 6, 2, 8, 5, 3];
            //FindMax(nums);
            //задание 6
            //void ConvertCelsiusToFahrenheit(int C)
            //{
            //    int F = C * (9 / 5) + 32;
            //    Console.WriteLine($"{C}-->{F}");
            //}
            //Console.Write("Введите градусы: ");
            //int gr = Convert.ToInt32(Console.ReadLine());
            //ConvertCelsiusToFahrenheit(gr);
            //задание 7
            //void CountVowels(string str)
            //{
            //    int count = 0;
            //    foreach (char c in str)
            //    {
            //        if (c=='a' || c=='e' || c=='i' || c=='o' || c=='u')
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"Кол-во гластныъ букв: {count}");
            //}
            //Console.WriteLine("Введите текст: ");
            //string text = Console.ReadLine();
            //CountVowels(text);
            //задание 8
            //void GeneratePassword(int lenght)
            //{
            //    string sym = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            //    string pas = "";
            //    Random random = new Random();
            //    for(int i=0; i<lenght; i++)
            //    {
            //        int index=random.Next(sym.Length);
            //        pas += sym[index];
            //    }
            //    Console.WriteLine($"Пароль - {pas}");
            //}
            //Console.Write("Введите длину пароля: ");
            //int len = Convert.ToInt32(Console.ReadLine());
            //GeneratePassword(len);


            //Console.ReadLine();
            //задание 9
            //void IsPalindrome(string str)
            //{
            //    int l=0;
            //    int r=str.Length - 1;

            //    while(l < r)
            //    {
            //        if (str[l] != str[r])
            //        {
            //            Console.WriteLine("не полиндром");
            //            return;
            //        }
            //        l++;
            //        r--;
            //    }
            //    Console.WriteLine("Полиндром");
            //}
            //Console.Write("Введите строку: ");
            //string input = Console.ReadLine();
            //IsPalindrome(input);
            //задание 10
            //void ReverseArray(int[] m)
            //{
            //    int lenm = m.Length;
            //    int[] m2 = new int[lenm];

            //    for (int i = 0; i < lenm; i++)
            //    {
            //        int r = lenm - i - 1;
            //        m2[i] = m[r];
            //        r--;
            //    }
            //    foreach (int i in m2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int[] mas = [ 1, 2, 3, 4, 5, 6, 7 ];
            //ReverseArray(mas);
            //задание 11
            //void slozh (int n, int m)
            //{
            //    Console.WriteLine($"Сложение: {n}+{m}={n + m}");
            //}
            //void vicht (int n, int m)
            //{
            //    Console.WriteLine($"Вычитание: {n}-{m}={n - m}");
            //}
            //void umno(int n, int m)
            //{
            //    Console.WriteLine($"Умножение: {n}*{m}={n * m}");
            //}
            //void delen(int n, int m)
            //{
            //    Console.WriteLine($"Деление: {n}:{m}={n / m}");
            //}
            //Console.WriteLine("Введите 2 числа: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите действие: ");
            //string de = Console.ReadLine();
            //if (de == "+")
            //{
            //    slozh(num1, num2);
            //}
            //else if (de == "-")
            //{
            //    vicht(num1, num2);
            //}
            //else if (de == "*")
            //{
            //    umno(num1, num2);
            //}
            //else if (de == "/" || de == ":")
            //{
            //    delen(num1, num2);
            //}
            //задание 12
            void IsPrime(int pr)
            {
                int samsebya = 0;
                for(int i=2; i<=pr; i++)
                {
                    if (pr % i == 0)
                    {
                        samsebya++;
                    }
                }
                if (samsebya==1)
                {
                    Console.WriteLine(pr);
                }
                
            }
            void PrintPrimesUpTo(int n)
            {
                for (int i = 2; i <= n; i++)
                {
                    IsPrime(i);
                }
            }
            Console.Write("введите n: ");
            int num = Convert.ToInt32(Console.ReadLine());
            PrintPrimesUpTo(num);












                Console.ReadLine();


        }
    }
}
