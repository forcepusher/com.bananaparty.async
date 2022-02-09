namespace BananaParty.Async
{
    /// <remarks>
    /// Default interface implementation for <see cref="IAsyncOperationProgress{TProgress}"/>.
    /// </remarks>
    public class AsyncOperationProgress<TProgress> : AsyncOperationStatus, IAsyncOperationProgress<TProgress>
    {
        public TProgress Progress { get; set; }

        public AsyncOperationProgress(TProgress progress)
        {
            Progress = progress;
        }
    }

    /// <remarks>
    /// Default interface implementation for <see cref="IAsyncOperationProgress{TResult, TProgress}"/>.
    /// </remarks>
    public class AsyncOperationProgress<TResult, TProgress> : AsyncOperationStatus<TResult>, IAsyncOperationProgress<TResult, TProgress>
    {
        public TProgress Progress { get; set; }

        public AsyncOperationProgress(TProgress progress)
        {
            Progress = progress;
        }
    }
}
