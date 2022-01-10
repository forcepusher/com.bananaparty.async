namespace BananaParty.Async
{
    /// <summary>
    /// Interface for tracking execution status of an asynchronous operation.
    /// </summary>
    /// <typeparam name="TResult">Object and/or status returned by the operation.</typeparam>
    public interface IAsyncOperationStatus<TResult>
    {
        public bool Completed { get; }

        public TResult Result { get; }
    }

    /// <summary>
    /// <see cref="IAsyncOperationStatus{TResult}"/> where <see cref="{TResult}"/> is a <see cref="bool"/> that represents either success or failure.
    /// </summary>
    public interface IAsyncOperationStatus : IAsyncOperationStatus<bool> { }
}
