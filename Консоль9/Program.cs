using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Консоль9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длинну каких слов вывести из файла?");
            int lihg = Convert.ToInt32(Console.ReadLine());
            string file = File.ReadAllText(@"C:\Users\egora\Desktop\Текст.txt");
            file = file.Replace(".", "");
            string[] person = file.Split(' ');
            for (int i = 0; i < person.Length; i++)
            {
                if(person[i].Length==lihg)
                {
                    Console.WriteLine(person[i]);
                }
            }
            //////////////////////////ЗАДАНИЕ9.2/////////////////////////////
            var SW = new StreamWriter(@"C:\Users\egora\Desktop\Файл записи.txt", true);
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Length > lihg)
                {
                    SW.WriteLine(person[i]);
                    
                }
            }
            SW.Close();
            Console.ReadKey();
        }
    }
}
