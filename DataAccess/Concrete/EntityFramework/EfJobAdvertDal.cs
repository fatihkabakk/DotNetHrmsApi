using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfJobAdvertDal : EfEntityRepositoryBase<JobAdvert, HrmsContext>, IJobAdvertDal
    {
        public List<JobAdvertDto> GetAllActiveAdverts()
        {
            using HrmsContext context = new();
            var result = from ja in context.JobAdverts
                         join jp in context.JobPositions
                         on ja.JobPositionId equals jp.Id
                         join e in context.Employers
                         on ja.EmployerId equals e.UserId
                         where ja.Status == true &&
                         DateTime.Compare((DateTime)ja.LastApplyDate, DateTime.Now) >= 0
                         select new JobAdvertDto
                         {
                             AdvertId = ja.Id,
                             City = ja.City,
                             CreatedDate = ja.CreatedDate,
                             Description = ja.Description,
                             EmployerName = e.CompanyName,
                             JobPositionName = jp.JobName,
                             LastApplyDate = ja.LastApplyDate,
                             MaxSalary = ja.MaxSalary,
                             MinSalary = ja.MinSalary,
                             Vacancies = ja.Vacancies
                         };
            return result.ToList();
        }

        public List<JobAdvertDto> GetAllActiveAdvertsByCompany(int companyId)
        {
            using HrmsContext context = new();
            var result = from ja in context.JobAdverts
                         join jp in context.JobPositions
                         on ja.JobPositionId equals jp.Id
                         join e in context.Employers
                         on ja.EmployerId equals e.UserId
                         where ja.Status == true &&
                         e.UserId == companyId &&
                         DateTime.Compare((DateTime)ja.LastApplyDate, DateTime.Now) >= 0
                         select new JobAdvertDto
                         {
                             AdvertId = ja.Id,
                             City = ja.City,
                             CreatedDate = ja.CreatedDate,
                             Description = ja.Description,
                             EmployerName = e.CompanyName,
                             JobPositionName = jp.JobName,
                             LastApplyDate = ja.LastApplyDate,
                             MaxSalary = ja.MaxSalary,
                             MinSalary = ja.MinSalary,
                             Vacancies = ja.Vacancies
                         };
            return result.ToList();
        }

        public List<JobAdvertDto> GetAllActiveAdvertsOrderByCreatedDate()
        {
            using HrmsContext context = new();
            var result = from ja in context.JobAdverts
                         join jp in context.JobPositions
                         on ja.JobPositionId equals jp.Id
                         join e in context.Employers
                         on ja.EmployerId equals e.UserId
                         where ja.Status == true &&
                         DateTime.Compare((DateTime)ja.LastApplyDate, DateTime.Now) >= 0
                         orderby ja.CreatedDate ascending
                         select new JobAdvertDto
                         {
                             AdvertId = ja.Id,
                             City = ja.City,
                             CreatedDate = ja.CreatedDate,
                             Description = ja.Description,
                             EmployerName = e.CompanyName,
                             JobPositionName = jp.JobName,
                             LastApplyDate = ja.LastApplyDate,
                             MaxSalary = ja.MaxSalary,
                             MinSalary = ja.MinSalary,
                             Vacancies = ja.Vacancies
                         };
            return result.ToList();
        }
    }
}
