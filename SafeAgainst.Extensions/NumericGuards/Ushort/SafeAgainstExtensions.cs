namespace SafeAgainst.Extensions.NumericGuards.Ushort
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'ushort' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the ushort within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The ushort value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated ushort is zero.</param>
        /// <returns>The current container of type 'SafeContainer<ushort>' after verification.</returns>
        public static SafeContainer<ushort> SafeAgainstZero(this SafeContainer<ushort> container, ushort defaultValue)
        {
            SafeAgainst.NumericGuards.Ushort.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the ushort within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The ushort value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated ushort is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<ushort>' after verification.</returns>
        public static SafeContainer<ushort> SafeAgainstNotInRange(this SafeContainer<ushort> container, ushort minValue, ushort maxValue, ushort defaultValue)
        {
            SafeAgainst.NumericGuards.Ushort.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable ushort within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable ushort value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable ushort is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<ushort?>' after verification.</returns>
        public static SafeContainer<ushort?> SafeAgainstNullOrZero(this SafeContainer<ushort?> container, ushort defaultValue)
        {
            SafeAgainst.NumericGuards.Ushort.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable ushort within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable ushort value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable ushort is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<ushort?>' after verification.</returns>
        public static SafeContainer<ushort?> SafeAgainstNullOrNotInRange(this SafeContainer<ushort?> container, ushort minValue, ushort maxValue, ushort defaultValue)
        {
            SafeAgainst.NumericGuards.Ushort.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }
    }

}
