namespace BananaParty.Async
{
    /// <summary>
    /// Interface for tracking execution status of asynchronous operation with a progress info.
    /// </summary>
    /// <typeparam name="TProgress">Struct that contains loading progress info, usually a <see cref="float"/>.</typeparam>
    public interface IAsyncOperationProgress<TProgress> : IAsyncOperationStatus
    {
        TProgress Progress { get; }
    }

    /// <summary>
    /// Interface for tracking execution status of asynchronous operation with a progress info and result object.
    /// </summary>
    /// <typeparam name="TResult">Object and/or status returned by the loading operation.</typeparam>
    /// <typeparam name="TProgress">Struct that contains loading progress info, usually a <see cref="float"/>.</typeparam>
    public interface IAsyncOperationProgress<TResult, TProgress> : IAsyncOperationStatus<TResult>
    {
        TProgress Progress { get; }
    }
}
