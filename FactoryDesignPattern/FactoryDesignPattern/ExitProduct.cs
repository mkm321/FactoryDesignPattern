using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class ExitProduct : IProduct
    {
        public void Book(IRepository database)
        {
            Console.WriteLine("exit book");
        }

        public void Save(IRepository database)
        {
            Console.WriteLine("exit save");
        }
    }
}
