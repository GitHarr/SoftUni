using System;
using System.Collections.Generic;
using System.Text;

namespace P02.ExtendedDatabase.Models
{
    using Contracts;

    public class Person : IPerson
    {
        public Person(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public long Id { get; }

        public string Username { get; }
    }
}
