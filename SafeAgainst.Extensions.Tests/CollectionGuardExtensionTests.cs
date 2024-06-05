using SafeAgainst.Extensions.CollectionGuards;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class CollectionGuardExtensionTests
    {
        private readonly IEnumerable<int> DefaultEnumeration = Enumerable.Empty<int>()
            .Append(5)
            .Append(3)
            .ToList();
        private static readonly string[] defaultArrayValue = ["first", "second", "third"];

        public class UninitializedCollections<T>
        {
            public IList<T> NullList = null;
            public ICollection<T> NullCollection = null;
            public ISet<T> NullSet = null;
            public T[] NullArray = null;

            public void Initialize(IEnumerable<T> enumeration)
            {
                NullList = enumeration.ToList();
                NullCollection = enumeration.ToList();
                NullSet = new HashSet<T>(enumeration);
                NullArray = enumeration.ToArray();
            }
        }

        #region AgainstNull
        
        [Fact]
        public void AgainstNull_NullCheckedByContainer_Modified()
        {
            // Arrange
            IEnumerable<int> nullEnumerableCollection = null;
            var uninitializedCollections = new UninitializedCollections<int>();
            var container = SafeContainer.Create(nullEnumerableCollection);

            // Act
            container.SafeAgainstNull(DefaultEnumeration);
            nullEnumerableCollection = container.Value;
            uninitializedCollections.Initialize(nullEnumerableCollection);

            // Assert
            Assert.NotNull(nullEnumerableCollection);
            Assert.Equal(DefaultEnumeration, nullEnumerableCollection);

            Assert.NotNull(uninitializedCollections.NullList);
            Assert.Equal(DefaultEnumeration, uninitializedCollections.NullList.AsEnumerable());

            Assert.NotNull(uninitializedCollections.NullCollection);
            Assert.Equal(DefaultEnumeration, uninitializedCollections.NullCollection.AsEnumerable());

            Assert.NotNull(uninitializedCollections.NullSet);
            Assert.Equal(DefaultEnumeration, uninitializedCollections.NullSet.AsEnumerable());

            Assert.NotNull(uninitializedCollections.NullArray);
            Assert.Equal(DefaultEnumeration, uninitializedCollections.NullArray.AsEnumerable());
        }

        [Fact]
        public void AgainstNull_NotNullCheckedByContainer_NotModified()
        {
            // Arrange
            var emptyEnumerableCollection = Enumerable.Empty<string>();
            var container = SafeContainer.Create(emptyEnumerableCollection);

            // Act
            container.SafeAgainstNull(defaultArrayValue);
            emptyEnumerableCollection = container.Value;

            // Assert
            Assert.NotNull(emptyEnumerableCollection);
            Assert.Equal(Enumerable.Empty<string>(), emptyEnumerableCollection);
        }
        #endregion

        #region AgainstEmpty
        
        [Fact]
        public void AgainstEmpty_EmptyCheckedByContainer_Modified()
        {
            // Arrange
            var emptyCollection = Enumerable.Empty<float>();
            IEnumerable<float> defaultValue = new float[] { 1f, 34f, 52f };
            var container = SafeContainer.Create(emptyCollection);

            // Act
            container.SafeAgainstEmpty(defaultValue);
            emptyCollection = container.Value;

            // Assert
            Assert.Equal(defaultValue, emptyCollection);
        }

        [Fact]
        public void AgainstEmpty_NotEmptyCheckedByContainer_NotModified()
        {
            // Arrange
            var nonEmptyCollection = Enumerable.Empty<float>()
                .Append(1)
                .Append(2);
            IEnumerable<float> defaultValue = new float[] { 1f, 34f, 52f };
            var container = SafeContainer.Create(nonEmptyCollection);

            // Act
            container.SafeAgainstEmpty(defaultValue);
            nonEmptyCollection = container.Value;

            // Assert
            Assert.NotEmpty(defaultValue);
            Assert.NotEqual(defaultValue, nonEmptyCollection);
        }
        #endregion

        #region AgainstNullOrEmpty
        
        [Fact]
        public void AgainstNullOrEmpty_NullCheckedByContainer_Modified()
        {
            // Arrange
            IEnumerable<int> enumeration = null;
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstNullOrEmpty(DefaultEnumeration);
            enumeration = container.Value;

            // Assert
            Assert.NotNull(enumeration);
            Assert.Equal(DefaultEnumeration, enumeration);
        }

        [Fact]
        public void AgainstNullOrEmpty_EmptyCheckedByContainer_Modified()
        {
            // Arrange
            IEnumerable<int> enumeration = Enumerable.Empty<int>();
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstNullOrEmpty(DefaultEnumeration);
            enumeration = container.Value;

            // Assert
            Assert.NotEmpty(enumeration);
            Assert.Equal(DefaultEnumeration, enumeration);
        }

        [Fact]
        public void AgainstNullOrEmpty_ValidCheckedByContainer_NotModified()
        {
            // Arrange
            var enumeration = Enumerable.Empty<int>()
                .Append(1)
                .Append(2)
                .Append(3);
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstNullOrEmpty(DefaultEnumeration);
            enumeration = container.Value;

            // Assert
            Assert.NotNull(enumeration);
            Assert.NotEmpty(enumeration);
            Assert.NotEqual(DefaultEnumeration, enumeration);
        }
        #endregion

        #region AgainstNullElements
        
        [Fact]
        public void AgainstNullElements_ContainsNullElementsCheckByContainer_NoNullElements()
        {
            // Arrange
            IEnumerable<int?> enumeration = Enumerable.Empty<int?>()
                .Append(2)
                .Append(10)
                .Append(null)
                .Append(1);
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstNullElements();
            enumeration = container.Value;

            // Assert
            Assert.DoesNotContain(enumeration, x => x == null);
            Assert.Contains(enumeration, x => x != null);
            Assert.Equal(3, enumeration.ToList().Count);
        }

        [Fact]
        public void AgainstNullElements_DontContainNullElementsCheckByContainer_NoNullElements()
        {
            // Arrange
            IEnumerable<int?> enumeration = Enumerable.Empty<int?>()
                .Append(2)
                .Append(10)
                .Append(1);
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstNullElements();
            enumeration = container.Value;

            // Assert
            Assert.DoesNotContain(enumeration, x => x == null);
            Assert.Contains(enumeration, x => x != null);
            Assert.Equal(3, enumeration.ToList().Count);
        }
        #endregion

        #region AgainstDefaultElements

        [Fact]
        public void AgainstDefaultElements_ContainsEmptyElementsCheckByContainer_NoEmptyElements()
        {
            // Arrange
            IEnumerable<int> enumeration = Enumerable.Empty<int>()
                .Append(0)
                .Append(1)
                .Append(2);
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstDefaultElements();
            enumeration = container.Value;

            // Assert
            Assert.DoesNotContain(enumeration, x => x == 0);
            Assert.Equal(2, enumeration.ToList().Count);
        }

        [Fact]
        public void AgainstDefaultElements_DontContainEmptyElementsCheckByContainer_NoEmptyElements()
        {
            // Arrange
            IEnumerable<int> enumeration = Enumerable.Empty<int>()
                .Append(1)
                .Append(2);
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstDefaultElements();
            enumeration = container.Value;

            // Assert
            Assert.DoesNotContain(enumeration, x => x == 0);
            Assert.Equal(2, enumeration.ToList().Count);
        }

        #endregion

        #region AgainstValuesNotInSet 

        [Fact]
        public void AgainstValuesNotInSet_ValuesNotInSetCheckByContainer_Modified()
        {
            // Arrange
            var enumeration = Enumerable.Empty<int>()
                .Append(1)
                .Append(5)
                .Append(12);
            IEnumerable<int> allowedValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstValuesNotInSet(allowedValues);
            enumeration = container.Value;

            // Assert
            Assert.True(enumeration.All(x => allowedValues.Contains(x)));
        }

        [Fact]
        public void AgainstValuesNotInSet_ValuesInSetCheckByContainer_NotModified()
        {
            // Arrange
            var enumeration = Enumerable.Empty<int>()
                .Append(1)
                .Append(5);
            IEnumerable<int> allowedValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var container = SafeContainer.Create(enumeration);

            // Act
            container.SafeAgainstValuesNotInSet(allowedValues);
            enumeration = container.Value;

            // Assert
            Assert.True(enumeration.All(x => allowedValues.Contains(x)));
        }

        #endregion
    }
}
