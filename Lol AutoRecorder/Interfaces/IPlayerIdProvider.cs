using Lol_AutoRecorder.Wrappers;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IPlayerIdProvider
    {
        PlayerIdProviderResult Provide(string leagueFolderPath, string championName);
    }
}