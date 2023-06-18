using System.Collections.Generic;
using System.Linq;
using ArticlesData;
using ArticlesServices.ModelsDTO;

namespace ArticlesServices.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(ArticlesDBContext context)
        {
            _context = context;
        }
        private readonly ArticlesDBContext _context;

        public List<UserDto> GetAllUsers()
        {
            return (from u in _context.User
                    orderby u.Id
                    select new UserDto()
                    {
                        Id = u.Id,
                        Name = u.Name,
                        Email = u.Email,
                        Admin = u.Admin,
                        Role = u.Role
                    }).ToList();
        }
    }
}