using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SQLCompact.Domain;

namespace WebApi.SQLCompact.Services.Interfaces
{
   public interface IService
    {
        List<User> getAllUsers();
        User getUser(int id);
        bool Insert(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
