namespace BananaParty.Async
{
    /// <remarks>
    /// Default interface implementation for <see cref="IAsyncLoadingStatus{TResult, TProgress}"/>.
    /// </remarks>
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
