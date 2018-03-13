using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : ICallable, IBrowsable
{
    private string phoneNumber;
    private string url;

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            long number;
            if (!value.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }
            phoneNumber = value;
        }
    }

    public string URL
    {
        get { return url; }
        set
        {
            if (value.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            url = value;
        }
    }

}

