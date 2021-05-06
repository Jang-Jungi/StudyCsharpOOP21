using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp //p.392
{
    class MyList
    {
        private int[] array;// private이라 메인에서 .으로 사용 불가

        public int this[int index] // MyList[i] ==array[i] why? array는 private이니깐
        {
            get
            {
                return array[index];
            }
            set
            {

                if(index >= array.Length) // 3보다 크면
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length} ");
                }  // ArrayList 같은 식을 만든 방법....

                array[index] = value;

            }
        }
        public int Length  // array의 length는 접근 불가 새로 만들어줌
        {
            get { return array.Length; } // 3이 나올거임
        }


        public MyList()
        {
            array = new int[3]; // 0,1,2
        }
    }
}
