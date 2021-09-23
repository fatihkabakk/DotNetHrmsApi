using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EmployerManager : IEmployerService
    {
        IEmployerDal _employerDal;

        public EmployerManager(IEmployerDal employerDal)
        {
            _employerDal = employerDal;
        }

        public void Add(Employer employer)
        {
            _employerDal.Add(employer);
        }

        public Employer Get(int id)
        {
            return _employerDal.Get(e => e.UserId == id);
        }

        public List<Employer> GetAll()
        {
            return _employerDal.GetAll();
        }

        public void Update(Employer employer)
        {
            _employerDal.Update(employer);
        }
    }
}
