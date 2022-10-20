


using System.Threading.Tasks;
using ModLoader.UI.ViewModel.Interfaces;

namespace ModLoader.UI.ViewModel
{
    public class GameSelectionWindowViewModel
    {
        public GameSelectionWindowViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }

        public INavigationViewModel NavigationViewModel { get; }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }
    }
}
