using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var iphone = new Iphone("123456789");
            iphone.Ligar();
            iphone.InstalarAplicativo("WhatsApp");
            

            var nokia = new Nokia("987654321");
            nokia.Ligar();
            nokia.InstalarAplicativo("Facebook");
        }
    }
}