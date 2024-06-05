using SafeAgainst.Extensions.EnumGuards;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class EnumGuardExtensionTests
    {
        internal enum PowerOfTwo
        {
            One = 1,
            Two = 2,
            Four = 4,
            Eight = 8,
            Sixteen = 16
        };

        #region AgainstNotInRange

        [Fact]
        public void AgainstNotInRange_NotInRangeCheckByContainer_Modified()
        {
            // Arrange
            PowerOfTwo powerOfTwo = default;
            var initialValue = powerOfTwo;
            var container = SafeContainer<PowerOfTwo>.Create(powerOfTwo);

            // Act
            container.SafeAgainstNotInRange(PowerOfTwo.One);
            powerOfTwo = container.Value;

            // Assert
            Assert.Equal(0, (int)initialValue);
            Assert.Equal(PowerOfTwo.One, powerOfTwo);
        }

        [Fact]
        public void AgainstNotInRange_InRangeCheckByContainer_NotModified()
        {
            // Arrange
            PowerOfTwo powerOfTwo = PowerOfTwo.Four;
            var initialValue = powerOfTwo;
            var container = SafeContainer<PowerOfTwo>.Create(powerOfTwo);

            // Act
            container.SafeAgainstNotInRange(PowerOfTwo.Sixteen);
            powerOfTwo = container.Value;

            // Assert
            Assert.Equal(PowerOfTwo.Four, initialValue);
            Assert.Equal(PowerOfTwo.Four, powerOfTwo);
        }

        #endregion

        #region AgainstNotInRangeOrNull

        [Fact]
        public void AgainstNotInRangeOrNull_NullCheckByContainer_Modified()
        {
            // Arrange
            PowerOfTwo? value = null;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrNotInRange(PowerOfTwo.One);
            value = container.Value;

            // Assert
            Assert.NotNull(value);
            Assert.Equal(PowerOfTwo.One, value);
        }

        [Fact]
        public void AgainstNotInRangeOrNull_NotInRangeCheckByContainer_Modified()
        {
            // Arrange
            PowerOfTwo? value = 0;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrNotInRange(PowerOfTwo.Two);
            value = container.Value;

            // Assert
            Assert.NotNull(value);
            Assert.Equal(PowerOfTwo.Two, value);
        }

        [Fact]
        public void AgainstNotInRangeOrNull_InRangeCheckByContainer_Modified()
        {
            // Arrange
            PowerOfTwo? value = PowerOfTwo.Sixteen;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrNotInRange(PowerOfTwo.Two);
            value = container.Value;

            // Assert
            Assert.NotNull(value);
            Assert.Equal(PowerOfTwo.Sixteen, value);
        }

        #endregion
    }
}
