using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {

       
        public string Call(string number)
        {
            if (!number.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }
    }
}
