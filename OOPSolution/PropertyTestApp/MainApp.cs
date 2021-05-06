using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("강아지 객체 생성");
            Dog Baekgoo = new Dog();
            Baekgoo.SetAge(5); // 5살로 set

            Console.WriteLine($"백구의 나이는 {Baekgoo.GetAge()}살"); */
            // 초창기에 사용했던 방법
            // 나이, 이름, 색깔 등등 변수가 여러개인 경우 각각 Get, Set과정이 필요함

            Console.WriteLine("강아지 객체 생성");
            Dog 강아지 = new Dog();
            강아지.Age = 25000;
            Console.WriteLine($"강아지의 나이는 {강아지.Age}살 입니다.");

            강아지.name = "백구";
            Console.WriteLine($"강아지의 이름은 {강아지.name} 입니다.");

            강아지.Color = "누런";
            Console.WriteLine($"강아지의 색깔은 {강아지.Color}색 입니다.");



            Dog StreetDog = new Dog();
            Console.WriteLine($"{StreetDog.name}은 {StreetDog.Color}색 입니다.");

            Dog dog1 = new Dog();
            dog1.name = "황구";
            dog1.Color = "노랑";
            dog1.Age = 10;

            Dog dog2 = new ()  // Dog 클래스 네임도 생략 가능 ㄷㄷ;;
            {
                name = "깜장이",
                Age = 5,
                Color = "검정"
            };  // dog2. 여러번 안찍어도 되는 방법

            //1회용 무명 형식 Property, 튜플과 비슷
            var myInstance = new{ name = "박상현", Age = "17" };
            Console.WriteLine(myInstance.name + myInstance.Age+"살");
        }
    }
}
