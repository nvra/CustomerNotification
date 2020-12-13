using CustomerNotification.Models;
using CustomerNotification.Repository;
using System;
using System.Threading.Tasks;

namespace CustomerNotificaton.Services
{
    public interface IMessagingService
    {
        Task<UserRegisteredModel> GetUserRegisteredResponse(Guid userId);

        Task<UserBlockedModel> GetUserBlockedResponse(Guid userId);

        Task<UserDeletedModel> GetUserDeletedResponse(Guid userId);
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

        public async Task<UserRegisteredModel> GetUserRegisteredResponse(Guid userId)
        {
            var user = await _messageRepository.GetUserDetails(userId);

            if(user != null)
            {
                var response = new UserRegisteredModel
                {
                    Data = user
                };

                return response;
            }

            return null;
        }

        public async Task<UserBlockedModel> GetUserBlockedResponse(Guid userId)
        {
            var user = await _messageRepository.GetUser(userId);

            if (user != null)
            {
                var response = new UserBlockedModel
                {
                    Data = user
                };

                return response;
            }

            return null;
        }

        public async Task<UserDeletedModel> GetUserDeletedResponse(Guid userId)
        {
            var user = await _messageRepository.GetUser(userId);

            if (user != null)
            {
                var response = new UserDeletedModel
                {
                    Data = user
                };

                return response;
            }

            return null;
        }
    }
}