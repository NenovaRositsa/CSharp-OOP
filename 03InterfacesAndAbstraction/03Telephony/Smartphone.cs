using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable

    {
        public string Browse(string url)
        {
            
            if (url.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (number.Any(char.IsLetter))
            {
                throw new ArgumentException("Invalid number!");
            }
            
            return $"Calling... {number}";
        }

    }
}
