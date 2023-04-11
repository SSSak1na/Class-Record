using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AccessEncapsulationRecord.Models
{
    internal record Dog :Animal
    {
        private string _name;
        private string _breed;
    }

    public string Name 
    { 
        get { return _name; } 
        set { _name = value; } 
    }
    public string Breed
    {
        get { return _bread; }
        init { _breed = value; }
    }
    public Dog(string name, string breed, string gender):base(gender) 
    {
        _breed = breed;
        _name = name;
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"Breed:{breed}");
    }
    
          
           
    


}
