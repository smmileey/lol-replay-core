using Lol_AutoRecorder.Interfaces;
using Lol_AutoRecorder.Mappings;
using Lol_AutoRecorder.Processors;
using Lol_AutoRecorder.Providers;
using Lol_AutoRecorder.Repositories;
using Lol_AutoRecorder.Wrappers;
using LolAutoRecorder.CommonLibrary.Interfaces;
using LolAutoRecorder.CommonLibrary.Mappers;
using LolAutoRecorder.CommonLibrary.Processors;
using Ninject.Modules;

namespace Lol_AutoRecorder.IoC
{
    public class DependenciesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<LolAutoRecorder>().ToSelf().InSingletonScope();
            Bind<IRestRepository>().To<RestRepository>().InSingletonScope();
            Bind<IReplayRepository>().To<ReplayRepository>().InSingletonScope();
            Bind<IRetryPolicy>().To<RetryPolicy>().InSingletonScope();
            Bind<IInitializerToUShortMapper>().To<InitializerToUShortMapper>().InSingletonScope();
            Bind<IPressKeySimulator>().To<PressKeySimulator>().InSingletonScope();
            Bind<IParticipantIdToInitializerMapper>().To<ParticipantIdToInitializerMapper>().InSingletonScope();
            Bind<IInputOutputWrapper>().To<InputOutputWrapper>().InSingletonScope();
            Bind<IPlayerIdProvider>().To<PlayerIdProvider>().InSingletonScope();
            Bind<IReplayPlaybackProvider>().To<ReplayPlaybackProvider>().InSingletonScope();
            Bind<ILeagueClientLauncher>().To<LeagueClientLauncher>().InSingletonScope();
            Bind<IUnprocessedFilesMonitor>().To<UnprocessedFilesMonitor>().InSingletonScope();
            Bind<IRecordingProvider>().To<RecordingProvider>().InSingletonScope();
            Bind<IProgressBarOperator>().To<ProgressBarOperator>().InSingletonScope();
            Bind<IRecordingCancellationManager>().To<RecordingCancellationManager>().InSingletonScope();
            Bind<IScreenModeOperator>().To<ScreenModeOperator>().InSingletonScope();
            Bind<IStringToScreenModeMapper>().To<StringToScreenModeMapper>().InSingletonScope();
            Bind<IWindowModeMonitor>().To<WindowModeMonitor>().InSingletonScope();
        }
    }
}
