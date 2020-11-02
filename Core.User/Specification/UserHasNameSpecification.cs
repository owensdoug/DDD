using OwensDoug.Core.Specification;

namespace OwensDoug.Core.User.Specification
{
    public class UserHasNameSpecification : Specification<Entity.UserEntity>
    {
        public UserHasNameSpecification(string name)
            : base(p => p.Name.ToLower().Contains(name.ToLower()))
        {

        }
    }
}
