using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xama1.View.Pokemon;
using Xamarin.Forms;

namespace Xama1.ViewModel.VMPokemon
{
    public class VMListPokemon : BaseViewModel
    {
        #region VARIABLES
        string _Text;
        #endregion

        #region BUILDER
        public VMListPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJECT
        public string Text
        {
            get { return _Text; }
            set { SetValue(ref _Text, value); }
        }
        #endregion

        #region PROCESS
        public async Task Registrer()
        {
            await Navigation.PushAsync(new PokemonRegister());
        }
        public void SimpleProcess()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand RegistrerCommand => new Command(async () => await Registrer());
        public ICommand SimpleProcesscommand => new Command(SimpleProcess);
        #endregion
    }
}
