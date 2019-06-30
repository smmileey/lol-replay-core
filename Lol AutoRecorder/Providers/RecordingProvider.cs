using Lol_AutoRecorder.Constants;
using Lol_AutoRecorder.Exceptions;
using Lol_AutoRecorder.Interfaces;
using LolAutoRecorder.Model;
using System;
using System.IO;

namespace Lol_AutoRecorder.Providers
{
    public class RecordingProvider : IRecordingProvider
    {
        public Recording Provide(ReplayPlayback replayPlaybackInfo, int replaySpeed, int framesPerSecond, string recordingSavePath)
        {
            if (replayPlaybackInfo == null) throw new RecordingProviderException($"Argument not provided: {replayPlaybackInfo}");
            if (string.IsNullOrEmpty(recordingSavePath)) throw new RecordingProviderException($"Argument not provided: {recordingSavePath}");

            try
            {
                Path.GetFullPath(recordingSavePath);
            }
            catch (Exception exception)
            {
                throw new RecordingProviderException(Error.InvalidPathError, exception);
            }

            return  new Recording
            {
                StartTime = (int)replayPlaybackInfo.Time,
                EndTime = (int)(replayPlaybackInfo.Time + replayPlaybackInfo.Length),
                ReplaySpeed = replaySpeed,
                FramesPerSecond = framesPerSecond,
                Path = recordingSavePath,
                Lossless = true,
                IsRecording = true
            };
        }
    }
}
