﻿namespace P02.ExtendedDatabaseTests
{
    using NUnit.Framework;
    using P02.ExtendedDatabase.Contracts;
    using P02.ExtendedDatabase.Models;

    public class PersonTest
    {
        private const long PersonId = 1;
        private const string PersonUsername = "Ivan";

        [Test]
        public void InitializePersonConstructor()
        {
            IPerson person = new Person(PersonId, PersonUsername);

            Assert.That(person.Username, Is.Not.EqualTo(null));
            Assert.That(person.Id, Is.EqualTo(PersonId));
            Assert.That(person.Username, Is.EqualTo(PersonUsername));
        }
    }
}
