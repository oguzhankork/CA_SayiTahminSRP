using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SayiTahmin.Entities
{
    public class User
    {
        public static int[] EnterNumber()
        {
            int[] kullaniciSayi = new int[6];
            for (int i = 0; i < kullaniciSayi.Length; i++)
            {
                Console.Write(i + 1 + ". Kolon İçin Giriş Yapın (1-49) : ");
                kullaniciSayi[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            return kullaniciSayi;
        }
        public static int[] GetNumber()
        {
            int[] lotoSonuc = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < lotoSonuc.Length; i++)
            {
                int lotoGelenSayi = rnd.Next(1, 49);
                lotoSonuc[i] = lotoGelenSayi;
                for (int j = 0; j < i; j++)
                {
                    if (lotoSonuc[i] == lotoSonuc[j])
                    {
                        i--;
                        continue;
                    }
                }
            }
            return lotoSonuc;
        }
        public static void GetResult(int[] girilenNuber, int[] verilenNumber)
        {
            string dogruTahmin = "";
            for (int i = 0; i < girilenNuber.Length; i++)
            {
                for (int z = 0; z < verilenNumber.Length; z++)
                {
                    if (girilenNuber[i] == verilenNumber[z])
                    {
                        dogruTahmin += girilenNuber[i] + " ";
                    }
                }
            }
            foreach (int a in girilenNuber)
            {
                Console.WriteLine("Girilen Sayılar : " + a);
            }
            Console.WriteLine(" ");
            foreach (var b in verilenNumber)
            {
                Console.WriteLine("Loto Sonuçları : " + b);
            }
            Console.WriteLine("\n***********************\nBilinen Sayılar : " + dogruTahmin);
            Console.WriteLine("\nTekrar Denemek İçin 'Enter'a Basın...");
            Console.ReadLine();
            Console.Clear();
        }        
    }
}




