using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;

        public string name { get; set; } = "멍멍이";

        /*public string Name
        {
            get { return this.name; }
            set { this.name = value; } */
        // 간단하게 만들어버림      >>>>   public string Name { get; set;}



        public string Color
        {
            get; set;
        } = "누런";


        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if (value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
            }
        }


        //값을 사용
        /* public String GetAge() { return $"{this.age}";}

         //값을 설정
         public void SetAge(int age)
         {
             if (age < 0) { this.age = 1; }
             else if (age > 15) { this.age = 15; } 
             else { this.age = age; }
         }*/
    }
}
