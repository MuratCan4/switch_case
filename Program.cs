using System;

namespace switch_case
{
    class Program
    {
        static void Main (string[] args)
        {
            int month = DateTime.Now.Month;
            Console.WriteLine(month);
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayindasin");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayindasin");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayindasin");
                    break;
                default:
                Console.WriteLine("Yanliş Veri Girildi");
                break;
            }
              switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                    Console.WriteLine("Kiş Mevsimindesiniz");
                    break;

                    default:
                    break;
                }
        }
    }
}