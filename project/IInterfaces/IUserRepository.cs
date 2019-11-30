using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using project.Models;

namespace project.IInterfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        Task Save();
        Task<List<User>> GetAll();
        Task<List<User>> GetUsers(Expression<Func<User, bool>> predicate);
    }
}
