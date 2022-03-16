using System;
using System.Collections.Generic;
using System.Linq;

namespace P127_Delegates
{
    class Program
    {
        public delegate bool Callback(int number);
        public delegate string CustomConcat(string word, string word2);
        public delegate int SumDelegate(int num, int num2);

        public delegate void Write(string word);
        static void Main(string[] args)
        {
            #region Home work

            //List<Fruit> fruits = new List<Fruit>();
            //Apple apple = new Apple("A1");
            //Lemon lemon = new Lemon("C2");
            //Pineapple pineapple = new Pineapple("D2");

            //fruits.Add(lemon);
            //fruits.Add(apple);
            //fruits.Add(pineapple);

            //foreach (Fruit item in fruits)
            //{

            //    if (item is Apple)
            //    {
            //        Apple apple1 = (Apple)item;
            //        Console.WriteLine(apple1.Color);
            //    }

            //}

            //SortedList<string, string> sortedList = new SortedList<string, string>();
            //sortedList.Add("C#","2002");
            //sortedList.Add("Java","1996");
            //sortedList.Add("C++","1986");
            //sortedList.Add("Pyhton","1995");
            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            int[] arr = { 2, 3, 5, 7, 8, 10, 14, 21, 18, 27 };

            //Console.WriteLine("Evens: ");
            //Console.WriteLine(SumEven(arr));
            //Console.WriteLine("Odds: ");
            //Console.WriteLine(SumOdd(arr));
            //Console.WriteLine("Divided by 3: ");
            //Console.WriteLine(SumNumsDivideBy3(arr));
            //Console.WriteLine("Divided by 7: ");
            //Console.WriteLine(SumNumsDivideBy7(arr));

            //Console.WriteLine("Delegate");
            //Console.WriteLine(Sum(arr,IsEven));

            //CustomConcat custom = new CustomConcat(Username);

            CustomConcat custom = Username;

            Console.WriteLine(custom("Isa", "Sadiqli"));

            //SumDelegate sumDelegate = new SumDelegate(Total);

            SumDelegate sumDelegate1 = Total;

            //Console.WriteLine(sumDelegate(5,10));
            Console.WriteLine(sumDelegate1(5, 10));

            //Write write = new Write(Article);

            //Write write = Article;
            //write("Hello World");

            //write.Invoke("Hello World 2");


            //Write write = Class1.MethodA;
            //Write write1 = Class2.MethodB;

            //write("Hello");

            //Write write2 = write + write1;

            //write2("Hello");

            //SumDelegate sumDelegate = delegate (int num1, int num2)
            //{
            //    return num1 + num2;
            //};

            //Console.WriteLine(sumDelegate(5,9)) ;

            //Write write3 = delegate (string word)
            //{
            //    Console.WriteLine(word);
            //};

            //write3("Anonymous");

            /*Write write4 = (string word) => { Console.WriteLine(word); };*/ // lambda expression

            //write4("Lambda");


            //write2 += write4;
            //write2 -= write4;
            //write2("Lambda");








            //Callback callback = num => { return num % 2 == 0; };

            //Callback callback1 = delegate (int num) { return num % 5 == 0; };

            //callback += callback1;

            //Console.WriteLine(callback(10));



            //Action<string> action = Test;
            //action("String");

            //Action<int, int> actionInt = (i, j) => Console.WriteLine(i+j);

            //actionInt(5, 20);

            //Func<int,string,char,string> func = delegate(int i,string word,char letter) { return i + word +letter ; };

            //Console.WriteLine(func(90,"Okay",'A'));


            //Predicate<string> predicate = delegate (string word) { return word.Contains("o"); };



            //Console.WriteLine(predicate("HellO"));

            //Predicate<int> predicate = i => i > 0 && i <30;

            //Console.WriteLine(predicate(-10));



            List<string> list = new List<string>();

            list.Add("Lutfiyar");
            list.Add("Allahsukur");
            list.Add("Kamran");
            list.Add("Ayxan");
            list.Add("Cahangir");
            list.Add("Oruc");

            //Console.WriteLine("List");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //var studentsWithA = list.Where(name => name.Contains("o"));


            //Console.WriteLine("Linq");
            //foreach (string item in studentsWithA)
            //{
            //    Console.WriteLine(item);
            //}

            string exist = Console.ReadLine();

            //string student = list.Find(name => name.ToLower() == exist.ToLower());

            string student = list.FirstOrDefault(name => name.ToLower() == exist.ToLower());

            Console.WriteLine(student);




        }

        public static int Sum(int[] arr, Callback func)
        {
            int total = 0;

            foreach (int number in arr)
            {
                if (func(number))
                {
                    total += number;
                }
            }
            return total;
        }

        //public static int SumEven(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if(IsEven(num))
        //        {
        //            total += num;
        //        }
        //    }
        //    return total;
        //}

        //public static int SumOdd(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (IsOdd(num))
        //        {
        //            total += num;
        //        }
        //    }
        //    return total;
        //}


        //public static int SumNumsDivideBy3(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (DividedBy3(num))
        //        {
        //            total += num;
        //        }
        //    }
        //    return total;
        //}

        //public static int SumNumsDivideBy7(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (DividedBy7(num))
        //        {
        //            total += num;
        //        }
        //    }
        //    return total;
        //}

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool DividedBy3(int number)
        {
            return number % 3 == 0;
        }

        public static bool DividedBy7(int number)
        {
            return number % 7 == 0;
        }

        public static string Username(string word, string word2)
        {
            return $"{word} {word2}";
        }

        public static int Total(int num, int num2)
        {
            return num + num2;
        }

        public static void Article(string word)
        {
            Console.WriteLine(word);
        }

        public static void Test(string word)
        {
            Console.WriteLine("Void Action " + word);
        }
    }
}
