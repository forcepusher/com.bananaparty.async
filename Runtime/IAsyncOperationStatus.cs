namespace BananaParty.Async
{
    public interface IAsyncOperationStatus<TResult>
    {
        public bool Completed { get; }

        public TResult Result { get; }
    }

    public interface IAsyncOperationStatus : IAsyncOperationStatus<bool> { }
}
