using OwensDoug.Core.Repository;

namespace OwensDoug.Core.User.Repository
{
    public class UserRepository : Repository<Entity.User, Context>
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}