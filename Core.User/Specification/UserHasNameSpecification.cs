using OwensDoug.Core.Specification;
using OwensDoug.Core.User.Entity;

namespace OwensDoug.Core.User.Specification
{
    public class UserHasNameSpecification : Specification<UserEntity>
    {
        public UserHasNameSpecification(string name)
            : base(p => p.Name.ToLower().Contains(name.ToLower()))
        {
        }
    }
}
