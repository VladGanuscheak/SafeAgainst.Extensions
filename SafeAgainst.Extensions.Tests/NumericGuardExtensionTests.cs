using SafeAgainst.Extensions.NumericGuards.Decimal;
using SafeAgainst.Extensions.NumericGuards.Double;
using SafeAgainst.Extensions.NumericGuards.Float;
using SafeAgainst.Extensions.NumericGuards.Int;
using SafeAgainst.Extensions.NumericGuards.Long;
using SafeAgainst.Extensions.NumericGuards.Sbyte;
using SafeAgainst.Extensions.NumericGuards.Short;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class NumericGuardExtensionTests
    {
        #region AgainstNegative

        [Fact]
        public void AgainstNegative_NonNegativeCheckByContainer_NotModified()
        {
            // Arrange
            decimal decimalValue = 1;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = 1;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = 1;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = 1;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = 1;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = 1;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = 1;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            // Act
            decimalContainer.SafeAgainstNegative(0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNegative(0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNegative(0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNegative(0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNegative(0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNegative(0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNegative(0);
            shortValue = shortContainer.Value;

            // Assert
            Assert.Equal(1, decimalInitialValue);
            Assert.Equal(1, decimalValue);

            Assert.Equal(1, doubleInitialValue);
            Assert.Equal(1, doubleValue);

            Assert.Equal(1, floatInitialValue);
            Assert.Equal(1, floatValue);

            Assert.Equal(1, intInitialValue);
            Assert.Equal(1, intValue);

            Assert.Equal(1, longInitialValue);
            Assert.Equal(1, longValue);

            Assert.Equal(1, sbyteInitialValue);
            Assert.Equal(1, sbyteValue);

            Assert.Equal(1, shortInitialValue);
            Assert.Equal(1, shortValue);
        }

        [Fact]
        public void AgainstNegative_NegativeCheckByContainer_Modified()
        {
            // Arrange
            decimal decimalValue = -1;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = -1;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = -1;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = -1;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = -1;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = -1;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = -1;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            // Act
            decimalContainer.SafeAgainstNegative(0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNegative(0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNegative(0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNegative(0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNegative(0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNegative(0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNegative(0);
            shortValue = shortContainer.Value;

            // Assert
            Assert.Equal(-1, decimalInitialValue);
            Assert.Equal(0, decimalValue);

            Assert.Equal(-1, doubleInitialValue);
            Assert.Equal(0, doubleValue);

            Assert.Equal(-1, floatInitialValue);
            Assert.Equal(0, floatValue);

            Assert.Equal(-1, intInitialValue);
            Assert.Equal(0, intValue);

            Assert.Equal(-1, longInitialValue);
            Assert.Equal(0, longValue);

            Assert.Equal(-1, sbyteInitialValue);
            Assert.Equal(0, sbyteValue);

            Assert.Equal(-1, shortInitialValue);
            Assert.Equal(0, shortValue);
        }

        #endregion

        #region AgainstNullOrNegative

        [Fact]
        public void AgainstNullOrNegative_NonNegativeCheckByContainer_NotModified()
        {
            // Arrange
            decimal? decimalValue = 1;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double? doubleValue = 1;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float? floatValue = 1;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int? intValue = 1;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long? longValue = 1;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte? sbyteValue = 1;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short? shortValue = 1;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            // Act
            decimalContainer.SafeAgainstNullOrNegative(0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrNegative(0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrNegative(0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrNegative(0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrNegative(0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrNegative(0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrNegative(0);
            shortValue = shortContainer.Value;

            // Assert
            Assert.Equal(1, decimalInitialValue);
            Assert.Equal(1, decimalValue);

            Assert.Equal(1, doubleInitialValue);
            Assert.Equal(1, doubleValue);

            Assert.Equal(1, floatInitialValue);
            Assert.Equal(1, floatValue);

            Assert.Equal(1, intInitialValue);
            Assert.Equal(1, intValue);

            Assert.Equal(1, longInitialValue);
            Assert.Equal(1, longValue);

            Assert.Equal((sbyte)1, sbyteInitialValue);
            Assert.Equal((sbyte)1, sbyteValue);

            Assert.Equal((short)1, shortInitialValue);
            Assert.Equal((short)1, shortValue);
        }

        [Fact]
        public void AgainstNullOrNegative_NegativeCheckByContainer_Modified()
        {
            // Arrange
            decimal? decimalValue = -1;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double? doubleValue = -1;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float? floatValue = -1;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int? intValue = -1;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long? longValue = -1;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte? sbyteValue = -1;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short? shortValue = -1;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            // Act
            decimalContainer.SafeAgainstNullOrNegative(0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrNegative(0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrNegative(0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrNegative(0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrNegative(0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrNegative(0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrNegative(0);
            shortValue = shortContainer.Value;

            // Assert
            Assert.Equal(-1, decimalInitialValue);
            Assert.Equal(0, decimalValue);

            Assert.Equal(-1, doubleInitialValue);
            Assert.Equal(0, doubleValue);

            Assert.Equal(-1, floatInitialValue);
            Assert.Equal(0, floatValue);

            Assert.Equal(-1, intInitialValue);
            Assert.Equal(0, intValue);

            Assert.Equal(-1, longInitialValue);
            Assert.Equal(0, longValue);

            Assert.Equal((sbyte)-1, sbyteInitialValue);
            Assert.Equal((sbyte)0, sbyteValue);

            Assert.Equal((short)-1, shortInitialValue);
            Assert.Equal((short)0, shortValue);
        }

        [Fact]
        public void AgainstNullOrNegative_NullCheckByContainer_Modified()
        {
            // Arrange
            decimal? decimalValue = null;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double? doubleValue = null;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float? floatValue = null;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int? intValue = null;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long? longValue = null;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte? sbyteValue = null;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short? shortValue = null;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            // Act
            decimalContainer.SafeAgainstNullOrNegative(0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrNegative(0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrNegative(0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrNegative(0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrNegative(0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrNegative(0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrNegative(0);
            shortValue = shortContainer.Value;

            // Assert
            Assert.Null(decimalInitialValue);
            Assert.Equal(0, decimalValue);

            Assert.Null(doubleInitialValue);
            Assert.Equal(0, doubleValue);

            Assert.Null(floatInitialValue);
            Assert.Equal(0, floatValue);

            Assert.Null(intInitialValue);
            Assert.Equal(0, intValue);

            Assert.Null(longInitialValue);
            Assert.Equal(0, longValue);

            Assert.Null(sbyteInitialValue);
            Assert.Equal((sbyte)0, sbyteValue);

            Assert.Null(shortInitialValue);
            Assert.Equal((short)0, shortValue);
        }

        #endregion
    }
}
