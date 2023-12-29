namespace SafeAgainst.Extensions.NumericGuards.Sbyte
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'sbyte' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the sbyte within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The sbyte value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated sbyte is zero.</param>
        /// <returns>The current container of type 'SafeContainer<sbyte>' after verification.</returns>
        public static SafeContainer<sbyte> SafeAgainstZero(this SafeContainer<sbyte> container, sbyte defaultValue)
        {
            SafeAgainst.NumericGuards.Sbyte.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the sbyte within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The sbyte value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated sbyte is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<sbyte>' after verification.</returns>
        public static SafeContainer<sbyte> SafeAgainstNotInRange(this SafeContainer<sbyte> container, sbyte minValue, sbyte maxValue, sbyte defaultValue)
        {
            SafeAgainst.NumericGuards.Sbyte.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the sbyte within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The sbyte value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated sbyte is negative.</param>
        /// <returns>The current container of type 'SafeContainer<sbyte>' after verification.</returns>
        public static SafeContainer<sbyte> SafeAgainstNegative(this SafeContainer<sbyte> container, sbyte defaultValue)
        {
            SafeAgainst.NumericGuards.Sbyte.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable sbyte within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable sbyte value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable sbyte is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<sbyte?>' after verification.</returns>
        public static SafeContainer<sbyte?> SafeAgainstNullOrZero(this SafeContainer<sbyte?> container, sbyte defaultValue)
        {
            SafeAgainst.NumericGuards.Sbyte.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable sbyte within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable sbyte value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable sbyte is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<sbyte?>' after verification.</returns>
        public static SafeContainer<sbyte?> SafeAgainstNullOrNotInRange(this SafeContainer<sbyte?> container, sbyte minValue, sbyte maxValue, sbyte defaultValue)
        {
            SafeAgainst.NumericGuards.Sbyte.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable sbyte within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable sbyte value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable sbyte is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<sbyte?>' after verification.</returns>
        public static SafeContainer<sbyte?> SafeAgainstNullOrNegative(this SafeContainer<sbyte?> container, sbyte defaultValue)
        {
            SafeAgainst.NumericGuards.Sbyte.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
