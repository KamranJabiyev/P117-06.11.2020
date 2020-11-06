using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Area area1 = new Area(20,10);
            //area1.A = 200;
            //Console.WriteLine(area1.GetArea());
            //Area area;
            //area.Test = 10;
            //Console.WriteLine(area.Test);
            #endregion

            #region GenericType
            //MyStrList strList = new MyStrList();
            //strList.AddMember("Mustafa");
            //strList.AddMember("Mustafa1");
            //strList.AddMember("Mustafa2");
            //Console.WriteLine(strList.GetMember(0));

            //MyIntList intList = new MyIntList();
            //intList.AddMember(1);

            //MyList<string> strList = new MyList<string>();
            //strList.AddMember("Mustafa");
            //strList.AddMember("Mustafa1");
            //string str = strList.GetMember(0);

            //MyList<int> intList = new MyList<int>();
            //intList.AddMember(1);

            //MyList<Person> pList = new MyList<Person>();
            //pList.AddMember(new Person());
            //MyList<ICan> myList = new MyList<ICan>();

            //Write<int>(10);
            //Write<string>("Mustafa");
            //Test<string, string>("Nahide", "Memishova");
            //MyList<Student, Person> myList = new MyList<Student, Person>();
            //MyList<Person, ICan> myList1 = new MyList<Person, ICan>();
            //MyList<string, object> myList2 = new MyList<string, object>();
            #endregion

            #region Collection
            #region ArrayList
            //ArrayList list = new ArrayList();
            //list.Add(5);
            //list.Add(true);
            //list.Add('a');
            //list[5] = 10;
            //list.Clear();
            //Console.WriteLine(list.Contains(false));
            //list.Remove(true);
            //Console.WriteLine(list.Count);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            //List<string> mylist = new List<string>();
            //mylist.Add("Mustafa");
            //mylist.Add("Mustafa1");
            //mylist.Add("Mustafa2");
            ////mylist.RemoveAt(2);
            //mylist[0] = "Elgun1";
            //foreach (string item in mylist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran", "+994512373434");
            //phones.Add("Elgun", "+994558835613");

            //phones["Mehemmed"] = "+994775705780";
            //foreach (var item in phones)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Console.WriteLine(phones["Kamran"]);

            #endregion

            #region Queue - FIFO
            //Queue<string> q = new Queue<string>();
            //q.Enqueue("Melek");
            //q.Enqueue("Nahide");
            //q.Enqueue("Turkan");
            //string deq = q.Dequeue();
            //Console.WriteLine(deq);
            //Console.WriteLine("Siradakilar:");
            //foreach (string item in q)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack - LIFO
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Turkan");
            //stack.Push("Nahide");
            //stack.Push("Melek");

            ////Console.WriteLine(stack.Peek());
            //stack.Pop();

            //Console.WriteLine("Siradakilar:");
            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
        #region GenericType
        public static void Write<GT>(GT n)
        {
            Console.WriteLine(n);
        }

        public static void Test<T,U>(in T n1,U n2)
        {
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }

        #endregion
    }

    #region GenericType
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    //class MyList<T> where T:class,ICan,new()
    class MyList<T,U> where T: U

    {
        private T[] myArr;
        public MyList()
        {
            myArr = new T[0];
        }

        public void AddMember(T member)
        {
            Array.Resize(ref myArr, myArr.Length + 1);
            myArr[myArr.Length - 1] = member;
        }

        public T GetMember(int index)
        {
            return myArr[index];
        }
    }


    class Person:ICan
    {

    }

    class Student : Person
    {

    }
    #endregion

    #region Struct - value 
    interface ICan
    {

    }
    struct Area:ICan
    {
        public double A { get; set; }
        public double B { get; set; }
        public int Test;
        public Area(double a,double b)
        {
            A = a;
            B = b;
            Test = 10;
        }

        public double GetArea()
        {
            return A * B;
        }
    }

    #endregion
}
