using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersHourContracts.Entities
{
    class HourContract
    {
        // Propriedades da classe:

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        // construtores:

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Metodo que retorna o valor total do contrato:

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
