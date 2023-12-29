namespace SafeAgainst.Extensions.NumericGuards.Decimal
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'decimal' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the decimal within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The decimal value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated decimal is zero.</param>
        /// <returns>The current container of type 'SafeContainer<decimal>' after verification.</returns>
        public static SafeContainer<decimal> SafeAgainstZero(this SafeContainer<decimal> container, decimal defaultValue)
        {
            SafeAgainst.NumericGuards.Decimal.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the decimal within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The decimal value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated decimal is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<decimal>' after verification.</returns>
        public static SafeContainer<decimal> SafeAgainstNotInRange(this SafeContainer<decimal> container, decimal minValue, decimal maxValue, decimal defaultValue)
        {
            SafeAgainst.NumericGuards.Decimal.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the decimal within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The decimal value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated decimal is negative.</param>
        /// <returns>The current container of type 'SafeContainer<decimal>' after verification.</returns>
        public static SafeContainer<decimal> SafeAgainstNegative(this SafeContainer<decimal> container, decimal defaultValue)
        {
            SafeAgainst.NumericGuards.Decimal.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable decimal within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable decimal value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable decimal is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<decimal?>' after verification.</returns>
        public static SafeContainer<decimal?> SafeAgainstNullOrZero(this SafeContainer<decimal?> container, decimal defaultValue)
        {
            SafeAgainst.NumericGuards.Decimal.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable decimal within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable decimal value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable decimal is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<decimal?>' after verification.</returns>
        public static SafeContainer<decimal?> SafeAgainstNullOrNotInRange(this SafeContainer<decimal?> container, decimal minValue, decimal maxValue, decimal defaultValue)
        {
            SafeAgainst.NumericGuards.Decimal.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable decimal within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable decimal value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable decimal is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<decimal?>' after verification.</returns>
        public static SafeContainer<decimal?> SafeAgainstNullOrNegative(this SafeContainer<decimal?> container, decimal defaultValue)
        {
            SafeAgainst.NumericGuards.Decimal.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
