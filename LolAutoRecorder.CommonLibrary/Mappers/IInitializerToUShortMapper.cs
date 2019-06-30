using LolAutoRecorder.CommonLibrary.Enums;

namespace LolAutoRecorder.CommonLibrary.Mappers
{
    public interface IInitializerToUShortMapper
    {
        ushort Map(Initializer initialzer);
    }
}