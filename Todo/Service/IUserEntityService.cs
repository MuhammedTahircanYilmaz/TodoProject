using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Model;

namespace TodoProject.Service
{
    public interface IUserEntityService : IService
    {
        void GetByEmail();
        UserEntity GetUserInfo();
        int GetNextId();
        int GetId();
        string GetName();
        string GetLastName();
        short GetAge();
        string GetEmail();
        string GetPassword();
        void GetUpdatedUser(out UserEntity user, out UserEntity updatedUser);
        void PrintUserUpdate(UserEntity user, UserEntity updatedUser);
    }
}
