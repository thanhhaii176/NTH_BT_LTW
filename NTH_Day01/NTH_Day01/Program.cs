using System;


namespace NTH_Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("=====CHON BAI=====");
                Console.WriteLine("1.\tBai 1: Quan ly sinh vien.");
                Console.WriteLine("2.\tBai 2: Quan ly nhan vien.");
                Console.WriteLine("0.\tThoat.");
                Console.WriteLine("==========================");

                Console.Write("Moi ban chon: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Bai1.chay();
                        break;
                    case 2:
                        Bai2.chay();
                        break;
                    case 0:
                        Console.WriteLine("Da thoat chuong trinh!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }while(choice != 0);
        }
        
    }
}
