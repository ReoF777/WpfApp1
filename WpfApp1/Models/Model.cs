using CommunityToolkit.Mvvm.ComponentModel;
namespace WpfApp1.Models
{
    public partial class Model : ObservableObject
    {
        [ObservableProperty]
        private int _num = 0;

        public Model () {
            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);
                    Num++;
                }
            });
        }
    }
}
