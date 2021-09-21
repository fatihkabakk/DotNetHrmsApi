using Entities.Abstract;

namespace Entities.Concrete
{
    public class Employer : BaseUser, IEntity
    {
        public string CompanyName { get; set; }
        public string WebSite { get; set; }
        public string PhoneNumber { get; set; }
        public bool StaffApproval { get; set; }
    }
}
