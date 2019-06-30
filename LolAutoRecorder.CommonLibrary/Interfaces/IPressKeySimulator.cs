using LolAutoRecorder.CommonLibrary.Enums;
using System.Threading.Tasks;

namespace LolAutoRecorder.CommonLibrary.Interfaces
{
    public interface IPressKeySimulator
    {
        Task SendKeystrokeAsync(Initializer initialzer);

        Task SendWindowModeCommandAsync();
    }
}