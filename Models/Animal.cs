using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessEncapsulationRecord.Models
{
    internal record Animal
    {
        private string _gender;
        private string _birthdate;
    }

    public int Birthdate
    {
     get { return _gender;}
     init { _gender = value; }

    }
    public string Gender
    {
        get { return _gender; }
        init { _gender = value; }
    }
    public Animal(string gender)
    {
        _birthdate = DateTime.Now.Year;
        _gender = gender;
        Console.WriteLine($"Birthdate:{_birthday}");
        Console.WriteLine($"Gender:{_gender}");
    }
}
