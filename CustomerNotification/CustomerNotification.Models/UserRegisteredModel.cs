namespace CustomerNotification.Models
{
    public class UserRegisteredModel
    {
        public string Type 
        { 
            get
            {
                return "NewUserRegistered";
            }
        }

        public UserDetailsModel BodyType { get; set; }
    }
}
