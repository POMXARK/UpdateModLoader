using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ModLoader.Model;

namespace MVVM
{
    public class SimsApplicationViewModel : INotifyPropertyChanged
    {
        // приватное поле для изменение свойства SelectedPhone
        private Games selectedGame;

        // свойство WPF INotifyPropertyChanged вызывает событие при изменении
        public ObservableCollection<Games> Games { get; set; }

        // свойство с обьектным типом, класс Phone
        public Games SelectedGame
        {
            get { return selectedGame; }
            set
            {
                selectedGame = value;
                // MVVM Привязка свойства к XAML Binding , обновляет форму при вызове сеттера
                OnPropertyChanged("selectedGame");
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public SimsApplicationViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод изменения формы, обработки событий
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}