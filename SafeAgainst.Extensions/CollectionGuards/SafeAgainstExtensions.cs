using System.Collections.Generic;

namespace SafeAgainst.Extensions.CollectionGuards
{
    /// <summary>
    ///     Provides extension methods for basic guard clauses over 'IEnumerable<T>' types encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the collection within the current container with a predefined value if it is NULL.
        /// Example: container.SafeAgainstNull(defaultValue);
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="container">Required. The collection stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated collection is NULL.</param>
        /// <returns>The current container of type 'SafeContainer<IEnumerable<T>>' after verification.</returns>
        public static SafeContainer<IEnumerable<T>> SafeAgainstNull<T>(this SafeContainer<IEnumerable<T>> container, IEnumerable<T> defaultValue)
        {
            SafeAgainst.CollectionGuards.Safe<T>.AgainstNull(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the collection within the current container with a predefined value if it is empty.
        /// Example: container.SafeAgainstEmpty(defaultValue);
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="container">Required. The collection stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated collection is empty.</param>
        /// <returns>The current container of type 'SafeContainer<IEnumerable<T>>' after verification.</returns>
        public static SafeContainer<IEnumerable<T>> SafeAgainstEmpty<T>(this SafeContainer<IEnumerable<T>> container, IEnumerable<T> defaultValue)
        {
            SafeAgainst.CollectionGuards.Safe<T>.AgainstEmpty(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the collection within the current container with a predefined value if it is null or empty.
        /// Example: container.SafeAgainstNullOrEmpty(defaultValue);
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="container">Required. The collection stored within the current container.</param>
        /// <param name="defaultValue">Required. The default value assigned if the encapsulated collection is null or empty.</param>
        /// <returns>The current container of type 'SafeContainer<IEnumerable<T>>' after verification.</returns>
        public static SafeContainer<IEnumerable<T>> SafeAgainstNullOrEmpty<T>(this SafeContainer<IEnumerable<T>> container, IEnumerable<T> defaultValue)
        {
            SafeAgainst.CollectionGuards.Safe<T>.AgainstNullOrEmpty(container, defaultValue);
            return container;
        }

        /// <summary>
        /// Eliminates null values from the collection within the current container.
        /// Example: container.SafeAgainstNullElements();
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="container">Required. The collection stored within the current container.</param>
        /// <returns>The current container of type 'SafeContainer<IEnumerable<T>>' after verification.</returns>
        public static SafeContainer<IEnumerable<T>> SafeAgainstNullElements<T>(this SafeContainer<IEnumerable<T>> container)
        {
            SafeAgainst.CollectionGuards.Safe<T>.AgainstNullElements(container);
            return container;
        }

        /// <summary>
        /// Eliminates default elements (default(T)) from the collection within the current container.
        /// Example: container.SafeAgainstDefaultElements();
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="container">Required. The collection stored within the current container.</param>
        /// <returns>The current container of type 'SafeContainer<IEnumerable<T>>' after verification.</returns>
        public static SafeContainer<IEnumerable<T>> SafeAgainstDefaultElements<T>(this SafeContainer<IEnumerable<T>> container)
        {
            SafeAgainst.CollectionGuards.Safe<T>.AgainstDefaultElements(container);
            return container;
        }

        /// <summary>
        /// Eliminates values that are not in the desired set from the collection within the current container.
        /// Example: container.SafeAgainstValuesNotInSet(desiredSet);
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="container">Required. The collection stored within the current container.</param>
        /// <param name="desiredSet">Required. The set of values that the elements in the collection should be part of.</param>
        /// <returns>The current container of type 'SafeContainer<IEnumerable<T>>' after verification.</returns>
        public static SafeContainer<IEnumerable<T>> SafeAgainstValuesNotInSet<T>(this SafeContainer<IEnumerable<T>> container, IEnumerable<T> desiredSet)
        {
            SafeAgainst.CollectionGuards.Safe<T>.AgainstValuesNotInSet(container, desiredSet);
            return container;
        }
    }

}
