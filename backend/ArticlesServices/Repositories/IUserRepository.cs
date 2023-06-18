using System.Collections.Generic;
using ArticlesServices.ModelsDTO;

namespace ArticlesServices.Repositories
{
    public interface IUserRepository
    {
        List<UserDto> GetAllUsers();
    }
}