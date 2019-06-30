using Lol_AutoRecorder.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgressBar = CircularProgressBar.CircularProgressBar;

namespace Lol_AutoRecorder.Processors
{
    public class ProgressBarOperator : IProgressBarOperator
    {
        public async Task Update(double replayPlaybackLength, double totalLength, Form owner, ProgressBar progressBar, Label associatedLabel, CancellationToken cancellationToken)
        {
            double playbackRatio = Math.Round(replayPlaybackLength / totalLength * 100 / replayPlaybackLength, 2);
            owner.Invoke(new Action(() =>
            {
                progressBar.Visible = false;
                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = (int)replayPlaybackLength;
                progressBar.Visible = true;
            }));

            do
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    await Task.Run(() => owner.Invoke(new Action(() => associatedLabel.Text = "Cancelled!")));
                    cancellationToken.ThrowIfCancellationRequested();
                }

                await Task.Delay(1000);
                owner.Invoke(new Action(() =>
                {
                    ++progressBar.Value;
                    double textProgress = double.Parse(progressBar.Text);
                    progressBar.Text = $"{textProgress + playbackRatio}";
                }));
            } while (progressBar.Value < progressBar.Maximum);
        }
    }
}
