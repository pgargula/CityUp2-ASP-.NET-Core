using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.TextControlService
{
    public interface ITextControlService
    {
       
        Task<string> CensorText(string text);
        Task<int> CategoryHint(string text);
    }
}