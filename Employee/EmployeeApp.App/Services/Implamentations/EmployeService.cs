using EmployeeApp.App.Interfaces;
using EmployeeApp.Core.Repository;

namespace EmployeeApp.App.Implamentations
{
    public class EmployeService : IEmployeServices
    {
        private readonly 

        public void Create()
        {
            Employe employe = new Employe();
            Console.WriteLine("Add Name");
            string Name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Add Name");
                Name = Console.ReadLine();

            }
            employe.Name = Name;

            Console.WriteLine("Add Surname");
            string Surname = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Surname))
            {
                Console.WriteLine("Add Surname");
                Surname = Console.ReadLine();
            }
            employe.Surname = Surname;

            Console.WriteLine("Add Salary");
            double.TryParse(Console.ReadLine(), out double Salary);

            while (Salary <= 0)
            {
                Console.WriteLine("Add valid Salary");
                Console.WriteLine("Add Salary");
                double.TryParse(Console.ReadLine(), out Salary);
            }

            employe.Salary = Salary;

            Console.WriteLine("Add Position");
            employe.Position = Console.ReadLine();

            DateTime dateTime = DateTime.UtcNow.AddHours(4);


            _repository.Create(employe);




            ;
        }

        public void Delete()
        {
            Console.WriteLine("Enter Id");
            int.TryParse(Console.ReadLine(), out int id);

            var employe = _repository.Get(x => x.Id == id);

            if (employe == null)
            {
                Console.WriteLine("Employe not found");
            }
            else
            {
                _repository.Delete(employe);
                Console.WriteLine("Deleted");
            }
        }

        public void ShowAll()
        {
            List<Employe> employes = _repository.GetAll();

            foreach (var item in employes)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowByName()
        {
            Console.WriteLine("add name");
            string name = Console.ReadLine().Trim();
            Employe _employe = _repository.Get(x => x.Name.ToLower().Contains(name.ToLower()));

            if (_employe == null)
            {
                Console.WriteLine("Employe not Found");
            }
            else
            {
                Console.WriteLine(_employe);
            }
        }

        public void ShowById()
        {
            Console.WriteLine("Ente id");
            int.TryParse(Console.ReadLine(), out int id);

            Employe _employe = _repository.Get(x => x.Id == id);

            if (_employe == null)
            {
                Console.WriteLine("Employe not Found");
            }
            else
            {
                Console.WriteLine(_employe);
            }
        }



        public void Update()
        {
            Console.WriteLine("Enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Employe employe = _repository.Get(x => x.Id == id);

            if (employe == null)
            {
                Console.WriteLine("Employe not found");
            }
            else
            {
                Console.WriteLine("Add name");
                employe.Name = Console.ReadLine();

            }

            DateTime UpdateTime = DateTime.UtcNow.AddHours(4);

        }
    }
}