using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public interface IAtama<T1, T2> where T1 : Kisi where T2 : Kisi
    {
        void AtamaYap(T1 nereye, T2 neyi);
        void AtamaGeriAl(T1 nereden, T2 neyi);
    }
}
