using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Entity
{
    [Serializable]
    public class TipAbonament
    {
        public string Name { get; set; }
        public int NoMinutes { get; set; }
        public int NoMessages { get; set; }
        public int NoNetMb { get; set; }
        public double Price { get; set; }

        public TipAbonament() { }
        public TipAbonament(string name, int noMinutes, int noMessages, int noNetMb, double price)
        {
            Name = name;
            NoMinutes = noMinutes;
            NoMessages = noMessages;
            NoNetMb = noNetMb;
            Price = price;
        }
    }
}
