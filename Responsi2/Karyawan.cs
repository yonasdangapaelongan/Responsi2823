using System;
using System.Collections.Generic;
using System.Text;

namespace Responsi2
{
    class Karyawan
    {
        public int No { get; set; }
        public int NIK { get; set; }
        public string Nama{get; set;}
        public int GajiBulanan { get; set; }

        public Karyawan (int No,int NIK, string Nama, int GajiBulanan)
        {
            this.No = No;
            this.NIK = NIK;
            this.Nama = Nama;

            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }
        public void karyawan()
        {
            Console.WriteLine("{0}  {1}  {2} \t {3}",No, NIK, Nama, GajiBulanan);
        }
        public void NaikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}  {1}  {2} \t {3}", No, NIK, Nama, GajiBulanan);

        }
    }
}
