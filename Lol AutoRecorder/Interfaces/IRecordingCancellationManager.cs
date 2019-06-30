using System.Threading;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IRecordingCancellationManager
    {
        CancellationToken Generate();

        CancellationToken GetToken();

        void CancelCurrentToken();
    }
}