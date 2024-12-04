using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xama1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xama1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new VMPage1(Navigation);
        }
    }
}