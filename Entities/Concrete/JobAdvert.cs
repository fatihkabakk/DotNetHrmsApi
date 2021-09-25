using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class JobAdvert : IEntity
    {
        public JobAdvert()
        {
            CreatedDate = DateTime.Now;
            Status = true;
        }

        public int Id { get; set; }
        public int JobPositionId { get; set; }
        public int EmployerId { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int Vacancies { get; set; }
        public bool? Status { get; set; }
        public DateTime LastApplyDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
