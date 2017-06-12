using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int menu;
            int submenu = 4;
            Console.WriteLine("Buy a cat!");
            Console.WriteLine("Click 1 for start!");
            menu = Convert.ToInt16(Console.ReadLine());
            while (true)
            {
                switch (menu)
                {
                    case 1:

                        Console.WriteLine("Set age");
                        Console.WriteLine("Can only be set once");
                        age = Convert.ToInt32(Console.ReadLine());
                        if (age <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Age can not be 0");
                        }
                        else
                        {
                            var cat = new Cat(age, 5);
                            while (menu != 0)
                            {
                                Console.Clear();
                                if (string.IsNullOrEmpty(cat.Name) == false)
                                    Console.WriteLine(string.Format("Name of cat " + cat.Name));
                                Console.WriteLine(string.Format("Сat's age is " + cat.Age + " months"));

                                Console.WriteLine("................................................................");
                                Console.WriteLine("1 - set name");
                                Console.WriteLine("2 - color of cat");
                                Console.WriteLine("3 - punish");
                                Console.WriteLine("4 - feed");
                                menu = Convert.ToInt32(Console.ReadLine());
                                switch (menu)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Set name");
                                        Console.WriteLine("Can only be set once");
                                        if (string.IsNullOrEmpty(cat.Name) == true)
                                            cat.Name = Console.ReadLine();
                                        else
                                        {
                                            while (submenu != 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Name is already set");
                                                Console.WriteLine("0 to exit");
                                                submenu = Convert.ToInt32(Console.ReadLine());
                                            }
                                            submenu = 4;
                                        }
                                        break;
                                    case 2:
                                        while (submenu != 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(cat.Color);
                                            Console.WriteLine("0 to exit");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                        }
                                        submenu = 4;
                                        break;

                                    case 3:
                                        while (submenu != 0)
                                        {

                                            Console.Clear();
                                            Console.WriteLine(cat.Punish());
                                            Console.WriteLine("0 to exit");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                            break;

                                        }
                                        submenu = 4;
                                        break;
                                    case 4:
                                        while (submenu != 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(cat.Feed());
                                            Console.WriteLine("0 to exit");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                        }
                                        submenu = 4;
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
