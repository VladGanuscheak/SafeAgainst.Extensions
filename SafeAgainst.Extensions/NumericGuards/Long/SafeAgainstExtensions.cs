namespace SafeAgainst.Extensions.NumericGuards.Long
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'long' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the long within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The long value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated long is zero.</param>
        /// <returns>The current container of type 'SafeContainer<long>' after verification.</returns>
        public static SafeContainer<long> SafeAgainstZero(this SafeContainer<long> container, long defaultValue)
        {
            SafeAgainst.NumericGuards.Long.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the long within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The long value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated long is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<long>' after verification.</returns>
        public static SafeContainer<long> SafeAgainstNotInRange(this SafeContainer<long> container, long minValue, long maxValue, long defaultValue)
        {
            SafeAgainst.NumericGuards.Long.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the long within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The long value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated long is negative.</param>
        /// <returns>The current container of type 'SafeContainer<long>' after verification.</returns>
        public static SafeContainer<long> SafeAgainstNegative(this SafeContainer<long> container, long defaultValue)
        {
            SafeAgainst.NumericGuards.Long.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable long within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable long value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable long is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<long?>' after verification.</returns>
        public static SafeContainer<long?> SafeAgainstNullOrZero(this SafeContainer<long?> container, long defaultValue)
        {
            SafeAgainst.NumericGuards.Long.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable long within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable long value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable long is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<long?>' after verification.</returns>
        public static SafeContainer<long?> SafeAgainstNullOrNotInRange(this SafeContainer<long?> container, long minValue, long maxValue, long defaultValue)
        {
            SafeAgainst.NumericGuards.Long.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable long within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable long value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable long is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<long?>' after verification.</returns>
        public static SafeContainer<long?> SafeAgainstNullOrNegative(this SafeContainer<long?> container, long defaultValue)
        {
            SafeAgainst.NumericGuards.Long.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
