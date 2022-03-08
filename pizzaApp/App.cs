using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaApp
{
    internal class App
    {
        public void Run()
        {
            var data = File.ReadAllLines("./pizza_data.txt");
            var array = data.ToArray();

            List<int> listNumbers = new List<int>();
            List<string> listPizza = new List<string>();
            int number;

            bool procced = true;


            while (procced)
            {
                Console.WriteLine("Kolik pizz chces?");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kolik ingredienci na pizzach chces? (max 20)");
                int input2 = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    procced = false;
                }
                else
                {
                    for(int i = 0; i <= input; i++)
                    {
                        for(int j = 0; j <= input2; j++)
                        {
                            number = NextNum();

                            if (listNumbers.Contains(number))
                            {
                                while (listNumbers.Contains(number))
                                {
                                    number = NextNum();
                                }
                                listNumbers.Add(number);
                            }
                            else
                            {
                                listNumbers.Add(number);
                            }
                        }
                        Console.WriteLine((i + 1) + " pizza se sklada z ");
                        for(int k = 0; k < listNumbers.Count; k++)
                        {
                            Console.WriteLine(array[listNumbers[k]]);
                        }
                        listNumbers.Clear();
                    }
                }
            }
        }
        public int NextNum()
        {
            Random r = new Random();
            int number;
            number = r.Next(0, 19);
            return number;
        }
    }
}