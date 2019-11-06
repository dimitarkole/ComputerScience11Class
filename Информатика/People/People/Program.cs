
using System;
using System.Collections.Generic;
using System.Linq;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine().Split(' ').ToList();
            MyList names = new MyList(inputNames);
            string cmd;
            do
            {
                cmd = Console.ReadLine();
                if (cmd == "End") break;
                string[] param = cmd.Split(' ').ToArray();
                switch (param[0])
                {
                    case "Add": names.Add(param[1]); break;
                    case "Delete": names.Delete(int.Parse(param[1])); break;
                    case "Search": names.Search(param[1]); break;

                    default:
                        break;
                }

            } while (true);
        }

    }
}
