using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        void Add(Employer employer);
        Employer GetById(int id);
        List<Employer> GetAll();
        void Update(Employer employer);
    }
}
