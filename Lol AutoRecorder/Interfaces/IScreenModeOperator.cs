using Lol_AutoRecorder.Enums;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IScreenModeOperator
    {
        Task UpdateScreenMode(ScreenMode screenMode);
    }
}