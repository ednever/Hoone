using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoone
{
    public class Hoone
    {
        public Uks uks;
        public Sein sein;
        public int Pindala { get; set; }
        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
        }
        public Uks GetUks()
        {
            return uks;
        }
        public Sein GetSein()
        {
            return sein;
        }
    }
    //public abstract void Kes_ma_olen { }
}
