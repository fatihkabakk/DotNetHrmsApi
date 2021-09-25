using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobPositionService
    {
        void Add(JobPosition jobPosition);
        JobPosition GetById(int id);
        List<JobPosition> GetAll();
        void Update(JobPosition jobPosition);
    }
}
