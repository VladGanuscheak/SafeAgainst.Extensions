using System.Threading.Tasks;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class GenericSafeAgainstExtensionTests
    {
        #region Synchronous invocations

        [Fact]
        public void SafeAgainst_DefaultValue_Modified()
        {
            // Arrange
            var value = 1;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainst(x => x % 2 != 0, 0);

            Assert.Equal(0, container.Value);
        }

        [Fact]
        public void SafeAgainst_NoReplaceParameter_Modified()
        {
            // Arrange
            var value = 1;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainst(x => x % 2 != 0, () => value - 1);

            Assert.Equal(0, container.Value);
        }

        [Fact]
        public void SafeAgainst_WithReplaceParameter_Modified()
        {
            // Arrange
            var value = 1;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainst(x => x % 2 != 0, x => x - 1);

            Assert.Equal(0, container.Value);
        }

        #endregion

        #region Asynchronous invocations

        [Fact]
        public async Task SafeAgainstAsync_WithReplaceParameter_Modified()
        {
            // Arrange
            var container = SafeContainer.Create(1);

            // Act
            await container.SafeAsyncAgainst(x => x % 2 != 0, x => Task.FromResult(x + 1));

            // Assert
            Assert.Equal(2, container.Value);
        }


        [Fact]
        public async Task SafeAgainstAsync_NoReplaceParameter_Modified()
        {
            // Arrange
            var value = 1;
            var container = SafeContainer.Create(value);

            // Act
            await container.SafeAsyncAgainst(x => x % 2 != 0, () => Task.FromResult(value + 1));
            value = container.Value;

            // Assert
            Assert.Equal(2, value);
        }

        #endregion
    }
}
