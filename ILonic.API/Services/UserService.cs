using ILonic.API.Data;
using ILonic.API.DTO;
using ILonic.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Services
{
    public class UserService : IUserRepository
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> Login(UserLoginDTO user)
        {
            var currentUser = await _context.Users.Where(u => u.UserName.Equals(user.UserName)).SingleOrDefaultAsync();
            if (currentUser == null)
                return false;

            return currentUser.Password == user.Password ? true : false;
        }

        public async Task<bool> Register(UserRegisterDTO user)
        {
            var currentUser = await _context.Users.Where(u => u.UserName.Equals(user.UserName)).SingleOrDefaultAsync();
            if (currentUser != null)
                return false;

            var userTemp = new User { Id = 0, UserName = user.UserName, Password = user.Password };
            await _context.Users.AddAsync(userTemp);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
