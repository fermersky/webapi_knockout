using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication14.Models;

namespace WebApplication14.DAL
{
    public class StaffRepository : IRepository<Person>
    {
        StaffContext db = new StaffContext();
        
        public Person Create(Person item)
        {
            db.People.Add(item);
            db.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            Person person = Get(id);
            if (person != null)
            {
                db.People.Remove(person);
                db.SaveChanges();
            }
        }

        public Person Get(int id)
        {
            return db.People.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return db.People;
        }

        public bool Update(Person item)
        {
            Person selected = Get(item.Id);
            if (selected != null)
            {
                selected.Name = item.Name;
                selected.Age = item.Age;
                selected.Married = item.Married;
                db.Entry(selected).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~StaffRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}