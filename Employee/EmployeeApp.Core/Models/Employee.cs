using EmployeeApp.Core.Models.BaseModels;



namespace EmployeeApp.Core.Models
{
    public class Employe : BaseModel
    {
        private static int _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }


        public Employe()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Surname:{Surname}, Salary:{Salary}, Position{Position},DateTime:{DateTime},UpdateTime{Updated}";
        }
    }
}