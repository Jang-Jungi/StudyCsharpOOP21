using System;

namespace ClassTestApp
{
    class MainApp : Animal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat();
            //kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat Nero = new Cat  // 이 방법을 가장 많이 사용한다.
            {
                Name = "네로",
                Age = 12,
                Color = "검은색",
            };
            Nero.Meow();  


            Cat Mimi = new Cat("미미","노랑",3);
            Mimi.Meow();

            Cat coco = new Cat("코코", "얼룩이");  // 새로운 생성자
            coco.Age = 2;
            coco.Meow();
            
            
            Cat noname = new Cat("야옹이","은색", 3);  // 새로운 생성자
            //noname.Name = "야옹이";
            noname.Meow();
            noname.Sleep();

            var list = (First :"Cat", Second: "Dog", Third: "Pig",55);  // 튜플!!
            Console.WriteLine($"튜플 첫번째 : {list.Item1}");
            Console.WriteLine($"튜플 두번째 : {list.Item2}");
            Console.WriteLine($"튜플 세번째 : {list.Item3}");
            Console.WriteLine($"튜플 네번째 : {list.Item4}");
        }
    }
}
