using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using InsightLoop.Infra.Data;
using InsightLoop.Infra.Data.Security;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IUser = InsightLoop.Domain.Entities.IUser;

namespace InsightLoop.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public void Add(IUser entity)
        {
            _userManager.CreateAsync((ApplicationUser)entity);
        }

        public void Delete(IUser entity)
        {
            _userManager.DeleteAsync((ApplicationUser)entity);
        }

        public IEnumerable<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IUser GetByEmailAsync(string email)
        {
            return _userManager.FindByEmail(email);
        }

        public IUser GetByIdAsync(Guid id)
        {
            return _userManager.FindById(id.ToString());
        }

        public void Update(IUser entity)
        {
            _userManager.UpdateAsync((ApplicationUser)entity);
        }
    }
}
