namespace SafeAgainst.Extensions.NumericGuards.Ulong
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'ulong' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the ulong within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The ulong value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated ulong is zero.</param>
        /// <returns>The current container of type 'SafeContainer<ulong>' after verification.</returns>
        public static SafeContainer<ulong> SafeAgainstZero(this SafeContainer<ulong> container, ulong defaultValue)
        {
            SafeAgainst.NumericGuards.Ulong.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the ulong within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The ulong value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated ulong is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<ulong>' after verification.</returns>
        public static SafeContainer<ulong> SafeAgainstNotInRange(this SafeContainer<ulong> container, ulong minValue, ulong maxValue, ulong defaultValue)
        {
            SafeAgainst.NumericGuards.Ulong.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable ulong within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable ulong value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable ulong is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<ulong?>' after verification.</returns>
        public static SafeContainer<ulong?> SafeAgainstNullOrZero(this SafeContainer<ulong?> container, ulong defaultValue)
        {
            SafeAgainst.NumericGuards.Ulong.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable ulong within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable ulong value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable ulong is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<ulong?>' after verification.</returns>
        public static SafeContainer<ulong?> SafeAgainstNullOrNotInRange(this SafeContainer<ulong?> container, ulong minValue, ulong maxValue, ulong defaultValue)
        {
            SafeAgainst.NumericGuards.Ulong.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }
    }

}
