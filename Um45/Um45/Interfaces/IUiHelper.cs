using System.Threading.Tasks;

namespace Um45.Interfaces
{
   public interface IUiHelper
   {
   Task ShowAlert(string message);
        Task ShowAlert(string title, string message);
     
   }
}
