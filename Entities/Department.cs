using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersHourContracts.Entities
{
    class Department
    {
        // Propriedades:

        public string Name { get; set; }

        // Contrutores:

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
