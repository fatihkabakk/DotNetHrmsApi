using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class JobPositionManager : IJobPositionService
    {
        IJobPositionDal _jobPositionDal;

        public JobPositionManager(IJobPositionDal jobPositionDal)
        {
            _jobPositionDal = jobPositionDal;
        }

        public void Add(JobPosition jobPosition)
        {
            _jobPositionDal.Add(jobPosition);
        }

        public JobPosition Get(int id)
        {
            return _jobPositionDal.Get(jp => jp.Id == id);
        }

        public List<JobPosition> GetAll()
        {
            return _jobPositionDal.GetAll();
        }

        public void Update(JobPosition jobPosition)
        {
            _jobPositionDal.Update(jobPosition);
        }
    }
}
