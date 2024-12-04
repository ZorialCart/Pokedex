using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xama1.Data;
using Xama1.Model;
using Xama1.View.Pokemon;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Xama1.ViewModel.VMPokemon
{
    public class VMListPokemon : BaseViewModel
    {
        #region VARIABLES
        string _Text;
        ObservableCollection<MPokemon> _Listpokemon;
        #endregion

        #region BUILDER
        public VMListPokemon(INavigation navigation)
        {
            Navigation = navigation;
            ShowPokemon();
        }
        public async Task Back()
        {
            await Navigation.PopAsync();
        }
        #endregion

        #region OBJECT
        public ObservableCollection<MPokemon> Listpokemon
        {
            get { return _Listpokemon; }
            set { SetValue(ref _Listpokemon, value);
                OnPropertyChanged();
            }
        }
        #endregion

        #region PROCESS
        public async Task ShowPokemon() {
            var function = new DPokemon();
            Listpokemon = await function.ShowPokemons();
        }
        public async Task Registrer()
        {
            await Navigation.PushAsync(new PokemonRegister());
        }
        public async Task GoToDetails(MPokemon parameters)
        {
            await Navigation.PushAsync(new PokemonDetails(parameters));
        }

        #endregion

        #region COMMANDS
        public ICommand RegistrerCommand => new Command(async () => await Registrer());
        public ICommand Detailscommand => new Command<MPokemon>(async (parameters) => await GoToDetails(parameters));
        public ICommand Backcommand => new Command(async () => await Back());
        #endregion
    }
}
