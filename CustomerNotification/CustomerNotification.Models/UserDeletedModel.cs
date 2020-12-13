namespace CustomerNotification.Models
{
    public class UserDeletedModel
    {
        public string MessageType
        {
            get
            {
                return "UserDeleted";
            }
        }

        public UserModel Data { get; set; }
    }
}
