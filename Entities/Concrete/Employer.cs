using Core.Entities;

namespace Entities.Concrete
{
    public class Employer : User, IEntity
    {
        public string CompanyName { get; set; }
        public string WebSite { get; set; }
        public string PhoneNumber { get; set; }
        public bool StaffApproval { get; set; }
    }
}
