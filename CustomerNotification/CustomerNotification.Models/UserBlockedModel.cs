namespace CustomerNotification.Models
{
    public class UserBlockedModel
    {
        public string MessageType
        {
            get
            {
                return "UserAccessBlocked";
            }
        }

        public UserModel Data { get; set; }
    }
}
