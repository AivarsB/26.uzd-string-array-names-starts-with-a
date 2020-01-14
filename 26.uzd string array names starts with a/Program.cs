using System;

namespace _26.uzd_string_array_names_starts_with_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Janis", "Peteris", "Juris", "Gusts", "Aivars", "Jolanta" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Names starts with J:");

            foreach (var name in names)
            {
                string x = "J";

                if (name.Substring(0, 1) == x)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
// Izveidot string masīvu ar cilvēku vārdiem (Vēlams ne mazāk kā 3).
// 1. Izdrukāt visus vārdus.
// 2. Izdrukāt tikai tos vārdus, kuri sākās ar "J".
// Izmantojam Substring metodi.