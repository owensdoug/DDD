using OwensDoug.Core.Repository;
using OwensDoug.Core.User.Entity;

namespace OwensDoug.Core.User.Repository
{
    public class UserRepository : Repository<UserEntity, Context>
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}