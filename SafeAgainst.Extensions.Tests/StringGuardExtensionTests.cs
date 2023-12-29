using SafeAgainst.Extensions.StringGuards;
using Xunit;

namespace SafeAgainst.Extensions.Tests
{
    public class StringGuardExtensionTests
    {
        #region AgainstNull

        [Fact]
        public void AgainstNull_NullCheckByContainer_Modified()
        {
            // Arrange
            string value = null;
            var defaultValue = "The message has not been specified";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNull(defaultValue);
            value = container.Value;

            // Assert
            Assert.Equal(value, defaultValue);
        }

        [Fact]
        public void AgainstNull_NotNullCheckByContainer_NotModified()
        {
            // Arrange
            var value = "Hi, world!";
            var initialValue = value;
            var defaultValue = "The message has not been specified";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNull(defaultValue);
            value = container.Value;

            // Assert
            Assert.NotEqual(value, defaultValue);
            Assert.Equal(initialValue, value);
        }

        #endregion

        #region AgainstEmpty

        [Fact]
        public void AgainstEmpty_EmptyCheckByContainer_Modified()
        {
            // Arrange
            var value = string.Empty;
            var defaultValue = "The message has not been provided";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstEmpty(defaultValue);
            value = container.Value;

            // Assert
            Assert.NotEqual(string.Empty, value);
            Assert.Equal(defaultValue, value);
        }

        [Fact]
        public void AgainstEmpty_NotEmptyCheckByContainer_NotModified()
        {
            // Arrange
            var value = "Some value here";
            var initialValue = value;
            var defaultValue = "The message has not been provided";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstEmpty(defaultValue);
            value = container.Value;

            // Assert
            Assert.NotEqual(string.Empty, value);
            Assert.Equal(initialValue, value);
        }

        #endregion

        #region AgainstNullOrEmpty

        [Fact]
        public void AgainstNullOrEmpty_NullCheckByContainer_Modified()
        {
            // Arrange
            string value = null;
            var defaultMessage = "The message has not been provided!";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrEmpty(defaultMessage);
            value = container.Value;

            // Assert
            Assert.NotNull(value);
            Assert.Equal(defaultMessage, value);
        }

        [Fact]
        public void AgainstNullOrEmpty_EmptyCheckByContainer_Modified()
        {
            // Arrange
            var value = string.Empty;
            var defaultMessage = "This is the default message";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrEmpty(defaultMessage);
            value = container.Value;

            // Assert
            Assert.NotEqual(string.Empty, value);
            Assert.Equal(defaultMessage, value);
        }

        [Fact]
        public void AgainstNullOrEmpty_NotNullNotEmptyCheckByContainer_NotModified()
        {
            // Arrange
            var value = "Some value here";
            var initialValue = value;
            var defaultMessage = "The message has not to change";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrEmpty(defaultMessage);
            value = container.Value;

            // Assert
            Assert.Equal(initialValue, value);
        }

        #endregion

        #region AgainstNullOrWhiteSpace

        [Fact]
        public void AgainstNullOrWhiteSpace_NullCheckByContainer_Modified()
        {
            // Arrange
            string value = null;
            var defaultValue = "The default message";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrWhiteSpace(defaultValue);
            value = container.Value;

            // Assert
            Assert.NotNull(value);
            Assert.Equal(defaultValue, value);
        }

        [Fact]
        public void AgainstNullOrWhiteSpace_WhiteSpacesCheckByContainer_Modified()
        {
            // Arrange
            string value = "     ";
            var defaultValue = "The default message";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrWhiteSpace(defaultValue);
            value = container.Value;

            // Assert
            Assert.NotNull(value);
            Assert.Equal(defaultValue, value);
        }

        [Fact]
        public void AgainstNullOrWhiteSpace_ValidCheckByContainer_NotModified()
        {
            // Arrange
            var value = "Some value here";
            var initialValue = value;
            var defaultValue = "Default value";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstNullOrWhiteSpace(defaultValue);
            value = container.Value;

            // Assert
            Assert.NotEqual(defaultValue, value);
            Assert.Equal(initialValue, value);
        }

        #endregion

        #region AgainstLeadingWhitespaces

        [Fact]
        public void AgainstLeadingWhitespaces_LeadingWhitespacesCheckByContainer_Modified()
        {
            // Arrange 
            var expectedValue = "Text after leading whitespaces";
            var value = $"   {expectedValue}";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void AgainstLeadingWhitespaces_NullCheckByContainer_NotModified()
        {
            // Arrange
            string value = null;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Null(value);
        }

        [Fact]
        public void AgainstLeadingWhitespaces_EmptyCheckByContainer_NotModified()
        {
            // Arrange
            var value = string.Empty;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(string.Empty, value);
        }

        [Fact]
        public void AgainstLeadingWhitespaces_ValidCheckByContainer_NotModified()
        {
            // Arrange
            const string initialValue = "Without leading whitespaces";
            var value = initialValue;

            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(initialValue, value);
        }

        #endregion

        #region AgainstTrailingWhitespaces

        [Fact]
        public void AgainstTrailingWhitespaces_TrailingWhitespacesCheckByContainer_Modified()
        {
            // Arrange 
            var expectedValue = "Text after trailing whitespaces";
            var value = $"{expectedValue}   ";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void AgainstTrailingWhitespaces_NullCheckByContainer_NotModified()
        {
            // Arrange
            string value = null;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Null(value);
        }

        [Fact]
        public void AgainstTrailingWhitespaces_EmptyCheckByContainer_NotModified()
        {
            // Arrange
            var value = string.Empty;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(string.Empty, value);
        }

        [Fact]
        public void AgainstTrailingWhitespaces_ValidCheckByContainer_NotModified()
        {
            // Arrange
            const string initialValue = "Without leading whitespaces";
            var value = initialValue;

            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(initialValue, value);
        }

        #endregion

        #region AgainstLeadingOrTrailingWhitespaces

        [Fact]
        public void AgainstLeadingOrTrailingWhitespaces_ValidCheckByContainer_NotModified()
        {
            // Arrange 
            const string expectedValue = "Valid example";
            var value = $"{expectedValue}";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingOrTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void AgainstLeadingOrTrailingWhitespaces_LeadingWhitespacesCheckByContainer_Modified()
        {
            // Arrange
            var expectedValue = "Without leading or trailing whitespaces";
            var value = $"    {expectedValue}";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingOrTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void AgainstLeadingOrTrailingWhitespaces_TrailingWhitespacesCheckByContainer_Modified()
        {
            // Arrange
            var expectedValue = "Without leading or trailing whitespaces";
            var value = $"{expectedValue}   ";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingOrTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void AgainstLeadingOrTrailingWhitespaces_LeadingAndTrailingWhitespacesCheckByContainer_Modified()
        {
            // Arrange
            var expectedValue = "Without leading or trailing whitespaces";
            var value = $"   {expectedValue}   ";
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingOrTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void AgainstLeadingOrTrailingWhitespaces_NullCheckByContainer_NotModified()
        {
            // Arrange;
            string value = null;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingOrTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Null(value);
        }

        [Fact]
        public void AgainstLeadingOrTrailingWhitespaces_EmptyCheckByContainer_NotModified()
        {
            // Arrange;
            var value = string.Empty;
            var container = SafeContainer.Create(value);

            // Act
            container.SafeAgainstLeadingOrTrailingWhiteSpaces();
            value = container.Value;

            // Assert
            Assert.Equal(string.Empty, value);
        }

        #endregion
    }
}
