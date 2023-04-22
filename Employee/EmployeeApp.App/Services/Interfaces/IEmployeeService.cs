using EmployeeApp.Core.Models;


namespace EmployeeApp.App.Interfaces
{
    public interface IEmployeServices
    {
        public void Create();
        public void Update();
        public void Delete();
        public void ShowById();
        public void ShowAll();
    }
}

