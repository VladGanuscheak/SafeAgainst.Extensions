namespace SafeAgainst.Extensions.NumericGuards.Byte
{
    /// <summary>
    /// Provides extension methods for basic guard clauses over 'byte' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the byte within the current container with a predefined value if it is zero.
        /// Example: container.SafeAgainstZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The byte value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated byte is zero.</param>
        /// <returns>The current container of type 'SafeContainer<byte>' after verification.</returns>
        public static SafeContainer<byte> SafeAgainstZero(this SafeContainer<byte> container, byte defaultValue)
        {
            SafeAgainst.NumericGuards.Byte.Safe.AgainstZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the byte within the current container with a predefined value if it is not within the specified range.
        /// Example: container.SafeAgainstNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The byte value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated byte is not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<byte>' after verification.</returns>
        public static SafeContainer<byte> SafeAgainstNotInRange(this SafeContainer<byte> container, byte minValue, byte maxValue, byte defaultValue)
        {
            SafeAgainst.NumericGuards.Byte.Safe.AgainstNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable byte within the current container with a predefined value if it is null or zero.
        /// Example: container.SafeAgainstNullOrZero(defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable byte value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable byte is null or zero.</param>
        /// <returns>The current container of type 'SafeContainer<byte?>' after verification.</returns>
        public static SafeContainer<byte?> SafeAgainstNullOrZero(this SafeContainer<byte?> container, byte defaultValue)
        {
            SafeAgainst.NumericGuards.Byte.Safe.AgainstNullOrZero(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the nullable byte within the current container with a predefined value if it is null or not within the specified range.
        /// Example: container.SafeAgainstNullOrNotInRange(minValue, maxValue, defaultValue);
        /// </summary>
        /// <param name="container">Required. The nullable byte value stored within the current container.</param>
        /// <param name="minValue">Required. The minimum allowed value (inclusive).</param>
        /// <param name="maxValue">Required. The maximum allowed value (inclusive).</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated nullable byte is null or not in the specified range.</param>
        /// <returns>The current container of type 'SafeContainer<byte?>' after verification.</returns>
        public static SafeContainer<byte?> SafeAgainstNullOrNotInRange(this SafeContainer<byte?> container, byte minValue, byte maxValue, byte defaultValue)
        {
            SafeAgainst.NumericGuards.Byte.Safe.AgainstNullOrNotInRange(container, minValue, maxValue, defaultValue);
            return container;
        }
    }

}
