using Lol_AutoRecorder.Interfaces;
using Ninject.Extensions.Logging;
using System;
using System.Threading;

namespace Lol_AutoRecorder.Processors
{
    public class RecordingCancellationManager : IRecordingCancellationManager
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly ILogger _logger;

        public RecordingCancellationManager(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        private CancellationToken Current { get; set; }

        public CancellationToken Generate()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _logger.Debug($"Cancellation token generated: {_cancellationTokenSource.Token.ToString()}.");

            return Current = _cancellationTokenSource.Token;
        }

        public CancellationToken GetToken()
        {
            if (Current == null) throw new Exception("Please generate a token first using Generate() method.");

            return Current;
        }

        public void CancelCurrentToken()
        {
            if (Current == null) throw new Exception("Please generate a token first using Generate() method.");

            _logger.Debug($"Cancellation token cancelled: {_cancellationTokenSource.Token.ToString()}.");
            _cancellationTokenSource.Cancel();
        }
    }
}
