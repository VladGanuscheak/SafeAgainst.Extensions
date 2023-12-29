namespace SafeAgainst.Extensions.NumericGuards.Float
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'float' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the float within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The float value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated float is zero.</param>
        /// <returns>The current container of type 'SafeContainer<float>' after verification.</returns>
        public static SafeContainer<float> SafeAgainstZero(this SafeContainer<float> container, float defaultValue)
        {
            SafeAgainst.NumericGuards.Float.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the float within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The float value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated float is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<float>' after verification.</returns>
        public static SafeContainer<float> SafeAgainstNotInRange(this SafeContainer<float> container, float minValue, float maxValue, float defaultValue)
        {
            SafeAgainst.NumericGuards.Float.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the float within the current container with a predefined value if it is negative.
        /// Example: container.SafeAgainstNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The float value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated float is negative.</param>
        /// <returns>The current container of type 'SafeContainer<float>' after verification.</returns>
        public static SafeContainer<float> SafeAgainstNegative(this SafeContainer<float> container, float defaultValue)
        {
            SafeAgainst.NumericGuards.Float.Safe.AgainstNegative(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable float within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable float value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable float is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<float?>' after verification.</returns>
        public static SafeContainer<float?> SafeAgainstNullOrZero(this SafeContainer<float?> container, float defaultValue)
        {
            SafeAgainst.NumericGuards.Float.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable float within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable float value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable float is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<float?>' after verification.</returns>
        public static SafeContainer<float?> SafeAgainstNullOrNotInRange(this SafeContainer<float?> container, float minValue, float maxValue, float defaultValue)
        {
            SafeAgainst.NumericGuards.Float.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable float within the current container with a predefined value if it is null or negative.
        /// Example: container.SafeAgainstNullOrNegative(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable float value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable float is null or negative.</param>
        /// <returns>The current container of type 'SafeContainer<float?>' after verification.</returns>
        public static SafeContainer<float?> SafeAgainstNullOrNegative(this SafeContainer<float?> container, float defaultValue)
        {
            SafeAgainst.NumericGuards.Float.Safe.AgainstNullOrNegative(container, defaultValue);
            return container;
        }
    }

}
