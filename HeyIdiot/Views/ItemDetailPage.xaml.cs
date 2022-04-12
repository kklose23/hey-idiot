using System.ComponentModel;
using Xamarin.Forms;
using HeyIdiot.ViewModels;

namespace HeyIdiot.Views
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
