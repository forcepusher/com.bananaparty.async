using System;

namespace BananaParty.Async
{
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

    public class AsyncOperationStatus : AsyncOperationStatus<bool> { }
}
