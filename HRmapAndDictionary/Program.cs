using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRmapAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfentry = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            for (int i = 0; i < noOfentry; i++)
            {
                string []entry= Console.ReadLine().Split(' ');

                phoneBook.Add(entry[0], Convert.ToInt32(entry[1]));

            }
            string input = Console.ReadLine();
            bool done=false;
            while (!done)
            {
                if (input == "")
                {
                    done = true;
                    break;
                }

                if (phoneBook.ContainsKey(input))
                {
                    var value = phoneBook.FirstOrDefault(k => k.Key == input).Value;
                    Console.WriteLine(input + "=" + value);

                }

                else { Console.WriteLine("Not found"); }
                input = Console.ReadLine();
                

            }
        }
    }
}
