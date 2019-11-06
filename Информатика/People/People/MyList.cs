using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace People
{
    class MyList
    {
        private List<string> names;

        public MyList(List<string> names)
        {
            Names = names;
        }

        public List<string> Names
        {
            get { return names; }
            set { names = value; }
        }

        public void Add(string name)
        {
            Names.Add(name);
            this.Print();

        }

        public void Delete(int index)
        {
            Names.RemoveAt(index);
            this.Print();

        }

        public void Search(string name)
        {
            Console.WriteLine(Names.Contains(name));
            this.Print();
        }

        public void Print()
        {
            Names.Sort();
            Console.WriteLine(string.Join(" ", this.Names));
        }

    }
}
