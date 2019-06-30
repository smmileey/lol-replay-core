using Lol_AutoRecorder.Wrappers;
using LolAutoRecorder.CommonLibrary.Enums;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IParticipantIdToInitializerMapper
    {
        Initializer Map(PlayerIdProviderResult playerIdProviderResult);
    }
}