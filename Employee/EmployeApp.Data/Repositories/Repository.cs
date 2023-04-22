using EmployeeApp.Core.Models.BaseModels;


namespace Employe.Data.Repository
{
    public class Repository<T> where T : BaseModel
    {
        private readonly List<T> _items = new List<T>();


        public void Create(T model)
        {
            _items.Add(model);
        }

        public void Delete(T model)
        {
            _items.Remove(model);
        }

        public T Get(Func<T, bool> Expression)
        {

            return _items.FirstOrDefault(Expression);
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }
}
