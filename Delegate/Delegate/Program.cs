using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //public delegate bool Check(int n);
        public delegate bool Check<T>(T n);
        //public delegate void Write(string s);
        public delegate void Write<T>(T obj);
        public delegate U Test<in T,in M,out U>(T obj,M obj2);
        static void Main(string[] args)
        {
            #region Delegate
            int[] arr = { 5, 10, 15, 20, 25 };
            //Console.WriteLine(Sum(arr,IsOdd));
            //Console.WriteLine(Sum(arr,IsEven));
            //Console.WriteLine(Sum(arr, IsElder));
            #region Anonimous function,lambda expression
            //Write write = new Write(Info);
            //Write write = Info;
            //write += GetUpper;
            //write += GetLower;
            //write += GetFirstSimbol;
            //write -= GetLower;
            //write += delegate (string str) 
            //{
            //    Console.WriteLine("Anonimous function: "+str);
            //};

            //write += str => Console.WriteLine("Anonimous function: " + str);

            //write += delegate (string str)
            //  {
            //      Console.WriteLine("Anonimous function-2: "+str);
            //  };
            //write += str =>
            //{
            //    string result = str.Trim();
            //    Console.WriteLine(result);
            //};
            //write -= delegate (string str)
            //{
            //    Console.WriteLine("Anonimous function-2: " + str);
            //};
            //write("Mustafa");

            //Check check = IsOdd;
            //check += IsEven;
            //check += n => n > 15;
            //Console.WriteLine(check(10));

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(10);
            //list.Add(100);
            //int res=list.Find(n=>n==100);
            //Console.WriteLine(res);
            //Write<string> wStr = new Write<string>(Info);
            //Write<int> wInt = n => Console.WriteLine(n);
            //wStr("Mustafa");
            //wInt(10);
            #endregion

            #region Predicate,Action,Func
            //Predicate<int> predicate = IsOdd;
            //predicate += n => n / 3 == 0;
            //Console.WriteLine(predicate(11));

            //Action<string> action = Info;
            //action += GetUpper;
            //action += GetLower;
            //action -= GetLower;
            //action += s => Console.WriteLine(s);
            //action("Mustafa");

            //Action<string, string> action1 = (s1, s2) => Console.WriteLine(s1+" "+s2);
            //action1("Mustafa", "Ehmedov");

            //Func<int> func = delegate ()
            //{
            //    return 5;
            //};
            //Console.WriteLine(func());
            //Func<string,string,bool> func1 = (s1, s2)=>
            //{
            //    return s1.Length > s2.Length;
            //};
            //Console.WriteLine(func1("Mustafa","Ehmedov"));
            #endregion
            #endregion

            #region Event
            Student s1 = new Student("Mustafa", 99);
            Student s2 = new Student("Melek", 64);
            s1.Notify += point =>
            {
                if (point >= 65)
                {
                    Console.WriteLine("Eee gel diplomuvu gotur");
                    return;
                }
                Console.WriteLine("Heyif");
            };

            s2.Notify += point =>
            {
                if (point >= 65)
                {
                    Console.WriteLine("Tebrikleeeeeeer.Bu qizdan yoxdu daaa...Code Academy belesini gormuyub");
                    return;
                }
                Console.WriteLine("Biz Meleye layiq deyildik");
            };

            s1.SendMessage();
            s2.SendMessage();
            #endregion
        }

        #region Anonimous function,lambda expression
        public static void Info(string str)
        {
            Console.WriteLine("Length: "+str.Length);
        }

        public static void GetUpper(string s)
        {
            Console.WriteLine("Upper: "+s.ToUpper());
        }

        public static void GetLower(string s)
        {
            Console.WriteLine("Lower: " + s.ToLower());
        }

        public static void GetFirstSimbol(string s)
        {
            Console.WriteLine("First Simbol: " + s[0]);
        }
        #endregion

        #region Delegate
        public static int Sum(int[] arr, Predicate<int> func)
        {
            int result = 0;
            foreach (int num in arr)
            {
                if (func(num))
                    result += num;
            }

            return result;
        }

        public static bool IsOdd(int n)
        {
            //Console.WriteLine("IsOdd");
            return n % 2 != 0;
        }

        public static bool IsEven(int n)
        {
            //Console.WriteLine("IsEven");
            return n % 2 == 0;
        }

        public static bool IsElder(int n)
        {
            return n > 10;
        }
        #endregion

        #region Event
        class Student
        {
            public string Name { get; set; }
            public int Point { get; set; }
            public event Action<int> Notify;

            public Student(string name,int point)
            {
                Name = name;
                Point = point;
            }

            public void SendMessage()
            {
                Notify(Point);
                //if (Point >= 65)
                //{
                //    Console.WriteLine("Tebrikler");
                //    return;
                //}
                //Console.WriteLine("Nc Nc Nc");
            }
        }
        #endregion
    }
}
