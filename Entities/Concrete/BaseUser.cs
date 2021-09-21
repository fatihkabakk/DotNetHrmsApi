using Entities.Abstract;

namespace Entities.Concrete
{
    public class BaseUser : IEntity
    {
        // TODO: Encrypt Password With HMAC512 and Improve Password Protection.
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool MailStatus { get; set; }
    }
}
