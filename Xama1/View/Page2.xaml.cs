

using Xama1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xama1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new VMPage2(Navigation);
        }
    }
}