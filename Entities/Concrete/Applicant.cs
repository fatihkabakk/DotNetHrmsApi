using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Applicant : User, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNo { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
