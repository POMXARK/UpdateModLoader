

using ModLoader.UI.ViewModel;
using System.Windows;

namespace ModLoader.UI.View
{
    /// <summary>
    /// Логика взаимодействия для GameSelectionWindow.xaml
    /// </summary>
    public partial class GameSelectionWindow : Window
    {
        private GameSelectionWindowViewModel _viewModel;

        public GameSelectionWindow()
        {
            InitializeComponent();
            _viewModel = new GameSelectionWindowViewModel();
            DataContext = _viewModel;
            Loaded += MainWindow_LoadedAsync;
            //SellectGame.ItemsSource = GamesRepository.GetAll().Select(u => u.Name).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(SellectGame.Text);
            if (SellectGame.Text == "Sims4")
            {
                new Sims4().Show();
            }
        }

        private async void MainWindow_LoadedAsync(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}
