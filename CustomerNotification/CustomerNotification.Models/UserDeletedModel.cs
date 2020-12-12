namespace CustomerNotification.Models
{
    public class UserDeletedModel
    {
        public string Type
        {
            get
            {
                return "UserDeleted";
            }
        }

        public UserModel BodyType { get; set; }
    }
}
