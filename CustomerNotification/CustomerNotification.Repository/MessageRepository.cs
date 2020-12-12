using CustomerNotification.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerNotification.Repository
{
    public interface IMessageRepository
    {
        Task<UserDetailsModel> GetUserDetails(string userId);
            
        Task<UserModel> GetUser(string userId);
    }

    public class MessageRepository : IMessageRepository
    {
        public async Task<UserDetailsModel> GetUserDetails(string userId)
        {
            try
            {
                var users = await GetUsersData();

                return users.Where(x => x.UserId == userId).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public async Task<UserModel> GetUser(string userId)
        {
            try
            {
                var users = await GetUsersData();

                return users.Where(x => x.UserId == userId).Select(x => new UserModel { UserId = x.UserId }).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        private async Task<List<UserDetailsModel>> GetUsersData()
        {
            try
            {
                var basePath = Environment.CurrentDirectory;
                var filePath = $"{ basePath}\\Data\\data.json";
                var text = await File.ReadAllBytesAsync(filePath);
                var stream = new MemoryStream(text);

                var users = await JsonSerializer.DeserializeAsync<List<UserDetailsModel>>(stream);

                return users;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
