using System;
using System.Collections.Generic;
using System.Linq;
using project.Data;
using project.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project.IInterfaces;


namespace project.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepo;
        private readonly AppDBContext _context;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepo.GetAll();
        }

        public async Task AddAndSave(User user)
        {
            _userRepo.Add(user);
            await _userRepo.Save();
        }

        public async Task<List<User>> Search(string text)
        {
            text = text.ToLower();
            var searchedUsers = await _userRepo.GetUsers(user => user.Login.ToLower().Contains(text)
                                            || user.Password.ToLower().Contains(text));

            return searchedUsers;
        }
    }
}
