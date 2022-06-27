using System;
namespace DemoLibrary;

public class BadClass
{

    public string creditCardNumber;

    private string _ppsn;

    public string PPSN
    {
        get
        {
            return "****-***-1234";
        }
        set
        {
            _ppsn = value;
        }
    }

    public int _age;

    public int Age
    {
        get { return _age; }

        set
        {
            if (value >= 0 && value < 130)
            {
                _age = value;
            }
        }
    }

}

