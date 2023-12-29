using System;
using System.Threading.Tasks;

namespace SafeAgainst.Extensions
{
    /// <summary>
    /// Provides extension methods for custom guard clauses encapsulated in a 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        /// Replaces the value within the current container with a default value if it satisfies the specified predicate.
        /// Example: container.SafeAgainst(predicate, defaultValue);
        /// </summary>
        /// <typeparam name="T">The type of the value stored within the container.</typeparam>
        /// <param name="container">Required. The value stored within the current container.</param>
        /// <param name="predicate">Required. The predicate function to check against the value.</param>
        /// <param name="defaultValue">Required. The default value assigned if the predicate is satisfied.</param>
        /// <returns>The current container after verification.</returns>
        public static SafeContainer<T> SafeAgainst<T>(this SafeContainer<T> container, Func<T, bool> predicate, T defaultValue)
        {
            Safe<T>.Against(container, predicate, defaultValue);
            return container;
        }

        /// <summary>
        /// Replaces the value within the current container with a dynamically provided replacement if it satisfies the specified predicate.
        /// Example: container.SafeAgainst(predicate, replace);
        /// </summary>
        /// <typeparam name="T">The type of the value stored within the container.</typeparam>
        /// <param name="container">Required. The value stored within the current container.</param>
        /// <param name="predicate">Required. The predicate function to check against the value.</param>
        /// <param name="replace">Required. The function providing the replacement value if the predicate is satisfied.</param>
        /// <returns>The current container after verification.</returns>
        public static SafeContainer<T> SafeAgainst<T>(this SafeContainer<T> container, Func<T, bool> predicate, Func<T> replace)
        {
            Safe<T>.Against(container, predicate, replace);
            return container;
        }

        /// <summary>
        /// Replaces the value within the current container with a dynamically provided replacement if it satisfies the specified predicate.
        /// Example: container.SafeAgainst(predicate, replace);
        /// </summary>
        /// <typeparam name="T">The type of the value stored within the container.</typeparam>
        /// <param name="container">Required. The value stored within the current container.</param>
        /// <param name="predicate">Required. The predicate function to check against the value.</param>
        /// <param name="replace">Required. The function providing the replacement value if the predicate is satisfied.</param>
        /// <returns>The current container after verification.</returns>
        public static SafeContainer<T> SafeAgainst<T>(this SafeContainer<T> container, Func<T, bool> predicate, Func<T, T> replace)
        {
            Safe<T>.Against(container, predicate, replace);
            return container;
        }

        /// <summary>
        /// Asynchronously replaces the value within the current container with a dynamically provided replacement if it satisfies the specified predicate.
        /// Example: await container.SafeAsyncAgainst(predicate, replace);
        /// </summary>
        /// <typeparam name="T">The type of the value stored within the container.</typeparam>
        /// <param name="container">Required. The value stored within the current container.</param>
        /// <param name="predicate">Required. The predicate function to check against the value.</param>
        /// <param name="replace">Required. The asynchronous function providing the replacement value if the predicate is satisfied.</param>
        /// <returns>The current container after verification.</returns>
        public static async Task<SafeContainer<T>> SafeAsyncAgainst<T>(this SafeContainer<T> container, Func<T, bool> predicate, Func<Task<T>> replace)
        {
            await Safe<T>.AsyncAgainst(container, predicate, replace);
            return container;
        }

        /// <summary>
        /// Asynchronously replaces the value within the current container with a dynamically provided replacement if it satisfies the specified predicate.
        /// Example: await container.SafeAsyncAgainst(predicate, replace);
        /// </summary>
        /// <typeparam name="T">The type of the value stored within the container.</typeparam>
        /// <param name="container">Required. The value stored within the current container.</param>
        /// <param name="predicate">Required. The predicate function to check against the value.</param>
        /// <param name="replace">Required. The asynchronous function providing the replacement value if the predicate is satisfied.</param>
        /// <returns>The current container after verification.</returns>
        public static async Task<SafeContainer<T>> SafeAsyncAgainst<T>(this SafeContainer<T> container, Func<T, bool> predicate, Func<T, Task<T>> replace)
        {
            await Safe<T>.AsyncAgainst(container, predicate, replace);
            return container;
        }
    }

}