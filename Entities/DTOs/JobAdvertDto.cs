using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class JobAdvertDto : IDto
    {
        public int AdvertId { get; set; }
        public string JobPositionName { get; set; }
        public string EmployerName { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int Vacancies { get; set; }
        public DateTime LastApplyDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
