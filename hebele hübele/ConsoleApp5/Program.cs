using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
    {
        internal class RandomSayi
        {
            public int rendemsayiüretci()
            {
                return new Random().Next(1, 11);
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomSayi randomSayi = new RandomSayi();
            int rendem = randomSayi.rendemsayiüretci();
            Console.WriteLine("1 ile 10 arasında bir sayı seçildi. Tahmininizi girin.");
            //  int insn;
            //insn=Convert.ToInt32(Console.ReadLine());
            int insn;
            bool dogruTahmin = false;

            while (!dogruTahmin)
            {
                insn = Convert.ToInt32(Console.ReadLine());

                if (insn == rendem)
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    dogruTahmin = true;
                }
                else
                {
                    Console.WriteLine("Tekrar deneyiniz. Yanlış tahmin.");
                }
               
            }
           
        }
    }  }


   

