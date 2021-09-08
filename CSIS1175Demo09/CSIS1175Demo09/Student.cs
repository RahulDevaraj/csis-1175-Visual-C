using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS1175Demo09
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Age { get; set; }

        public override string ToString()
        {
            return Id+" "+Name+" "+Age;
        }
    }
}
