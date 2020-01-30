using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication14.DAL;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class PeopleController : ApiController
    {

        readonly IRepository<Person> db;
        public PeopleController(IRepository<Person> repo)
        {
            db = repo;
        }

        //GET api/staff
        public IEnumerable<Person> GetAll()
        {
            return db.GetAll();
        }

        //GET api/staff/3
        public Person Get(int id)
        {
            return db.Get(id);
        }

        //POST api/staff
        [HttpPost]
        public Person CreatePerson(Person person)
        {
            return db.Create(person);
        }

        //PUT api/staff
        [HttpPut]
        public Person UpdatePerson(Person person)
        {
            db.Update(person);
            return person;
        }
        //DELETE api/staff/id
        public void DeletePerson(int id)
        {
            db.Delete(id);
        }
    }
}
