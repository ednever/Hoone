using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoone
{
    public class EraMaja : Hoone
    {
        public EraMaja(int pindala = 50) : base(pindala)
        {
        }
        public string Suurus
        {
            get
            {
                var suurus = "";
                if (Pindala <= 25)
                {
                    suurus = "vaike maja";
                }
                else if (Pindala <= 50)
                {
                    suurus = "keskmine maja";
                }
                else if (Pindala <= 100)
                {
                    suurus = "suur maja";
                }
                else
                {
                    suurus = "liiga suur maja";
                }
                return suurus;
            }
        }
        public void NaitaINFO()
        {
            Console.WriteLine("Minu maja suurus on {0}", Suurus);
        }
    }
}
