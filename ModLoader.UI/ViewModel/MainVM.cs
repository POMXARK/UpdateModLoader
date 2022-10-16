
using ModLoader.UI.Data.Repositories;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace ModLoader.UI.ViewModel
{
    public class MainVM : BindableBase
    {
        readonly MyMathModel _model = new MyMathModel();
        public MainVM()
        {
            //таким нехитрым способом мы пробрасываем изменившиеся свойства модели во View
            _model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            AddCommand = new DelegateCommand<string>(str =>
            {
                //проверка на валидность ввода - обязанность VM
                int ival;

                if (int.TryParse(str, out ival))
                {
                    _model.AddValue(ival);
                }

            });

            RemoveCommand = new DelegateCommand<int?>(i =>
            {

                if (i.HasValue)
                {
                    _model.RemoveValue(i.Value);
                }

            });
        }
        public DelegateCommand<string> AddCommand { get; }
        public DelegateCommand<int?> RemoveCommand { get; }
        public int Sum => _model.Sum;
        public ReadOnlyObservableCollection<int> MyValues => _model.MyPublicValues;
    }
}
