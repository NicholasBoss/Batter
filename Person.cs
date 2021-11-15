using System;
using System.Collections.Generic;

namespace cse210_batter_csharp
{
    class Person
    {
        public string fname;
        public string lname;
        public List<string> names = new List<string>();

        Person()
        {
            person1();
            person2();
            person3();
            foreach (string person in names)
            {
                Console.WriteLine(person);
            }
        }
        


        public string person1()
        {
            fname = "George";
            lname = "monkey";
            string p1 = fname + lname;
            names.Add(p1);
            return p1;
        }

        public string person2()
        {
            fname = "Kali";
            lname = "money";
            string p2 = fname + lname;
            names.Add(p2);
            return p2;
        }

        public string person3()
        {
            fname = "Bard";
            lname = "merry";
            string p3 = fname + lname;
            names.Add(p3);
            return p3;
        }

    }
}