using System;

namespace Responsi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama  = Yonas Danga Paelongan");
            Console.WriteLine("Nim   = 19.11.2823 \n\n\n");

            Karyawan karyawan = new Karyawan(1, 180302123, "Paijo", 3000000);
            Karyawan karyawan1 = new Karyawan(2, 190302124, "Jono", 2000000);

            Console.WriteLine("No \t NIK/NAMA \t\t Gaji Bulanan");
            Console.WriteLine("-----------------------------------------------\n");
            karyawan.karyawan();
            karyawan1.karyawan();

            Console.WriteLine("\n\n Asyiiiiik Kenaikan Gaji 10%!!\n");

            Console.WriteLine("No \t NIK/Nama \t\t Gaji Bulanan");
            Console.WriteLine("-----------------------------------------------\n");
            karyawan.NaikGaji();
            karyawan1.NaikGaji();

            Console.ReadKey();
        }
    }
}
