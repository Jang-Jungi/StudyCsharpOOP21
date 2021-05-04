using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat :Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat() {/*nothing*/ } // 알아서 만들어줌
        public Cat ( string name, string color, int age)
        { // initalization 초기화
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }

        public Cat(string name, string color)
        { // initalization 초기화
            this.Name = name;
            this.Color = color;
        }

        public Cat(string color, int age)
        { // initalization 초기화 자료형에 의해서 컴퓨터는 판단을 한다.
            this.Color = color;
            this.Age = age;
        }

        // public void Meow() { Console.WriteLine("{0} {1},야옹!", this.Color, this.Name); }  // 배열처럼 0->첫번째 this 1->두번째 this

        public void Meow() { Console.WriteLine($"{this.Color} {this.Name},야옹!"); } // 4.0부터 이방법을 주로 사용

        public override void Sleep() // virtual을 써주어야 자식 클래스에서 정의가 된다.
        {
            base.Sleep();
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) ZZ잡니다!");
        }
    }  

}
