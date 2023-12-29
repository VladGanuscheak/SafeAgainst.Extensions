namespace SafeAgainst.Extensions.NumericGuards.Int
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'int' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the int within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The int value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated int is zero.</param>
        /// <returns>The current container of type 'SafeContainer<int>' after verification.</returns>
        public static SafeContainer<int> SafeAgainstZero(this SafeContainer<int> container, int defaultValue)
        {
            SafeAgainst.NumericGuards.Int.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the int within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The int value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated int is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<int>' after verification.</returns>
        public static SafeContainer<int> SafeAgainstNotInRange(this SafeContainer<int> container, int minValue, int maxValue, int defaultValue)
        {
            SafeAgainst.NumericGuards.Int.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the int within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The int value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated int is negative.</param>
        /// <returns>The current container of type 'SafeContainer<int>' after verification.</returns>
        public static SafeContainer<int> SafeAgainstNegative(this SafeContainer<int> container, int defaultValue)
        {
            SafeAgainst.NumericGuards.Int.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable int within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable int value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable int is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<int?>' after verification.</returns>
        public static SafeContainer<int?> SafeAgainstNullOrZero(this SafeContainer<int?> container, int defaultValue)
        {
            SafeAgainst.NumericGuards.Int.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable int within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable int value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable int is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<int?>' after verification.</returns>
        public static SafeContainer<int?> SafeAgainstNullOrNotInRange(this SafeContainer<int?> container, int minValue, int maxValue, int defaultValue)
        {
            SafeAgainst.NumericGuards.Int.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable int within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable int value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable int is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<int?>' after verification.</returns>
        public static SafeContainer<int?> SafeAgainstNullOrNegative(this SafeContainer<int?> container, int defaultValue)
        {
            SafeAgainst.NumericGuards.Int.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
