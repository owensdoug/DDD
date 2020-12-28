using System.Collections.Generic;

namespace OwensDoug.Core.User.Test.Bulider
{
    public class UserBuilder
    {
        public int UserId1 => 123;
        public int UserId2 => 124;
        public int UserId3 => 125;
        public string FirstName1 => "GivenNameX";
        public string FirstName2 => "GivenNameY";
        public string FirstName3 => "GivenNameZ";
        public string LastName1 => "LastNameX";
        public string LastName2 => "LastNameY";
        public string LastName3 => "LastNameZ";

        public List<Entity.User> GetUserCollection()
        {
            return new List<Entity.User>()
            {
                Entity.User.Create(UserId1, FirstName1, LastName1),
                Entity.User.Create(UserId2, FirstName2, LastName2),
                Entity.User.Create(UserId3, FirstName3, LastName3)
            };
        }
    }
}
