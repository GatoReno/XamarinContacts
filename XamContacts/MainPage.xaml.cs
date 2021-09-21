using Xamarin.Forms;
using XamContacts.ViewModels;

namespace XamContacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
