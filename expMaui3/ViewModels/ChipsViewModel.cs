using CommunityToolkit.Mvvm.ComponentModel;

namespace expMaui3.ViewModels
{
    public class ViewModel : ObservableObject
    {

    }

    public partial class ChipsViewModel : ViewModel
    {
        [ObservableProperty]
        private string[] items;

        public ChipsViewModel(string[] values)
        {
            this.items = values;
        }
    }
}
