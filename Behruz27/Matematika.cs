using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behruz27
{
    public static class Matematika
    {
        public static void Modul(int a)
        {
            if(a > 0)
            {
                Console.WriteLine(a);
            }
            else if(a <= 0)
            {
                Console.WriteLine(a * (-1));
            }
        }

        public static void DarajaKub(int a)
        {
            Console.WriteLine(a * a * a);
        }

        public static void DarajaKvadrat(int a)
        {
            Console.WriteLine(a * a);
        }

        public static void KichikSon(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(b);
            }
            else if(a == b)
            {
                Console.WriteLine("Bu sonlar teng");
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        public static void KattaSon(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a == b)
            {
                Console.WriteLine("Bu sonlar teng");
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        public static void KvadratIldiz(int a)
        {
            for(int i = a / 2; i < a; i--)
            {
                if(a / i == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void NDaraja(int a, int n)
        {
            int c = 1;
            for(int i = 1;i <= n; i++)
            {
                c *= a;
            }
            Console.WriteLine(c);
        }
        public static void IktaSonUstidaAmallar(int BirinchiSon,char Ishora, int IkkinchiSon)
        {
           if(Ishora == '+')
           {
                Console.WriteLine(BirinchiSon  + " " + Ishora + " " +
                    IkkinchiSon + " = " + (BirinchiSon + IkkinchiSon) );
           }
           else if (Ishora == '-')
           {
                Console.WriteLine(BirinchiSon + " " + Ishora + " " +
                    IkkinchiSon + " = " + (BirinchiSon - IkkinchiSon));
           }
           else if (Ishora == '*')
           {
                Console.WriteLine(BirinchiSon + " " + Ishora + " " +
                    IkkinchiSon + " = " + (BirinchiSon * IkkinchiSon));
           }
           else if (Ishora == '/')
           {
                Console.WriteLine(BirinchiSon + " " + Ishora + " " +
                    IkkinchiSon + " = " + (BirinchiSon / IkkinchiSon));
           }
        }
    }

    
}
