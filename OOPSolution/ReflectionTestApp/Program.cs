using System;
using System.Reflection;

namespace ReflectionTestApp
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void PrintProfile() { Console.WriteLine($"{Age},{Name}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType(); // int32
            Console.WriteLine("Field 타입 리스트: ");

            FieldInfo[] fields = type.GetFields();
            foreach (var item in fields)
            {
                Console.WriteLine($"{item.FieldType.Name}, Name : {item.Name}");
            }
            Console.WriteLine("Property 타입 리스트: ");

            PropertyInfo[] properties = type.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine($"{item.PropertyType.Name}, Name : {item.Name}");
            }

            MethodInfo[] methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine($"{item.ReturnType.Name}, Name : {item.Name}");
            }
        }
    }
}
