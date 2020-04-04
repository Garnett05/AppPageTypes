using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLayouts.TiposPaginas.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : TabbedPage
    {
        public Page1()
        {
            InitializeComponent(); //carrega o XAML

            Children.Add(new NavigationPage(new TiposPaginas.Navigation.Page1()) { Title = "Item 3"});
        }
    }
}