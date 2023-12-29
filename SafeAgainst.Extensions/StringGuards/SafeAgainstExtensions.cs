namespace SafeAgainst.Extensions.StringGuards
{
    /// <summary>
    ///     Provides extension methods for the basic guard clauses over 'string' type encapsulated into 'SafeContainer'.
    /// </summary>
    public static class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the string within the current container with a predefined value if it is NULL.
        /// Example: container.SafeAgainstNull(defaultValue);
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated string is NULL.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstNull(this SafeContainer<string> container, string defaultValue)
        {
            SafeAgainst.StringGuards.Safe.AgainstNull(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the string within the current container with a predefined value if it is empty.
        /// Example: container.SafeAgainstEmpty(defaultValue);
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated string is empty.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstEmpty(this SafeContainer<string> container, string defaultValue)
        {
            SafeAgainst.StringGuards.Safe.AgainstEmpty(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the string within the current container with a predefined value if it is null or empty.
        /// Example: container.SafeAgainstNullOrEmpty(defaultValue);
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated string is null or empty.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstNullOrEmpty(this SafeContainer<string> container, string defaultValue)
        {
            SafeAgainst.StringGuards.Safe.AgainstNullOrEmpty(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the string within the current container with a predefined value if it is null or white space.
        /// Example: container.SafeAgainstNullOrWhiteSpace(defaultValue);
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated string is null or white space.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstNullOrWhiteSpace(this SafeContainer<string> container, string defaultValue)
        {
            SafeAgainst.StringGuards.Safe.AgainstNullOrWhiteSpace(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the string within the current container with a predefined value if it contains leading white spaces.
        /// Example: container.SafeAgainstLeadingWhiteSpaces();
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstLeadingWhiteSpaces(this SafeContainer<string> container)
        {
            SafeAgainst.StringGuards.Safe.AgainstLeadingWhiteSpaces(container);
            return container;
        }

        /// <summary>
        /// Replaces the string within the current container with a predefined value if it contains trailing white spaces.
        /// Example: container.SafeAgainstTrailingWhiteSpaces();
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstTrailingWhiteSpaces(this SafeContainer<string> container)
        {
            SafeAgainst.StringGuards.Safe.AgainstTrailingWhiteSpaces(container);
            return container;
        }

        /// <summary>
        /// Replaces the string within the current container with a predefined value if it contains leading or trailing white spaces.
        /// Example: container.SafeAgainstLeadingOrTrailingWhiteSpaces();
        /// </summary>
        /// <param name="container">Required. The string value stored within the current container.</param>
        /// <returns>The current container of type 'SafeContainer<string>' after verification.</returns>
        public static SafeContainer<string> SafeAgainstLeadingOrTrailingWhiteSpaces(this SafeContainer<string> container)
        {
            SafeAgainst.StringGuards.Safe.AgainstLeadingOrTrailingWhiteSpaces(container);
            return container;
        }
    }
}
