using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ApplicantManager : IApplicantService
    {
        IApplicantDal _applicantDal;

        public ApplicantManager(IApplicantDal applicantDal)
        {
            _applicantDal = applicantDal;
        }

        public void Add(Applicant applicant)
        {
            _applicantDal.Add(applicant);
        }

        public Applicant Get(int id)
        {
            return _applicantDal.Get(a => a.UserId == id);
        }

        public List<Applicant> GetAll()
        {
            return _applicantDal.GetAll();
        }

        public void Update(Applicant applicant)
        {
            _applicantDal.Update(applicant);
        }
    }
}
