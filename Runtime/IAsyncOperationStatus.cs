namespace BananaParty.Async
{
    /// <summary>
    /// Interface for tracking execution status of an asynchronous operation.
    /// Always assumes success on completion, cannot fail.
    /// </summary>
    public interface IAsyncOperationStatus
    {
        public bool Completed { get; }
    }

    /// <summary>
    /// Interface for tracking execution status of an asynchronous operation.
    /// </summary>
    /// <typeparam name="TResult">Object and/or status returned by the operation, like a boolean indicating Success or Failure.</typeparam>
    public interface IAsyncOperationStatus<TResult> : IAsyncOperationStatus
    {
        public TResult Result { get; }
    }
}
