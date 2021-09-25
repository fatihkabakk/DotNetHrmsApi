using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IJobAdvertDal : IEntityRepository<JobAdvert>
    {
        List<JobAdvertDto> GetAllActiveAdverts();
        List<JobAdvertDto> GetAllActiveAdvertsOrderByCreatedDate();
        List<JobAdvertDto> GetAllActiveAdvertsByCompany(int companyId);
    }
}
