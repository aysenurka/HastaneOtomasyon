using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.Lib.Models;

namespace Hastane.Lib.Data
{
    public class MockData
    {
        public Context Context { get; set; }

        public MockData()
        {
            Context = new Context();

            for (int i = 0; i < 10; i++)
            {
                Context.Doktorlar.Add(new Doktor()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    Tckn = FakeData.TextData.GetNumeric(11),
                    Telefon = "05" + FakeData.TextData.GetNumeric(9),
                    Email = new Doktor().Ad + "." + new Doktor().Soyad + "@email.com"
                });
            }

            for (int i = 0; i < 20; i++)
            {
                Context.Hemsireler.Add(new Hemsire()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    Tckn = FakeData.TextData.GetNumeric(11),
                    Telefon = "05"+FakeData.TextData.GetNumeric(9),
                    Email = new Hemsire().Ad+"."+new Hemsire().Soyad+"@email.com"
                });
            }

            for (int i = 0; i < 50; i++)
            {
                //Hasta hasta=new Hasta();
                Context.Hastalar.Add(new Hasta()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    Tckn = FakeData.TextData.GetNumeric(11),
                    Telefon = "05"+FakeData.TextData.GetNumeric(9),
                    Email = new Hasta().Ad+"."+new Hasta().Soyad+"@email.com"
                });
            }
        }
    }
}
