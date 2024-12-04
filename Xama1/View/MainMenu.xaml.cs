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
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
			InitializeComponent ();
			BindingContext = new VMMainMenu(Navigation);
		}
	}
}