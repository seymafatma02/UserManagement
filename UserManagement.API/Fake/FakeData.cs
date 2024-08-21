using UserManagement.API.Models;
using Bogus;
using System.Collections.Generic;



namespace UserManagement.API.Fake
{// bogus ktuphanesi eklendi bu kutuphane user turnden fake datalar olusturması
    public  static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int number)
        {
            _users = new Faker<User>()
                .RuleFor(u => u.Id,f =>f.IndexFaker)
                .RuleFor(u => u.Firstname ,f =>f.Name.FirstName())
                .RuleFor( u => u.Lastname , f =>f.Name.LastName())  
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .Generate(number);
            return _users;
        }
    }
}
