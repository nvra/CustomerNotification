namespace CustomerNotification.Models
{
    public class UserRegisteredModel
    {
        public string MessageType 
        { 
            get
            {
                return "NewUserRegistered";
            }
        }

        public UserDetailsModel Data { get; set; }
    }
}
