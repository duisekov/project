using Microsoft.EntityFrameworkCore;
using project.Data;
using project.IInterfaces;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace project.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly AppDBContext _context;

        public UserRepository(AppDBContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Add(user);
        }

        public Task<List<User>> GetAll()
        {
            return _context.Users.ToListAsync();
        }

        public Task<List<User>> GetUsers(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Where(predicate).ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
