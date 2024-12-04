using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xama1.ViewModel.VMPokemon;
namespace Xama1.View.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonList : ContentPage
    {
        VMListPokemon vm;
        public PokemonList()
        {
            InitializeComponent();
            BindingContext = new VMListPokemon(Navigation);
        }
    }
}