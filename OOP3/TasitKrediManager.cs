using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Tasit Kredisi Hesaplandi");
        }

        public void Komisyon()
        {
            throw new NotImplementedException();
        }
    }
}
