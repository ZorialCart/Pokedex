using Xama1.ViewModel.VMPokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xama1.View.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonRegister : ContentPage
    {
        public PokemonRegister()
        {
            InitializeComponent();
            BindingContext = new VMPokemonRegister(Navigation);
        }
    }
}