using System.ComponentModel.DataAnnotations;

namespace OwensDoug.Core.User.Entity
{
    public class UserEntity : Core.Entity.Entity
    {
        [Required]
        [StringLength(320, MinimumLength = 3)]
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
