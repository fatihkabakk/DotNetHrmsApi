using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        void Add(Employer employer);
        Employer Get(int id);
        List<Employer> GetAll();
        void Update(Employer employer);
    }
}
