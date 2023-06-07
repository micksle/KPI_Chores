using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>[] array = new List<string>[12];
            array[0] = new List<string>();
            array[1] = new List<string>();
            array[2] = new List<string>();
            array[3] = new List<string>();
            array[4] = new List<string>();
            array[5] = new List<string>();
            array[6] = new List<string>();
            array[7] = new List<string>();
            array[8] = new List<string>();
            array[9] = new List<string>();
            array[10] = new List<string>();
            array[11] = new List<string>();

            var poem =
                "У саду виросло дивовижне дерево,\n" +
                "Загадкове і прекрасне на вигляд.\n" +
                "Високі гілки, густі листя й квіти,\n" +
                "То місце, де сховаєш таємниці світ.\n" +
                "Завертай сторінки, листай словами,\n" +
                "Шукай та пізнавай закономірності.\n" +
                "У книжках та рядках приховані ключі,\n" +
                "Розгадай їх, з'єднай унікальність.\n" +
                "Сторінка 12, рядок 3, слово 'мрія',\n" +
                "Там починається перша твоя літера.\n" +
                "Далі йдеш, перевертаєш, обертаєш,\n" +
                "Створюєш шифр, що відкриє твою таємницю";

            var words = poem.Split('\n');

            for (var i = 0; i < words.Length; i++)
            {
                var chars = words[i].ToCharArray();
                var k = 0;
                foreach (var c in chars)
                {
                    Console.Write(c);
                    array[i].Add(c.ToString());
                }

                Console.WriteLine();
            }


            for (int i = 0; i < array.Length; i++)
            {
                foreach (var a in array[i])
                {
                    Console.Write(a + " ");
                }

                Console.WriteLine();
            }

            List<string>[] strings = new List<string>[12];
            strings[0] = new List<string>();
            strings[1] = new List<string>();
            strings[2] = new List<string>();
            strings[3] = new List<string>();
            strings[4] = new List<string>();
            strings[5] = new List<string>();
            strings[6] = new List<string>();
            strings[7] = new List<string>();
            strings[8] = new List<string>();
            strings[9] = new List<string>();
            strings[10] = new List<string>();
            strings[11] = new List<string>();

            for (var i = 0; i < array.Length; i++)
            {
                var d = 0;
                foreach (var a in array[i])
                {
                    var res = i + "/" + d + ",";
                    strings[i].Add(res);
                    d++;
                }
            }

            for (int i = 0; i < strings.Length; i++)
            {
                foreach (var a in strings[i])
                {
                    Console.Write(a + " ");
                }

                Console.WriteLine("\n");
            }

            var rech = "Щастям б'єш жук їх глицю в фон й ґедзь пріч";
            var chares = rech.ToCharArray();
            // Console.WriteLine(strings[0].Count);
            //add random count to quantity of all symbols in strings

            var rnm = new Random();
            var lists = new List<string>();
            for (int i = 0; i < chares.Length; i++)
            {
                var row = rnm.Next(12);
                var col = rnm.Next(30);
                lists.Add(strings[row][col]);
            }

            Console.WriteLine("kinda decrypted res");
            foreach (var VARIABLE in lists)
            {
                Console.Write(VARIABLE);
            }

            Console.WriteLine("\n\n-----------------------");
            var decrypted =
                "11/11,9/18,0/14,3/6,2/6,5/22,1/20,9/28,3/5,1/1,7/4,6/16,8/25,8/10,5/23,10/17,4/13,10/11,9/28,0/4,9/14,8/2,5/7,7/23,8/6,8/2,4/14,10/25,9/6,11/5,9/28,9/11,4/26,4/20,10/13,1/9,1/29,3/4,4/14,1/12,2/28,7/6,0/23,";

            var decrVals = decrypted.Split(',');
            
            var final = new List<string>();
            Console.WriteLine("\n\n\n decs");
            foreach (var VARIABLE in decrVals)
            {
                Console.WriteLine(VARIABLE);
            }


            Console.WriteLine("\n\n\t");
            for (int i = 0; i < lists.Count; i++)
            {
                var crypted = lists[i];
                // var tot = decrVals[i].Split('/');
                var tot = crypted.Split('/');
                if (decrVals[i].Length > 1)
                {
                    var r = tot[0];
                    var c = tot[1].TrimEnd(',');
                    Console.WriteLine(r + " + " + c);
                    final.Add(array[int.Parse(r)][int.Parse(c)]);
                }
            }

            Console.WriteLine("\n\t RESULTS ");

            foreach (var VARIABLE in final)
            {
                Console.Write(VARIABLE);
            }
        }
    }
}