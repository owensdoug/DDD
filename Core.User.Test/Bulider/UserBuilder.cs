using System.Collections.Generic;

namespace OwensDoug.Core.User.Test.Bulider
{
    public class UserBuilder
    {
        public int UserId1 => 123;
        public int UserId2 => 124;
        public int UserId3 => 125;
        public string Name1 => "NameX";
        public string Name2 => "NameY";
        public string Name3 => "NameZ";

        public List<Entity.UserEntity> GetUserCollection()
        {
            return new List<Entity.UserEntity>()
            {
                Entity.UserEntity.Create(UserId1, Name1),
                Entity.UserEntity.Create(UserId2, Name2),
                Entity.UserEntity.Create(UserId3, Name3)
            };
        }
    }
}
