using Core.Entities;

namespace Entities.Concrete
{
    public abstract class User : IEntity
    {
        // TODO: Encrypt Password With HMAC512 and Improve Password Protection.
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool MailStatus { get; set; }
    }
}
