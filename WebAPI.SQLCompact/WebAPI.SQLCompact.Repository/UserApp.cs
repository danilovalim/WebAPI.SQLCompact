using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.SQLCompact.Domain;

namespace WebAPI.SQLCompact.Repository
{
    public class UserApp
    {
        private User user;
        private UserContext db = new UserContext();

        public bool Insert(User user)
        {
            using (db)
            {
                try
                {
                    db.user.Add(user);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<User> GetAll()
        {
            using (db)
            {
                try
                {
                    var usersList = db.user.ToList();
                    if (usersList.Count > 0)
                    {
                        return usersList;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public User GetUser(int id)
        {
            using (db)
            {
                try
                {
                    user = db.user.Where(x => x.ID == id).FirstOrDefault();

                    if(user != null)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
