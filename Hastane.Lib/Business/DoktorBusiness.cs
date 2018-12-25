using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.Lib.Models;

namespace Hastane.Lib.Business
{
    public class DoktorBusiness : IAtama<Doktor, Hemsire>
    {
        public void AtamaYap(Doktor nereye, Hemsire neyi)
        {
            if (neyi.atandiMi)
                throw new Exception("Hemsire baska doktora atanmistir");
            if (nereye.DbBrans != neyi.HBrans)
                throw new Exception("Branslar ayni olmalidir");

            neyi.atandiMi = true;
            nereye.Hemsireler.Add(neyi);
        }

        public void AtamaGeriAl(Doktor nereden, Hemsire neyi)
        {
            if (!neyi.atandiMi)
                throw new Exception("Hemsire henuz atanmamistir");

            neyi.atandiMi = false;
            nereden.Hemsireler.Remove(neyi);
        }
    }
}
