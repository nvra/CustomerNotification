using CustomerNotification.Models;
using CustomerNotification.Repository;
using System;
using System.Threading.Tasks;

namespace CustomerNotificaton.Services
{
    public interface IMessagingService
    {
        Task<UserRegisteredModel> GetUserRegisteredResponse(string userId);

        Task<UserBlockedModel> GetUserBlockedResponse(string userId);

        Task<UserDeletedModel> GetUserDeletedResponse(string userId);
    }

    public class MessagingService : IMessagingService
    {
        private readonly IMessageRepository _messageRepository;
        public MessagingService(IMessageRepository repository)
        {
            _messageRepository = repository;
        }

        public async Task SendMessageAsync(string customerId, string messageBody)
        {
            //this is a mock method and candidates don't need to chage this
            await Task.Delay(1000);
            Console.WriteLine($"sending customer id: {customerId}, the following message {messageBody}");
        }

        public async Task<UserRegisteredModel> GetUserRegisteredResponse(string userId)
        {
            var user = await _messageRepository.GetUserDetails(userId);

            if(user != null)
            {
                var response = new UserRegisteredModel
                {
                    BodyType = user
                };

                return response;
            }

            return null;
        }

        public async Task<UserBlockedModel> GetUserBlockedResponse(string userId)
        {
            var user = await _messageRepository.GetUser(userId);

            if (user != null)
            {
                var response = new UserBlockedModel
                {
                    BodyType = user
                };

                return response;
            }

            return null;
        }

        public async Task<UserDeletedModel> GetUserDeletedResponse(string userId)
        {
            var user = await _messageRepository.GetUser(userId);

            if (user != null)
            {
                var response = new UserDeletedModel
                {
                    BodyType = user
                };

                return response;
            }

            return null;
        }
    }
}