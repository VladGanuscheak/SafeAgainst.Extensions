namespace SafeAgainst.Extensions.NumericGuards.Uint
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'uint' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the uint within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The uint value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated uint is zero.</param>
        /// <returns>The current container of type 'SafeContainer<uint>' after verification.</returns>
        public static SafeContainer<uint> SafeAgainstZero(this SafeContainer<uint> container, uint defaultValue)
        {
            SafeAgainst.NumericGuards.Uint.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the uint within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The uint value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated uint is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<uint>' after verification.</returns>
        public static SafeContainer<uint> SafeAgainstNotInRange(this SafeContainer<uint> container, uint minValue, uint maxValue, uint defaultValue)
        {
            SafeAgainst.NumericGuards.Uint.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable uint within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable uint value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable uint is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<uint?>' after verification.</returns>
        public static SafeContainer<uint?> SafeAgainstNullOrZero(this SafeContainer<uint?> container, uint defaultValue)
        {
            SafeAgainst.NumericGuards.Uint.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable uint within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable uint value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable uint is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<uint?>' after verification.</returns>
        public static SafeContainer<uint?> SafeAgainstNullOrNotInRange(this SafeContainer<uint?> container, uint minValue, uint maxValue, uint defaultValue)
        {
            SafeAgainst.NumericGuards.Uint.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }
    }

}
