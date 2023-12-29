namespace SafeAgainst.Extensions.NumericGuards.Short
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'short' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the short within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The short value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated short is zero.</param>
        /// <returns>The current container of type 'SafeContainer<short>' after verification.</returns>
        public static SafeContainer<short> SafeAgainstZero(this SafeContainer<short> container, short defaultValue)
        {
            SafeAgainst.NumericGuards.Short.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the short within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The short value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated short is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<short>' after verification.</returns>
        public static SafeContainer<short> SafeAgainstNotInRange(this SafeContainer<short> container, short minValue, short maxValue, short defaultValue)
        {
            SafeAgainst.NumericGuards.Short.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the short within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The short value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated short is negative.</param>
        /// <returns>The current container of type 'SafeContainer<short>' after verification.</returns>
        public static SafeContainer<short> SafeAgainstNegative(this SafeContainer<short> container, short defaultValue)
        {
            SafeAgainst.NumericGuards.Short.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable short within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable short value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable short is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<short?>' after verification.</returns>
        public static SafeContainer<short?> SafeAgainstNullOrZero(this SafeContainer<short?> container, short defaultValue)
        {
            SafeAgainst.NumericGuards.Short.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable short within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable short value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable short is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<short?>' after verification.</returns>
        public static SafeContainer<short?> SafeAgainstNullOrNotInRange(this SafeContainer<short?> container, short minValue, short maxValue, short defaultValue)
        {
            SafeAgainst.NumericGuards.Short.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable short within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable short value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable short is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<short?>' after verification.</returns>
        public static SafeContainer<short?> SafeAgainstNullOrNegative(this SafeContainer<short?> container, short defaultValue)
        {
            SafeAgainst.NumericGuards.Short.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
