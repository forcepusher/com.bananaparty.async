namespace BananaParty.Async
{
    /// <summary>
    /// Interface for tracking execution status of asynchronous operation with a progress info.
    /// </summary>
    /// <typeparam name="TResult">Object and/or status returned by the loading operation.</typeparam>
    /// <typeparam name="TProgress">Struct that contains loading progress info, usually a <see cref="float"/>.</typeparam>
    public interface IAsyncLoadingStatus<TResult, TProgress> : IAsyncOperationStatus<TResult> where TProgress : struct
    {
        public TProgress Progress { get; }
    }
}
