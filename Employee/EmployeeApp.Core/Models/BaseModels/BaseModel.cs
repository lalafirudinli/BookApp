namespace EmployeeApp.Core.Models.BaseModels
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Updated { get; set; }

    }
}