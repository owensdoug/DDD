using OwensDoug.Core.User.Entity;
using OwensDoug.Core.Repository;

namespace OwensDoug.Core.User.Repository
{
    public class UserRepository : Repository<UserEntity, Context>
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}