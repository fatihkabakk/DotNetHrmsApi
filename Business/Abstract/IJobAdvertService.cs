using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobAdvertService
    {
        void Add(JobAdvert jobAdvert);
        void Disable(JobAdvert jobAdvert);
        void Enable(JobAdvert jobAdvert);
        JobAdvert GetById(int id);
        List<JobAdvert> GetAll();
        void Update(JobAdvert jobAdvert);
        List<JobAdvertDto> GetAllActiveAdverts();
        List<JobAdvertDto> GetAllActiveAdvertsOrderByCreatedDate();
        List<JobAdvertDto> GetAllActiveAdvertsByCompany(int companyId);
    }
}
