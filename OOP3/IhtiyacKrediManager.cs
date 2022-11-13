using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac Kredisi Hesaplandı");
        }

        public void Komisyon()
        {
            throw new NotImplementedException();
        }
    }
}
