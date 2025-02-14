using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfApp1.Models;
namespace WpfApp1.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly Model _model;

        public MainWindowViewModel () {
            _model = new Model();

            _model.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(_model.Num))
                {
                    Num = _model.Num;
                }
            };
        }

        [ObservableProperty]
        private int? _num = 0;

        [ObservableProperty]
        private string? _name = "Hello World";

        [RelayCommand]
        public void Add () {
            Num++;
        }
    }
}
