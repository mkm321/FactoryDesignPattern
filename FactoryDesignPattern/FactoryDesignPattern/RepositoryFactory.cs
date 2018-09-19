using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class RepositoryFactory
    {
        
        public static IRepository GetRepository(string operation)
        {
            if (operation.Equals("SQL"))
            {
                return new SQLDatabase();
            }
            else
            {
                return new FileDatabase();
            }
        }
    }
}
