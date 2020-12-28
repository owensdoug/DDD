using System.Linq;
using Xunit;
using OwensDoug.Core.User.Specification;
using OwensDoug.Core.User.Test.Bulider;

namespace OwensDoug.Core.User.Test.Specification
{
    public class UserSpecificationTest
    {
        private UserBuilder UserBuilder { get; } = new UserBuilder();

        [Fact]
        public void User_Has_First_Name_Spec()
        {
            var spec = new UserHasFirstNameSpecification(UserBuilder.FirstName1);

            var result = UserBuilder.GetUserCollection()
                .AsQueryable()
                .FirstOrDefault(spec.Criteria);

            Assert.NotNull(result);
            Assert.Equal(UserBuilder.FirstName1, result.FirstName);
        }

        [Fact]
        public void User_Has_Last_Name_Spec()
        {
            var spec = new UserHasLastNameSpecification(UserBuilder.LastName1);

            var result = UserBuilder.GetUserCollection()
                .AsQueryable()
                .FirstOrDefault(spec.Criteria);

            Assert.NotNull(result);
            Assert.Equal(UserBuilder.LastName1, result.LastName);
        }
    }
}