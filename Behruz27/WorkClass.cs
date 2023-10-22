using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behruz27
{
    public class WorkClass
    {
       public void Qidir(int[] massiv, int son)
        {
            if (Array.Exists(massiv, p => p == son))
            {
                Console.WriteLine("bor");
            }
            else
            {
                Console.WriteLine("Yuq");
            }
        }
    }
}
