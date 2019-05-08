using System;
namespace Travel
{
    public class EmptyClass
    {
        string fName;
        string lName;
        string city;
        string state;

        public EmptyClass(string fNam, string lNam, string c, string s)
        {
            fName = fNam;
            lName = lNam;
            city = c;
            state = s;
        }

        public override string ToString()
        {
            return $"fName + lName + city + state";
        }

    }
}

