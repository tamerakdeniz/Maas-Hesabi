using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maaş_Hesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi;
            string soyadi;
            int brüt;
            int kesinti;
            int mesai;
            int net;
            string para;

            Console.WriteLine("Adini giriniz");
            adi = Console.ReadLine();
            Console.WriteLine("Soyadini giriniz");
            soyadi = Console.ReadLine();
            Console.WriteLine("Brüt maasi giriniz");
            para = Console.ReadLine();
            brüt = Convert.ToInt16(para);
            Console.WriteLine("Kesintiyi giriniz");
            para = Console.ReadLine();
            kesinti = Convert.ToInt16(para);
            Console.WriteLine("Mesai gelirini giriniz");
            para= Console.ReadLine();
            mesai = Convert.ToInt16(para);

            net = (brüt + mesai) - kesinti;
            Console.WriteLine("Adi="+adi);
            Console.WriteLine("Soyadi="+soyadi);
            Console.WriteLine("Net maasi="+net);
            Console.ReadLine();
        }
    }
}
