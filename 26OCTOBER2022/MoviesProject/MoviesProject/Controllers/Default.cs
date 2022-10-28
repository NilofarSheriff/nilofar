using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoviesProject.Context;

namespace MoviesProject.Controllers
{
    public class DefaultController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var result = from movie in db.Movies
                             select new
                             {
                                 movie.MovieId,
                                 movie.MovieName,
                                 movie.RentalAmount,
                                 movie.Language,
                                 Users = from user in db.Users
                                         select new
                                         {
                                             user.Username,
                                             user.Password,
                                             user.Cat
                                         }
                             };
                return Ok(result);

            }
            catch (Exception)
            {
                return InternalServerError();
            }

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }



    }