using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLayouts.TiposPaginas.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void GoToPage1 (object sender, EventArgs args)
        {
            Detail = new NavigationPage (new Navigation.Page1()); //Detail precisa receber uma nova navigationPage pois a transição de uma mastar p/ uma ContentPage n é possível
        }
        private void GoToPage2(object sender, EventArgs args)
        {
            Detail = new Navigation.Page2();
        }
        private void GoToContentPage(object sender, EventArgs args)
        {
            Detail = new Content();
        }
    }
}