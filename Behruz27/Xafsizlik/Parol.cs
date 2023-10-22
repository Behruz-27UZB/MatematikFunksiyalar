using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behruz27.Xafsizlik
{
    public class Parol
    {
        public void Xafsizlik()
        {
            string password = "";
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            } while (password != "$alom123");
        }
    }
}
