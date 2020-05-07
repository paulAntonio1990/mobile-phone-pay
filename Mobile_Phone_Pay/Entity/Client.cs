using Mobile_Phone_Pay.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Entity
{
    public class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        private DateTime dataNasterii;
        public DateTime DataNasterii
        {
            get { return dataNasterii; }
            set
        {
                if (value > DateTime.Now)
                    throw new InvalidBirthDateException(value);

                dataNasterii = value;
            }
        }
  
        public long IdAbonament { get; set; }
        public long IdExtraOptiune { get; set; }
        public long IdFactura { get; set; }

        public Client(string nume, string prenume, DateTime dataNasterii, long idAbonament, long idExtraOptiune, long idFactura)
        {
            Nume = nume;
            Prenume = prenume;
            DataNasterii = dataNasterii;
            IdAbonament = idAbonament;
            IdExtraOptiune = idExtraOptiune;
            IdFactura = idFactura;
        }
    }
}
