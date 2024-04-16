using CA_SayiTahmin.Entities;

namespace CA_SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Message.GetMainMenuMessage();
                int[] girilenSayi = User.EnterNumber();
                int[] verilenSayi = User.GetNumber();
                Message.GetResultMessage();
                User.GetResult(girilenSayi, verilenSayi);
            }
        }
    }
}
