using Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Applicant : BaseUser, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNo { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
