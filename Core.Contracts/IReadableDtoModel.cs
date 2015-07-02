namespace Core.Contracts
{
    /// <summary>
    /// Represents a model that allows its DTO to be explicitly read by the business layer only.
    /// </summary>
    /// <typeparam name="TEntity">The DTO type that will be accessible on the business layer.</typeparam>
    /// <remarks>
    /// Only implement this interface if the DTO is required to be got through an exposed property. If implemented,
    /// this interface should be explicitly implemented.
    /// </remarks>
    public interface IReadableDtoModel<TEntity>
    {
        /// <summary>
        /// Gets the data transfer object for internal business layer use only.
        /// </summary>
        TEntity Dto { get; }
    }
}
