using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behruz27.Xafsizlik
{
    public class Malumot
    {
        public string Isim { get; set; }
        public string Familiya { get; set; }
        public int Yosh { get; set; }
        public string PasportID { get; set; }
        public string password1 { get; set; }
        public void MalumoT()
        {
            Console.Write("Enter user first name = "); Isim = Console.ReadLine();
            Console.Write("Enter user last name = "); Familiya = Console.ReadLine();
            Console.Write("Enter user age = "); Yosh = int.Parse(Console.ReadLine());
            Console.Write("Enter user pasport id = "); PasportID = Console.ReadLine();
        }


        public void YiliniAniqlash()
        {
            Console.WriteLine(DateTime.Today.Year - Yosh);
        }


        public void MalumotniOlish()
        {
            bool count = false;
            do
            {
                if (!count)
                {
                    Console.Write("Enter user Passport ID or Certificate: ");
                    password1 = Console.ReadLine();
                }
                else if (count)
                {

                    Console.Write("======== Error! Please enter your Passport ID or Certificate ========= ");
                    Console.Write("Enter user Passport ID or Certificate: ");
                    password1 = Console.ReadLine();
                }
                count = true;


            } while (password1 != PasportID);
            Console.WriteLine($"User first name: {Isim}\n" +
                              $"User last name: {Familiya}\n" +
                              $"User age: {Yosh}\n" +
                              $"User passport id: {PasportID}");
        }


        public void YoshOraligi()
        {
            string ageRangeOfTheUser = (Yosh < 18) ? "Young age" :
                           (Yosh >= 18 && Yosh <= 30) ? "Middle ages" :
                           "Older age";
            Console.WriteLine(ageRangeOfTheUser);
        }
    }
}
