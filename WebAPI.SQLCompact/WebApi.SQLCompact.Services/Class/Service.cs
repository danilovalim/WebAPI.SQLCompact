using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SQLCompact.Services.Interfaces;
using WebAPI.SQLCompact.Domain;

namespace WebApi.SQLCompact.Services.Class
{
    public class Service : IService
    {
        private User user;
        private UserContext db = new UserContext();

        public List<User> getAllUsers()
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

        public User getUser(int id)
        {
            using (db)
            {
                try
                {
                    user = db.user.Where(x => x.ID == id).FirstOrDefault();

                    if (user != null)
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

        public bool Update(User user)
        {
            using (db)
            {
                try
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            using (db)
            {
                try
                {
                    user = db.user.Where(x => x.ID == id).FirstOrDefault();

                    if(user != null)
                    {
                        db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
