namespace CustomerNotification.Models
{
    public class UserBlockedModel
    {
        public string Type
        {
            get
            {
                return "UserAccessBlocked";
            }
        }

        public UserModel BodyType { get; set; }
    }
}
