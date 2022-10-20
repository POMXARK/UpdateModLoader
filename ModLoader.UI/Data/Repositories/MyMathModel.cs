using AngleSharp.Io;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;

/// MVVM зависимости загрузка данных
/// public MainWindow(MainViewModel viewModel)
///{
///    InitializeComponent();
///   _viewModel = viewModel;
///    DataContext = _viewModel;
///    Loaded += MainWindow_LoadedAsync;
///}
///  private async void MainWindow_LoadedAsync(object sender, RoutedEventArgs e) {
///    await _viewModel.LoadAsync(); }
/// public async Task LoadAsync()
/// await NavigationViewModel.LoadAsync();
/// private IEventAggregator _eventAggregator;
/// IEventAggregator eventAggregator
/// Friends = new ObservableCollection<NavigationItemViewModel>();
/// public ObservableCollection<NavigationItemViewModel> Friends { get; set; }
/// public async Task LoadAsync()
/// Friends.Add(new NavigationItemViewModel(item.Id, item.DisplayMember,
///      nameof(FriendDetailViewModel),
///      _eventAggregator));



namespace ModLoader.UI.Data.Repositories
{
    /// <summary>
    /// https://habr.com/ru/post/338518/
    /// Prism для DelegateCommand, 
    ///BindableBase вместо самостоятельной реализации INotifyPropertyChange. 
    ///Для этого надо подключить через NuGet библиотек Prism.Wpf. 
    ///Соответственно OnPropertyChanged() измениться на RaisePropertyChanged()
    /// Для того, чтобы создать связь кнопки и VM, необходимо использовать DelegateCommand.
    /// </summary>
    public class MyMathModel : BindableBase // добавляет реализванный метод обновления формы RaisePropertyChanged
    {
        private readonly ObservableCollection<int> _myValues = new ObservableCollection<int>();
        public readonly ReadOnlyObservableCollection<int> MyPublicValues;
        public MyMathModel()
        {
            MyPublicValues = new ReadOnlyObservableCollection<int>(_myValues);
        }
        //добавление в коллекцию числа и уведомление об изменении суммы
        public void AddValue(int value)
        {
            _myValues.Add(value);
            RaisePropertyChanged("Sum");
        }
        //проверка на валидность, удаление из коллекции и уведомление об изменении суммы
        public void RemoveValue(int index)
        {
            //проверка на валидность удаления из коллекции - обязанность модели
            if (index >= 0 && index < _myValues.Count) _myValues.RemoveAt(index);
            RaisePropertyChanged("Sum");
        }
        public int Sum => MyPublicValues.Sum(); //сумма
    }
}
