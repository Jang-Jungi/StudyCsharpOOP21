using System;
using System.Collections.Generic;
using System.Linq;
namespace LinQTestApp
{
    class Program
    {
        public string Name { get;set; }
        public int Height { get;set; }

        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() {Name="정우성",Height=186},
                new Profile() { Name = "전지현", Height = 186 },
                new Profile() { Name = "김태희", Height = 173 },
                new Profile() { Name = "고현정", Height = 171 },
                new Profile() { Name = "이문세", Height = 164 },
                new Profile() { Name = "하하", Height = 168 },
        };
            var arrProfile2 = from item in arrProfile
                              orderby item.Height descending
                              select new { Name = item.Name, inch = item.Height * 0.393 };
            Console.WriteLine("Inch 타입으로 배열");

            foreach (var item in arrProfile2)
            {
                Console.WriteLine($"{item.Name}, {item.inch} inch");
            }
            Console.WriteLine();

            //
            var arrProfile1 = from item in arrProfile
                              orderby item.Height
                              select item;
            Console.WriteLine("전체 프로필 리스트 오름차순 배열");

            foreach (var item in arrProfile1)
            {
                Console.WriteLine($"{item.Name}, {item.Height}");
            }

            Console.WriteLine("\n전체 프로필 리스트");
            foreach (var item in arrProfile)
            {
                Console.WriteLine($"{item.Name}, {item.Height}");
            }
            
            Console.WriteLine("\n172 이하 프로필 리스트(오름차순)");

            var newProfiles = from item in arrProfile // arrProfile에서 
                              where item.Height < 172 // 172 이하만 골라서
                              orderby item.Height // 정렬 (내림차순-> descending 추가)
                              select item; // 추출
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm");
            }
            Console.WriteLine();



            //
            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i]= i+1;
            }
            var result = from item in numbers
                         where (item % 10 == 3 || item % 10 == 6|| item % 10 == 9||
                                item / 10 == 3 || item / 10 == 6|| item / 10 == 9)
                         select item ;

            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            //
            int[] arr = { 2, 3, 4, 5, 51, 53 };
            var result1 = from item in arr
                         orderby item descending
                         select item;

            foreach (var item in result1)
            {
                Console.Write($"{item}\t");
            }

            //15.3
            Console.WriteLine("\n");

            InstClass[] arrClass =
                {
                new InstClass() {Name="연두반", Scores= new int[]{99,80,70,24} },
                new InstClass() {Name="분홍반", Scores= new int[]{60,45,87,72} },
                new InstClass() {Name="파랑반", Scores= new int[]{92,30,85,94} },
                new InstClass() {Name="노랑반", Scores= new int[]{90,88,0,17} }
                 };
            var rstClass = from item in arrClass
                           from score in item.Scores
                           where score < 69
                           orderby score ascending
                           select new { item.Name, Lowest = score };
            foreach (var item in rstClass)
            {
                Console.WriteLine($"{item.Name}, {item.Lowest}");
            }
            Console.WriteLine();

            //groupby
            var listProfile = from item in arrProfile
                              orderby item.Height descending
                              group item by item.Height < 172 into g 
                              select new { GroupKey = g.Key, Profiles = g };
            foreach (var item in listProfile)
            {
                Console.WriteLine($"172 미만  : {item.GroupKey}");
                foreach (var item1 in item.Profiles)
                {
                    Console.WriteLine($">>>  : {item1.Name}, {item1.Height}");
                }
            Console.WriteLine();
            }

            // Lambda식으로 표현하는 방법
            var profiles2 = arrProfile.Where(p => p.Height < 172)
                .OrderByDescending(p => p.Height)
                .Select(item => new { Name = item.Name, Inch = item.Height * 0.393 });
            foreach (var item2 in profiles2)
            {
                Console.WriteLine($">>>  : {item2.Name}, {item2.Inch}");
            }
            Console.WriteLine();
        }
    }
}
