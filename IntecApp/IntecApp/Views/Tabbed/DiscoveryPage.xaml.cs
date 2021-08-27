using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntecApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecApp.Views.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new MenuOptionViewModel();
        }

        DiscoveryCardView lastElementSelected = new DiscoveryCardView();
        public void OnClicked(object sender, EventArgs e)
        {
            lastElementSelected.BackgroundColor = Color.White;
            var elementSelected = (DiscoveryCardView)sender;
            elementSelected.BackgroundColor = Color.FromHex("#f2ac22");
            lastElementSelected = elementSelected;
        }
    }
}