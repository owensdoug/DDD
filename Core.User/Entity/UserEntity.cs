namespace OwensDoug.Core.User.Entity
{
    public class UserEntity : Core.Entity.Entity
    {
        public string Name { get; set; }
        public static UserEntity Create(int id, string name) 
        {
            return new UserEntity
            {
                Id = id,
                Name = name
            };
        }
    }
}
