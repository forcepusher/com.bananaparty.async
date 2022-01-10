using System;

namespace BananaParty.Async
{
    /// <remarks>
    /// Default interface implementation for <see cref="IAsyncOperationStatus{TResult}"/>.
    /// </remarks>
    public class AsyncOperationStatus<TResult> : IAsyncOperationStatus<TResult>
    {
        public bool Completed { get; private set; } = false;

        private TResult _result;
        public TResult Result
        {
            get
            {
                if (!Completed)
                    throw new InvalidOperationException($"Trying to get {nameof(Result)} property from {nameof(AsyncOperationStatus<TResult>)} that is not completed.");

                return _result;
            }
            private set
            {
                _result = value;
            }
        }

        public void Complete(TResult result)
        {
            if (Completed)
                throw new InvalidOperationException($"Trying to call {nameof(Complete)} on {nameof(AsyncOperationStatus<TResult>)} that is already completed.");

            Result = result;
            Completed = true;
        }
    }

    /// <remarks>
    /// Default interface implementation for <see cref="IAsyncOperationStatus"/>.
    /// </remarks>
    public class AsyncOperationStatus : AsyncOperationStatus<bool> { }
}
