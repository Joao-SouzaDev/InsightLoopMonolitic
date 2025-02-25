using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void AddUser(IUser user)
        {
            _userRepository.Add(user);
        }
        public IEnumerable<IUser> GetUsers()
        {
            return _userRepository.GetAll();
        }
        public void UpdateUser(IUser user)
        {
            _userRepository.Update(user);
        }
        public void DeleteUser(IUser user)
        {
            _userRepository.Delete(user);
        }
        public IUser? GetUserById(Guid userId)
        {
            return _userRepository.GetByIdAsync(userId);
        }
        public IUser GetUserByEmail(string email)
        {
            return _userRepository.GetByEmailAsync(email);
        }
    }
}
