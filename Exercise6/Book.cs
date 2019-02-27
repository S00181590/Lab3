using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Book
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal price { get; set; }

        public override string ToString()
        {
            return string.Format($"Book: {Name}");
        }
    }
}
