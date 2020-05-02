using Mobile_Phone_Pay.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Entity
{
    [Serializable]
    public class Plata
    {
        public double Value { get; set; }

        private DateTime dueDate;
        public DateTime DueDate
        {
            get { return dueDate; }
            set
            {
                if (value < DateTime.Now)
                    throw new InvalidDueDateException(value);

                dueDate = value;
            }
        }

        public Plata() { }
        public Plata(double value, DateTime dueDate)
        {
            Value = value;
            DueDate = dueDate;
        }
    }
}
