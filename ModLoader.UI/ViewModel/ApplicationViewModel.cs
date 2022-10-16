using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ModLoader.UI.Data.Repositories;

namespace MVVM
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        // приватное поле для изменение свойства SelectedPhone
        private Phone selectedPhone;

        // свойство WPF INotifyPropertyChanged вызывает событие при изменении
        public ObservableCollection<Phone> Phones { get; set; }

        // свойство с обьектным типом, класс Phone
        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                // MVVM Привязка свойства к XAML Binding , обновляет форму при вызове сеттера
                OnPropertyChanged("SelectedPhone");
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public ApplicationViewModel()
        {
            // Задать сеттер для свойства Phones
            Phones = new ObservableCollection<Phone>
            {
                // Экземпляры класса Phone, должен реализовывать INotifyPropertyChanged
                new Phone { Title="iPhone 7", Company="Apple", Price=56000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                new Phone {Title="Elite x3", Company="HP", Price=56000 },
                new Phone {Title="Mi5S", Company="Xiaomi", Price=35000 }
            };
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