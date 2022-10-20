
using ModLoader.UI.ViewModel.Interfaces;
using System.Threading.Tasks;

namespace ModLoader.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        public async Task LoadAsync()
        {
            var navigationViewModel = new NavigationViewModel();
        }
    }
}
