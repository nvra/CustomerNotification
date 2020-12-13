using System;

namespace CustomerNotification.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
    }

    public class UserDetailsModel
    {
        public Guid UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
