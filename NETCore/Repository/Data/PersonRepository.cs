using Microsoft.EntityFrameworkCore;
using NETCore.Context;
using NETCore.Models;
using NETCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Repository.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly MyContext myContext;

        public PersonRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public int Delete(string NIK)
        {
            var data = myContext.Persons.Find(NIK);
            if(data == null)
            {
                throw new ArgumentNullException();
            }
            myContext.Persons.Remove(data);
            return myContext.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            var data = myContext.Persons.ToList();
            if(data == null)
            {
                return null;
            }

            return data;
        }

        public Person GetById(string NIK)
        {
            var data = myContext.Persons.Find(NIK);
            if(data == null)
            {
                return null;
            }

            return data;
        }

        public int Insert(Person person)
        {
            myContext.Persons.Add(person);
            return myContext.SaveChanges();
        }

        public int Update(Person person)
        {
            myContext.Entry(person).State = EntityState.Modified;
            return myContext.SaveChanges();
        }
    }
}
