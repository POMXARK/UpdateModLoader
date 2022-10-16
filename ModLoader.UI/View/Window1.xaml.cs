
using ModLoader.UI.Data.Repositories;
using ModLoader.View;
using System.Linq;
using System.Windows;

namespace ModLoader.UI.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            SellectGame.ItemsSource = GamesRepository.GetAll().Select(u => u.Name).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(SellectGame.Text);
            if (SellectGame.Text == "Sims4")
            {
                new Sims4().Show();
            }
        }
    }
}
