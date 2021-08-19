using System;
using System.Globalization;
using WorkersHourContracts.Entities;
using WorkersHourContracts.Entities.Enums;

namespace WorkersHourContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Texto interativo inicial

            Console.WriteLine("Olá, vamos começar?");
            Console.WriteLine("Primeiro, entre com o nome do departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Agora precisamos dos dados do Colaborador...");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Qual o nivel do(a) {name}? (Trainee, Junior, Pleno, Senior, Architect): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // Converte para enum 

            Console.WriteLine($"Qual o salário base do nível {level} para o depto {deptName} (R$): ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ////////////////////////////////// Construtores

            Department dept = new Department(deptName);// Instância o objeto Department

            Worker worker = new Worker(name, level, baseSalary, dept); // Forma o objeto Worker

            // Texto interativo continuação

            Console.WriteLine("Agora, quantos contratos este colaborador realizou?");
            int n = int.Parse(Console.ReadLine()); // pega o numero de contrato e converte em numero

            for (int i=1; i <=n; i++) // roda para cada contrato (depende da quantidade informada)
            {
                Console.WriteLine($"Entre com a data do {i}º contrato abaixo; ");
                Console.WriteLine("Utilize o formato (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Qual o valor/custo por hora desse contrato (R$): ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"E quantas horas foram realizadas: ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                HourContract contract = new HourContract(date, valuePerHour, hours); // Instância o objeto Contrato
                worker.AddContract(contract); // adiciona o contrato ao trabalhador
            }

            // Texto Final

            Console.WriteLine();
            Console.WriteLine("Pronto... ");
            Console.WriteLine("Então, de qual mês e ano você deseja calcular os ganhos? (MM/YYYY): ");
            string montAndYear = Console.ReadLine();
            int month = int.Parse(montAndYear.Substring(0, 2)); // Recorta o mês
            int year = int.Parse(montAndYear.Substring(3)); // Recorta o ano


            // Resultado

            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            Console.WriteLine($"Ganhos de {montAndYear}: R$ {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
