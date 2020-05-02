using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Exceptions
{
    class InvalidDueDateException: Exception
    {
        public DateTime dueDate { get; set; }

        public InvalidDueDateException(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }
    }
}
