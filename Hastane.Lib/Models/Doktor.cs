using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Doktor : Kisi, IMaasAlabilir
    {
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public Branslar DbBrans { get; set; }
        public decimal Maas { get; set; }
    }
}
