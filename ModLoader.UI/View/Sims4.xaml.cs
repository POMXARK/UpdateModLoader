using AngleSharp.Common;
using Microsoft.EntityFrameworkCore;
using ModLoader.DataAccess;
using ModLoader.UI.Data.Repositories;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace ModLoader.UI.View
{
    /// <summary>
    /// Логика взаимодействия для Sims4.xaml
    /// </summary>
    public partial class Sims4 : Window
    {
        public Sims4()
        {
            InitializeComponent();
            namesPacks.ItemsSource = ModCollectionRepository.GetAll().Select(u => u.Name).ToList();
        }

        private void PolygonShapesMenu_OnClick(object sender, RoutedEventArgs e)
        {
            MenuItem clickedItem = (MenuItem)sender;
            //MessageBox.Show(clickedItem.Header.ToString());
            var collectionId = ModCollectionRepository.Find(clickedItem.Header.ToString()).Id;
            collectionPacks.ItemsSource = PackRepository.GetAll().Where(u => u.ModCollectionId == collectionId).Select(u => u.Name).ToList();
        }

        private void OnMouseDownStartDrag(object sender, RoutedEventArgs e)
        {

            //ListBoxItem clickedItem = (ListBoxItem)sender;
            //var test = collectionPacks.Items;
            //MessageBox.Show(namesPacks.IsChecked.ToString());
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SetActive(sender);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SetActive(sender);
        }

        private void SetActive(object sender)
        {
            CheckBox chBox = (CheckBox)sender;
            //MessageBox.Show(chBox.Content.ToString() + " не отмечен");

            using (var context = new Context())
            {
                var chBoxName = chBox.Content.ToDictionary()["Content"];
                var userId = context.Packs.Where(u => u.Name == chBoxName).Select(u => u.Id).ToList()[0];

                //var existingBlog = new User { Id = userId, Active = false, Name = chBoxName };
                //context.Entry(existingBlog).State = EntityState.Modified;

                var row = context.Packs.FirstOrDefault(r => r.Name == chBoxName);
                row.Active = (bool)chBox.IsChecked;

                //row.Active = false;

                context.Entry(row).State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
