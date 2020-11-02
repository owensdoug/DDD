using System.Linq;
using Xunit;
using OwensDoug.Core.User.Specification;
using OwensDoug.Core.User.Test.Bulider;

namespace OwensDoug.Core.User.Test.Specification
{
    public class UserSpecificationTests
    {
        private UserBuilder UserBuilder { get; } = new UserBuilder();

        [Fact]
        public void User_Has_Name_Spec()
        {
            var spec = new UserHasNameSpecification(UserBuilder.Name1);

            var result = UserBuilder.GetUserCollection()
                .AsQueryable()
                .FirstOrDefault(spec.Criteria);

            Assert.NotNull(result);
            Assert.Equal(UserBuilder.UserId1, result.Id);
            Assert.Equal(UserBuilder.Name1, result.Name);
        }
    }
}
