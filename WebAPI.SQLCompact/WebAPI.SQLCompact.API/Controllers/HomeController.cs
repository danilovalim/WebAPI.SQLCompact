using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApi.SQLCompact.Services.Class;
using WebApi.SQLCompact.Services.Interfaces;
using WebAPI.SQLCompact.Domain;

namespace WebAPI.SQLCompact.API.Controllers
{
    public class HomeController : ApiController
    {
        private Service service = new Service();

        public List<User> Get()
        {
            var usersList = new List<User>();

            usersList = service.getAllUsers();

            return usersList;
        }

        public IHttpActionResult Get(int id)
        {
            var user = service.getUser(id);

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Post(User user)
        {
            var result = service.Insert(user);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Put(User user)
        {
            var result = service.Update(user);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            var result = service.Delete(id);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}