using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class JobAdvertManager : IJobAdvertService
    {
        IJobAdvertDal _jobAdvertDal;

        public JobAdvertManager(IJobAdvertDal jobAdvertDal)
        {
            _jobAdvertDal = jobAdvertDal;
        }

        public void Add(JobAdvert jobAdvert)
        {
            _jobAdvertDal.Add(jobAdvert);
        }

        public List<JobAdvert> GetAll()
        {
            return _jobAdvertDal.GetAll();
        }

        public JobAdvert GetById(int id)
        {
            return _jobAdvertDal.Get(ja => ja.Id == id);
        }

        public void Disable(JobAdvert jobAdvert)
        {
            jobAdvert.Status = false;
            Update(jobAdvert);
        }

        public void Update(JobAdvert jobAdvert)
        {
            _jobAdvertDal.Update(jobAdvert);
        }

        public List<JobAdvertDto> GetAllActiveAdverts()
        {
            return _jobAdvertDal.GetAllActiveAdverts();
        }

        public List<JobAdvertDto> GetAllActiveAdvertsOrderByCreatedDate()
        {
            return _jobAdvertDal.GetAllActiveAdvertsOrderByCreatedDate();
        }

        public List<JobAdvertDto> GetAllActiveAdvertsByCompany(int companyId)
        {
            return _jobAdvertDal.GetAllActiveAdvertsByCompany(companyId);
        }

        public void Enable(JobAdvert jobAdvert)
        {
            jobAdvert.Status = true;
            Update(jobAdvert);
        }
    }
}
