namespace BananaParty.Async
{
    public class AsyncLoadingStatus<TResult, TProgress> : AsyncOperationStatus<TResult>, IAsyncLoadingStatus<TResult, TProgress> where TProgress : struct
    {
        public TProgress Progress { get; private set; }

        public AsyncLoadingStatus(TProgress progress)
        {
            Progress = progress;
        }

        public AsyncLoadingStatus()
        {
            Progress = new();
        }
    }
}
