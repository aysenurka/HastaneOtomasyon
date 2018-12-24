using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public abstract class Kisi
    {
        public string _ad, _soyad, _tckn, _email, _telefon;

        // auto-prop init kullanıldığından bu kısma ihtiyaç duyulmamaktadır
        //public Guid _id;
        //public Guid Id
        //{
        //    get => this._id;
        //    set => Guid.NewGuid();
        //}

        public Guid Id { get; set; } = Guid.NewGuid();

        public string Ad
        {
            get => this._ad;
            set
            {
                Validation(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get => this._soyad;
            set
            {
                Validation(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Tckn
        {
            get => this._tckn;
            set
            {
                Validation(value, "TCKN");
                this._tckn = value;
            }
        }

        public string Telefon
        {
            get => this._telefon;
            set
            {
                Validation(value, "Telefon");
                this._telefon = value;
            }
        }

        public string Email
        {
            get => this._email;
            set
            {
                Validation(value, "Email");
                this._email = value;
            }
        }

        //tüm validationlar tek bir methodda toplanmıştır
        //private void TcknValidation(string value, string propertyName)
        //{
        //    if (value.Length != 11)
        //        throw new Exception($"{propertyName}, 11 haneli olmalidir");

        //    foreach (char sayi in value)
        //        if (!char.IsDigit(sayi))
        //            throw new Exception($"{propertyName} girisi sadece sayi ile yapilmalidir");
        //}
        //private void PhoneValidation(string value, string propertyName)
        //{
        //    if (!value.StartsWith("0"))
        //        throw new Exception($"{propertyName}, 0 ile baslamali");

        //    if (value.Length != 11)
        //        throw new Exception($"{propertyName}, 11 haneli olmalidir");

        //    foreach (char sayi in value)
        //        if (!char.IsDigit(sayi))
        //            throw new Exception($"{propertyName} girisi sadece sayi ile yapilmalidir");
        //}
        //private void NameValidation(string value, string propertyName)
        //{
        //    foreach (char harf in value)
        //    {
        //        if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
        //            throw new Exception($"{propertyName} girisi sadece harf ve bosluk ile yapilmalidir");
        //    }
        //}

        private void Validation(string value, string propertyName)
        {
            if (propertyName.Equals("Ad") || propertyName.Equals("Soyad"))
            {
                foreach (char harf in value)
                    if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                        throw new Exception($"{propertyName} girisi sadece harf ve bosluk ile yapilmalidir");
            }

            else if (propertyName.Equals("TCKN") || propertyName.Equals("Telefon"))
            {
                if (value.Length != 11)
                    throw new Exception($"{propertyName}, 11 haneli olmalidir");

                foreach (char sayi in value)
                    if (!char.IsDigit(sayi))
                        throw new Exception($"{propertyName} girisi sadece sayi ile yapilmalidir");

                if (propertyName.Equals("Telefon"))
                    if (!value.StartsWith("0"))
                        throw new Exception($"{propertyName}, 0 ile baslamali");
            }

            else
            {
                Regex rgx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!rgx.IsMatch(value))
                    throw new Exception($"{propertyName} girisi gecersizdir");
            }
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
