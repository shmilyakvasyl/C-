using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    public class Text
    {
        public string str = "Здоровенькi були! Цей текст був написаний 25.04.2021";
        public string subject = "Розваги/Юмор";

        public uint Count()
        {
            uint count = 0;
            foreach (var el in str) if (char.IsLetter(el))
                    count++;
            return count;
        }

        public void Space()
        {
            int f = str.Split(' ').Length - 1;
            Console.WriteLine(f);
        }

        public void Change()
        {
            Console.WriteLine(str);
            Console.WriteLine(str.Replace("а", "у"));
        }

        public void Remove()
        {
            string[] text;
            text = str.Split(' ');
            //Console.WriteLine(text.Length);
            Console.Write("Index:");
            int index = int.Parse(Console.ReadLine());
            string word = text[index];
            string s = str.Replace(word, "");
            Console.WriteLine(s);
        }
    }
}