using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSprint12.Models
{
    public interface IDog
    {
        
        int DogID { get; }
        string Name { get; set; }
        int Age { get; set; }

    }
}
