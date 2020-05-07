using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Exceptions
{
    class InvalidBirthDateException: Exception
    {
        public DateTime birthDate { get; set; }

        public InvalidBirthDateException(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }
    }
}
