using RentMovieMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RentMovieMobile.Views
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