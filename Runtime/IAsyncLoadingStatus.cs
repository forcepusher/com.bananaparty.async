namespace BananaParty.Async
{
    public interface IAsyncLoadingStatus<TResult, TProgress> : IAsyncOperationStatus<TResult> where TProgress : struct
    {
        public TProgress Progress { get; }
    }
}
