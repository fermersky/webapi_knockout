using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication14.DAL;
using WebApplication14.Models;
using System.Data.Entity;
namespace WebApplication14.Controllers
{
    public class StaffController : ApiController
    {
        readonly IRepository<Person> db;
        public StaffController(IRepository<Person> repo)
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
        public Person PostPerson(Person person)
        {
            return db.Create(person);
        }

        //PUT api/staff
        public void PutPerson(Person person)
        {
             db.Update(person);
        }
        //DELETE api/staff/id
        public void DeletePerson(int id)
        {
            db.Delete(id);
        }
    }
}
