using Lol_AutoRecorder.Enums;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IStringToScreenModeMapper
    {
        ScreenMode Map(string value);
    }
}