using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgressBar = CircularProgressBar.CircularProgressBar;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IProgressBarOperator
    {
        Task Update(double replayPlaybackLength, double totalLength, Form owner, ProgressBar progressBar, Label associatedLabel, CancellationToken cancellationToken);
    }
}