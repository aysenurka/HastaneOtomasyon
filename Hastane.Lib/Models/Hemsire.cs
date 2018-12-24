using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Hemsire : Kisi, IMaasAlabilir
    {
        public Branslar HBrans { get; set; }
        public decimal Maas { get; set; }
    }
}
