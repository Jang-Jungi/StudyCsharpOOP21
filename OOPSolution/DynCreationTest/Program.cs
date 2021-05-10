using System;
using System.Reflection;

namespace DynCreationTest
{
    class Profile
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void Print() { Console.WriteLine($"{Name} : {PhoneNumber}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile1 = new();
            profile1.Name = "박찬호";
            profile1.PhoneNumber = "010-2424-2424";
            profile1.Print();

            //리플렉션 객체생성
            Type TYPE = typeof(Profile);
            Object profile2 = Activator.CreateInstance(TYPE);
            PropertyInfo name = TYPE.GetProperty("Name");
            PropertyInfo phonenumber = TYPE.GetProperty("PhoneNumber");
            name.SetValue(profile2, "류현진", null);
            phonenumber.SetValue(profile2, "010-1111-1111", null);

            MethodInfo print = TYPE.GetMethod("Print");
            print.Invoke(profile2, null);
            //엄청 복잡해서 잘 사용하지 않음
        }
    }
}
