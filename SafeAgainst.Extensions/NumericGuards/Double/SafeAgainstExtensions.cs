namespace SafeAgainst.Extensions.NumericGuards.Double
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'double' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the double within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The double value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated double is zero.</param>
        /// <returns>The current container of type 'SafeContainer<double>' after verification.</returns>
        public static SafeContainer<double> SafeAgainstZero(this SafeContainer<double> container, double defaultValue)
        {
            SafeAgainst.NumericGuards.Double.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the double within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The double value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated double is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<double>' after verification.</returns>
        public static SafeContainer<double> SafeAgainstNotInRange(this SafeContainer<double> container, double minValue, double maxValue, double defaultValue)
        {
            SafeAgainst.NumericGuards.Double.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the double within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The double value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated double is negative.</param>
        /// <returns>The current container of type 'SafeContainer<double>' after verification.</returns>
        public static SafeContainer<double> SafeAgainstNegative(this SafeContainer<double> container, double defaultValue)
        {
            SafeAgainst.NumericGuards.Double.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable double within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable double value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable double is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<double?>' after verification.</returns>
        public static SafeContainer<double?> SafeAgainstNullOrZero(this SafeContainer<double?> container, double defaultValue)
        {
            SafeAgainst.NumericGuards.Double.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable double within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable double value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable double is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<double?>' after verification.</returns>
        public static SafeContainer<double?> SafeAgainstNullOrNotInRange(this SafeContainer<double?> container, double minValue, double maxValue, double defaultValue)
        {
            SafeAgainst.NumericGuards.Double.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable double within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable double value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable double is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<double?>' after verification.</returns>
        public static SafeContainer<double?> SafeAgainstNullOrNegative(this SafeContainer<double?> container, double defaultValue)
        {
            SafeAgainst.NumericGuards.Double.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
