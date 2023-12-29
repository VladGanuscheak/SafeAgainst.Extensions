namespace SafeAgainst.Extensions.ObjectGuards
{
    /// <summary>
    ///     Provides extension methods for the basic guard clauses over 'object' type encapsulated into 'SafeContainer'.
    /// </summary>
    public static partial class SafeAgainstExtensions
    {
        /// <summary>
        ///     The extension method which allows to verify if the object within the current container is NULL and to replace it with a predefined value in a fluent way.
        ///     For example, the current method may be invoked in the following way: container.SafeAgainstNull(defaultValue);
        /// </summary>
        /// <param name="container">Required. An object value which is stored within the current container.</param>
        /// <param name="defaultValue">Required. A default value which will be assigned to the container's content in case if the encapsulated one is NULL.</param>
        /// <returns>The current container of type 'SafeContainer<object>' which has been verified and contains up-to-date content.</returns>
        public static SafeContainer<object> SafeAgainstNull(this SafeContainer<object> container, object defaultValue)
        {
            SafeAgainst.ObjectGuards.Safe.AgainstNull(container, defaultValue);

            return container;
        }
    }
}
