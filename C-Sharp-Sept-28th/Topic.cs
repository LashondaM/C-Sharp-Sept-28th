using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Sept_28th
{
    class Topic
    {
        private static int NextId { get; set; } = 11;

        public int Id { get; private set; } // private set means program class and no other class can change the Id
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }

        //public void SetId(int id)
        //{
        //    this.Id = id;
        //}

        public void print() {
            Console.WriteLine($"{Id} | {Name} | {Category} | {Difficulty}"); // use console.writline when print is set to void
        }

        public Topic()
        {
            this.Id = NextId;
            NextId += 20;
        }
    }
}
