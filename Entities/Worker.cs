using System.Collections.Generic;
using WorkersHourContracts.Entities.Enums;

namespace WorkersHourContracts.Entities
{
    class Worker
    {
        // Propriedades da classe:

        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Pega da listagem Enum
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associado ao tipo de departamento 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Lista para vários contratos

        // Construtores da classe

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // Metódos da classe

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); // Adiciona um contrato à lista de contrato
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); // Acessa a lista e remove um contrato da lista
        }

        public double Income(int year, int month) // Calcula os ganhos (soma o salario base + valor dos contratos)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) // Apenas se o mes e ano forem pesquisados
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
            
            
            }
}
