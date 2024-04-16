using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SayiTahmin.Entities
{
    public class Message
    {
        public static void GetMainMenuMessage()
        {
            Console.WriteLine("SAYISAL LOTO OYUNU \n \n Giriş Yapmak İçin 'Enter'a Basın");
            Console.ReadLine();
            Console.Clear();
        }
        public static void GetResultMessage()
        {
            Console.WriteLine("Sonucu Görmek İçin 'Enter'a Basın");
            Console.ReadLine();
        }
    }
}
