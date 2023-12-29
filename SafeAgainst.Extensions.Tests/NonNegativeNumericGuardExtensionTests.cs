using SafeAgainst.Extensions.NumericGuards.Byte;
using SafeAgainst.Extensions.NumericGuards.Decimal;
using SafeAgainst.Extensions.NumericGuards.Double;
using SafeAgainst.Extensions.NumericGuards.Float;
using SafeAgainst.Extensions.NumericGuards.Int;
using SafeAgainst.Extensions.NumericGuards.Long;
using SafeAgainst.Extensions.NumericGuards.Sbyte;
using SafeAgainst.Extensions.NumericGuards.Short;
using SafeAgainst.Extensions.NumericGuards.Uint;
using SafeAgainst.Extensions.NumericGuards.Ulong;
using SafeAgainst.Extensions.NumericGuards.Ushort;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class NonNegativeNumericGuardExtensionTests
    {
        #region AgainstZero

        [Fact]
        public void AgainstZero_ZeroCheckByContainer_Modified()
        {
            // Arrange
            byte byteValue = default;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal decimalValue = default;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = default;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = default;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = default;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = default;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = default;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = default;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            uint uintValue = default;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong ulongValue = default;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort ushortValue = default;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstZero(1);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstZero(1);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstZero(1);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstZero(1);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstZero(1);
            intValue = intContainer.Value;

            longContainer.SafeAgainstZero(1);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstZero(1);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstZero(1);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstZero(1);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstZero(1);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstZero(1);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.Equal(0, byteInitialValue);
            Assert.Equal(1, byteValue);

            Assert.Equal(0, decimalInitialValue);
            Assert.Equal(1, decimalValue);

            Assert.Equal(0, doubleInitialValue);
            Assert.Equal(1, doubleValue);

            Assert.Equal(0, floatInitialValue);
            Assert.Equal(1, floatValue);

            Assert.Equal(0, intInitialValue);
            Assert.Equal(1, intValue);

            Assert.Equal(0, longInitialValue);
            Assert.Equal(1, longValue);

            Assert.Equal(0, sbyteInitialValue);
            Assert.Equal(1, sbyteValue);

            Assert.Equal(0, shortInitialValue);
            Assert.Equal(1, shortValue);

            Assert.Equal(0u, uintInitialValue);
            Assert.Equal(1u, uintValue);

            Assert.Equal(0ul, ulongInitialValue);
            Assert.Equal(1ul, ulongValue);

            Assert.Equal(0, ushortInitialValue);
            Assert.Equal(1, ushortValue);
        }

        [Fact]
        public void AgainstZero_NotZeroCheckByContainer_NotModified()
        {
            // Arrange
            byte byteValue = 1;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal decimalValue = 1;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = 1;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = 1;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = 1;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = 1;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = 1;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = 1;
            var shortContainer = SafeContainer.Create(shortValue);

            uint uintValue = 1;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong ulongValue = 1;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort ushortValue = 1;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstZero(2);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstZero(2);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstZero(2);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstZero(2);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstZero(2);
            intValue = intContainer.Value;

            longContainer.SafeAgainstZero(2);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstZero(2);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstZero(2);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstZero(2);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstZero(2);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstZero(2);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.Equal(1, byteValue);
            Assert.Equal(1, decimalValue);
            Assert.Equal(1, doubleValue);
            Assert.Equal(1, floatValue);
            Assert.Equal(1, intValue);
            Assert.Equal(1, longValue);
            Assert.Equal(1, sbyteValue);
            Assert.Equal(1, shortValue);
            Assert.Equal(1u, uintValue);
            Assert.Equal(1ul, ulongValue);
            Assert.Equal(1, ushortValue);
        }

        #endregion

        #region AgainstNotInRange

        [Fact]
        public void AgainstNotInRange_NotInRangeCheckByContainer_Modified()
        {
            // Arrange
            byte byteValue = 10;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal decimalValue = 10;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = 10;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = 10;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = 10;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = 10;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = 10;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = 10;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            uint uintValue = 10;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong ulongValue = 10;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort ushortValue = 10;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNotInRange(0, 9, 0);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstNotInRange(0, 9, 0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNotInRange(0, 9, 0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNotInRange(0, 9, 0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNotInRange(0, 9, 0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNotInRange(0, 9, 0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNotInRange(0, 9, 0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNotInRange(0, 9, 0);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstNotInRange(0, 9, 0);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstNotInRange(0, 9, 0);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstNotInRange(0, 9, 0);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.NotInRange(byteInitialValue, 0, 9);
            Assert.Equal(0, byteValue);

            Assert.NotInRange(decimalInitialValue, 0, 9);
            Assert.Equal(0, decimalValue);

            Assert.NotInRange(doubleInitialValue, 0, 9);
            Assert.Equal(0, doubleValue);

            Assert.NotInRange(floatInitialValue, 0, 9);
            Assert.Equal(0, floatValue);

            Assert.NotInRange(intInitialValue, 0, 9);
            Assert.Equal(0, intValue);

            Assert.NotInRange(longInitialValue, 0, 9);
            Assert.Equal(0, longValue);

            Assert.NotInRange(sbyteInitialValue, 0, 9);
            Assert.Equal(0, sbyteValue);

            Assert.NotInRange(shortInitialValue, 0, 9);
            Assert.Equal(0, shortValue);

            Assert.NotInRange(uintInitialValue, 0u, 9u);
            Assert.Equal(0u, uintValue);

            Assert.NotInRange(ulongInitialValue, 0ul, 9ul);
            Assert.Equal(0ul, ulongValue);

            Assert.NotInRange(ushortInitialValue, 0, 9);
            Assert.Equal(0, ushortValue);
        }

        [Fact]
        public void AgainstNotInRange_InRangeCheckByContainer_NotModified()
        {
            // Arrange
            byte byteValue = 10;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal decimalValue = 10;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = 10;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = 10;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = 10;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = 10;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = 10;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = 10;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            uint uintValue = 10;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong ulongValue = 10;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort ushortValue = 10;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            byteValue = byteContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            decimalValue = decimalContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            doubleValue = doubleContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            floatValue = floatContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            intValue = intContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            longValue = longContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            sbyteValue = sbyteContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            shortValue = shortContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            uintValue = uintContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            ulongValue = ulongContainer.Value;

            byteContainer.SafeAgainstNotInRange(0, 10, 0);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.InRange(byteInitialValue, 0, 10);
            Assert.Equal(10, byteValue);

            Assert.InRange(decimalInitialValue, 0, 10);
            Assert.Equal(10, decimalValue);

            Assert.InRange(doubleInitialValue, 0, 10);
            Assert.Equal(10, doubleValue);

            Assert.InRange(floatInitialValue, 0, 10);
            Assert.Equal(10, floatValue);

            Assert.InRange(intInitialValue, 0, 10);
            Assert.Equal(10, intValue);

            Assert.InRange(longInitialValue, 0, 10);
            Assert.Equal(10, longValue);

            Assert.InRange(sbyteInitialValue, 0, 10);
            Assert.Equal(10, sbyteValue);

            Assert.InRange(shortInitialValue, 0, 10);
            Assert.Equal(10, shortValue);

            Assert.InRange(uintInitialValue, 0u, 10u);
            Assert.Equal(10u, uintValue);

            Assert.InRange(ulongInitialValue, 0ul, 10ul);
            Assert.Equal(10ul, ulongValue);

            Assert.InRange(ushortInitialValue, 0, 10);
            Assert.Equal(10, ushortValue);
        }

        #endregion

        #region AgainstNullOrZero

        [Fact]
        public void AgainstNullOrZero_ZeroCheckByContainer_Modified()
        {
            // Arrange
            byte? byteValue = null;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

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

            uint? uintValue = null;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong? ulongValue = null;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort? ushortValue = null;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNullOrZero(1);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstNullOrZero(1);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrZero(1);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrZero(1);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrZero(1);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrZero(1);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrZero(1);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrZero(1);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstNullOrZero(1);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstNullOrZero(1);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstNullOrZero(1);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.Null(byteInitialValue);
            Assert.Equal((byte)1, byteValue);

            Assert.Null(decimalInitialValue);
            Assert.Equal(1, decimalValue);

            Assert.Null(doubleInitialValue);
            Assert.Equal(1, doubleValue);

            Assert.Null(floatInitialValue);
            Assert.Equal(1, floatValue);

            Assert.Null(intInitialValue);
            Assert.Equal(1, intValue);

            Assert.Null(longInitialValue);
            Assert.Equal(1, longValue);

            Assert.Null(sbyteInitialValue);
            Assert.Equal((sbyte)1, sbyteValue);

            Assert.Null(shortInitialValue);
            Assert.Equal((short)1, shortValue);

            Assert.Null(uintInitialValue);
            Assert.Equal(1u, uintValue);

            Assert.Null(ulongInitialValue);
            Assert.Equal(1ul, ulongValue);

            Assert.Null(ushortInitialValue);
            Assert.Equal((ushort)1, ushortValue);
        }

        [Fact]
        public void AgainstNullOrZero_NotZeroCheckByContainer_NotModified()
        {
            // Arrange
            byte byteValue = 1;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal decimalValue = 1;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double doubleValue = 1;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float floatValue = 1;
            var floatContainer = SafeContainer.Create(floatValue);

            int intValue = 1;
            var intContainer = SafeContainer.Create(intValue);

            long longValue = 1;
            var longContainer = SafeContainer.Create(longValue);

            sbyte sbyteValue = 1;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short shortValue = 1;
            var shortContainer = SafeContainer.Create(shortValue);

            uint uintValue = 1;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong ulongValue = 1;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort ushortValue = 1;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstZero(2);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstZero(2);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstZero(2);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstZero(2);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstZero(2);
            intValue = intContainer.Value;

            longContainer.SafeAgainstZero(2);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstZero(2);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstZero(2);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstZero(2);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstZero(2);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstZero(2);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.Equal(1, byteValue);
            Assert.Equal(1, decimalValue);
            Assert.Equal(1, doubleValue);
            Assert.Equal(1, floatValue);
            Assert.Equal(1, intValue);
            Assert.Equal(1, longValue);
            Assert.Equal(1, sbyteValue);
            Assert.Equal(1, shortValue);
            Assert.Equal(1u, uintValue);
            Assert.Equal(1ul, ulongValue);
            Assert.Equal(1, ushortValue);
        }

        [Fact]
        public void AgainstNullOrZero_NullCheckByContainer_Modified()
        {
            // Arrange
            byte? byteValue = null;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal? decimalValue = null;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double? doubleValue = null;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float? floatValue = null;
            var floatContainer = SafeContainer.Create(floatValue);

            int? intValue = null;
            var intContainer = SafeContainer.Create(intValue);

            long? longValue = null;
            var longContainer = SafeContainer.Create(longValue);

            sbyte? sbyteValue = null;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short? shortValue = null;
            var shortContainer = SafeContainer.Create(shortValue);

            uint? uintValue = null;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong? ulongValue = null;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort? ushortValue = null;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNullOrZero(2);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstNullOrZero(2);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrZero(2);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrZero(2);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrZero(2);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrZero(2);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrZero(2);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrZero(2);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstNullOrZero(2);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstNullOrZero(2);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstNullOrZero(2);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.Equal((byte)2, byteValue);
            Assert.Equal(2, decimalValue);
            Assert.Equal(2, doubleValue);
            Assert.Equal(2, floatValue);
            Assert.Equal(2, intValue);
            Assert.Equal(2, longValue);
            Assert.Equal((sbyte)2, sbyteValue);
            Assert.Equal((short)2, shortValue);
            Assert.Equal(2u, uintValue);
            Assert.Equal(2ul, ulongValue);
            Assert.Equal((ushort)2, ushortValue);
        }

        #endregion

        #region AgainstNullOrNotInRange

        [Fact]
        public void AgainstNullOrNotInRange_NotInRangeCheckByContainer_Modified()
        {
            // Arrange
            byte? byteValue = 10;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal? decimalValue = 10;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double? doubleValue = 10;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float? floatValue = 10;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int? intValue = 10;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long? longValue = 10;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte? sbyteValue = 10;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short? shortValue = 10;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            uint? uintValue = 10;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong? ulongValue = 10;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort? ushortValue = 10;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstNullOrNotInRange(0, 9, 0);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.NotInRange((byte)byteInitialValue, 0, 9);
            Assert.Equal((byte)0, byteValue);

            Assert.NotInRange((decimal)decimalInitialValue, 0, 9);
            Assert.Equal(0, decimalValue);

            Assert.NotInRange((double)doubleInitialValue, 0, 9);
            Assert.Equal(0, doubleValue);

            Assert.NotInRange((float)floatInitialValue, 0, 9);
            Assert.Equal(0, floatValue);

            Assert.NotInRange((int)intInitialValue, 0, 9);
            Assert.Equal(0, intValue);

            Assert.NotInRange((long)longInitialValue, 0, 9);
            Assert.Equal(0, longValue);

            Assert.NotInRange((sbyte)sbyteInitialValue, 0, 9);
            Assert.Equal((sbyte)0, sbyteValue);

            Assert.NotInRange((short)shortInitialValue, 0, 9);
            Assert.Equal((short)0, shortValue);

            Assert.NotInRange((uint)uintInitialValue, 0u, 9u);
            Assert.Equal(0u, uintValue);

            Assert.NotInRange((ulong)ulongInitialValue, 0ul, 9ul);
            Assert.Equal(0ul, ulongValue);

            Assert.NotInRange((ushort)ushortInitialValue, 0, 9);
            Assert.Equal((ushort)0, ushortValue);
        }

        [Fact]
        public void AgainstNullOrNotInRange_InRangeCheckByContainer_NotModified()
        {
            // Arrange
            byte? byteValue = 10;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

            decimal? decimalValue = 10;
            var decimalInitialValue = decimalValue;
            var decimalContainer = SafeContainer.Create(decimalValue);

            double? doubleValue = 10;
            var doubleInitialValue = doubleValue;
            var doubleContainer = SafeContainer.Create(doubleValue);

            float? floatValue = 10;
            var floatInitialValue = floatValue;
            var floatContainer = SafeContainer.Create(floatValue);

            int? intValue = 10;
            var intInitialValue = intValue;
            var intContainer = SafeContainer.Create(intValue);

            long? longValue = 10;
            var longInitialValue = longValue;
            var longContainer = SafeContainer.Create(longValue);

            sbyte? sbyteValue = 10;
            var sbyteInitialValue = sbyteValue;
            var sbyteContainer = SafeContainer.Create(sbyteValue);

            short? shortValue = 10;
            var shortInitialValue = shortValue;
            var shortContainer = SafeContainer.Create(shortValue);

            uint? uintValue = 10;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong? ulongValue = 10;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort? ushortValue = 10;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.InRange((byte)byteInitialValue, 0, 10);
            Assert.Equal((byte)10, byteValue);

            Assert.InRange((decimal)decimalInitialValue, 0, 10);
            Assert.Equal(10, decimalValue);

            Assert.InRange((double)doubleInitialValue, 0, 10);
            Assert.Equal(10, doubleValue);

            Assert.InRange((float)floatInitialValue, 0, 10);
            Assert.Equal(10, floatValue);

            Assert.InRange((int)intInitialValue, 0, 10);
            Assert.Equal(10, intValue);

            Assert.InRange((long)longInitialValue, 0, 10);
            Assert.Equal(10, longValue);

            Assert.InRange((sbyte)sbyteInitialValue, 0, 10);
            Assert.Equal((sbyte)10, sbyteValue);

            Assert.InRange((short)shortInitialValue, 0, 10);
            Assert.Equal((short)10, shortValue);

            Assert.InRange((uint)uintInitialValue, 0u, 10u);
            Assert.Equal(10u, uintValue);

            Assert.InRange((ulong)ulongInitialValue, 0ul, 10ul);
            Assert.Equal(10ul, ulongValue);

            Assert.InRange((ushort)ushortInitialValue, 0, 10);
            Assert.Equal((ushort)10, ushortValue);
        }

        [Fact]
        public void AgainstNullOrNotInRange_NullCheckByContainer_Modified()
        {
            // Arrange
            byte? byteValue = null;
            var byteInitialValue = byteValue;
            var byteContainer = SafeContainer.Create(byteValue);

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

            uint? uintValue = null;
            var uintInitialValue = uintValue;
            var uintContainer = SafeContainer.Create(uintValue);

            ulong? ulongValue = null;
            var ulongInitialValue = ulongValue;
            var ulongContainer = SafeContainer.Create(ulongValue);

            ushort? ushortValue = null;
            var ushortInitialValue = ushortValue;
            var ushortContainer = SafeContainer.Create(ushortValue);

            // Act
            byteContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            byteValue = byteContainer.Value;

            decimalContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            decimalValue = decimalContainer.Value;

            doubleContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            doubleValue = doubleContainer.Value;

            floatContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            floatValue = floatContainer.Value;

            intContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            intValue = intContainer.Value;

            longContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            longValue = longContainer.Value;

            sbyteContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            sbyteValue = sbyteContainer.Value;

            shortContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            shortValue = shortContainer.Value;

            uintContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            uintValue = uintContainer.Value;

            ulongContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            ulongValue = ulongContainer.Value;

            ushortContainer.SafeAgainstNullOrNotInRange(0, 10, 0);
            ushortValue = ushortContainer.Value;

            // Assert
            Assert.Null(byteInitialValue);
            Assert.Equal((byte)0, byteValue);

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

            Assert.Null(uintInitialValue);
            Assert.Equal(0u, uintValue);

            Assert.Null(ulongInitialValue);
            Assert.Equal(0ul, ulongValue);

            Assert.Null(ushortInitialValue);
            Assert.Equal((ushort)0, ushortValue);
        }

        #endregion
    }
}
