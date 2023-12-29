using System;

namespace SafeAgainst.Extensions.EnumGuards
{
    /// <summary>
    ///     Provides extension methods for the basic guard clauses over 'Enum' type encapsulated into 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        ///     Verifies if the enum within the current container is outside its type range and replaces it with a predefined value in a fluent way.
        ///     Example: container.SafeAgainstNotInRange(defaultValue);
        /// </summary>
        /// <param name="container">Required. The enum value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated value is outside its type range.</param>
        /// <returns>The current container of type 'SafeContainer<T> where T is an Enum' after verification.</returns>
        public static SafeContainer<T> SafeAgainstNotInRange<T>(this SafeContainer<T> container, T defaultValue) where T : struct, Enum
        {
            SafeAgainst.EnumGuards.Safe<T>.AgainstNotInRange(container, defaultValue);

            return container;
        }

        /// <summary>
        /// Verifies if the enum within the current container is null or outside its type range and replaces it with a predefined value in a fluent way.
        /// Example: container.SafeAgainstNullOrNotInRange(defaultValue);
        /// </summary>
        /// <param name="container">Required. The enum value stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated value is null or outside its type range.</param>
        /// <returns>The current container of type 'SafeContainer<T?> where T is an Enum' after verification.</returns>
        public static SafeContainer<T?> SafeAgainstNullOrNotInRange<T>(this SafeContainer<T?> container, T defaultValue) where T : struct, Enum
        {
            SafeAgainst.EnumGuards.Safe<T>.AgainstNullOrNotInRange(container, defaultValue);

            return container;
        }
    }
}
