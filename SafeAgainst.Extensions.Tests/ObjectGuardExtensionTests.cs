using SafeAgainst.Extensions.ObjectGuards;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class ObjectGuardExtensionTests
    {
        #region AgainstNull

        [Fact]
        public void AgainstNull_NullCheckByContainer_Modified()
        {
            // Arrange
            object obj = null;
            var expectedValue = new object();
            var container = SafeContainer.Create(obj);

            // Act
            container.SafeAgainstNull(expectedValue);
            obj = container.Value;

            // Assert
            Assert.NotNull(obj);
            Assert.Equal(expectedValue, obj);
        }

        [Fact]
        public void AgainstNull_NotNullCheckByContainer_NotModified()
        {
            // Arrange
            var obj = new object();
            var initialValue = obj;
            var container = SafeContainer.Create(obj);

            // Act
            container.SafeAgainstNull(new { a = 1 });
            obj = container.Value;

            // Assert
            Assert.Equal(initialValue, obj);
        }

        #endregion
    }
}
