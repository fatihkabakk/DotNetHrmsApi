using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void Add(Applicant applicant);
        Applicant GetById(int id);
        List<Applicant> GetAll();
        void Update(Applicant applicant);
    }
}
