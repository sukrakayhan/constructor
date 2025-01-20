using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Bebek
    {
        //Field alanında değişkenler tanımlanıyor.
        private DateTime _dateTime;
        private string _name;
        private string _surname;



        //Class ile aynı isimde, geriye dönüş tipi olmayan metot.
        public Bebek()
        {
            Console.WriteLine("Ingaaa.");
        }

        public Bebek(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _dateTime = DateTime.Now;
            Console.WriteLine("Ingaaaa");
            Console.WriteLine($"{name} {surname} isimli bebek {_dateTime.ToString("dd.MM.yyyy")} tarihinde dünyaya geldi.");
        }

        //Propertyleri oluşturuyoruz.
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
    }
}