using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace WpfApp1.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
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
