using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLayouts.TiposPaginas.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        
        private void GoToPage2 (object sender, EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }
        private void GoToModal (object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }
        private void GoToMaster(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}