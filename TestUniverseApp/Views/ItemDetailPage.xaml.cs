using System.ComponentModel;
using Xamarin.Forms;
using TestUniverseApp.ViewModels;

namespace TestUniverseApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
