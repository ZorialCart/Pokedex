using System;
using Xama1.View;
using Xama1.Model;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xama1.View.Pokemon;


namespace Xama1.ViewModel
{
    public class VMMainMenu: BaseViewModel
    {
        #region VARIABLES
        string _Text;
        public List<MMainMenu> pagelist { get; set; }
        #endregion

        #region BUILDER
        public VMMainMenu(INavigation navigation)
        {
            Navigation = navigation;
            ShowPages();
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
        public async Task Back()
        {
            await Navigation.PopAsync();
        }
        public void ShowPages()
        {
            pagelist = new List<MMainMenu>
            {
                new MMainMenu
                {
                    Module= "Entry, datapicker, picker, label, navegation",
                    Icon="https://i.ibb.co/xzsn8nD/entrenador-pokemon.png\" alt=\"entrenador-pokemon"
                },
                new MMainMenu
                {
                    Module= "CollectionView without database link",
                    Icon= "https://i.ibb.co/tPpwc6n/pokemon-ir.png"
                },
                new MMainMenu
                {
                    Module= "CRUD Pokedex",
                    Icon= "https://i.ibb.co/MN3sT6g/avatar-2.png"
                },
                
            };

        }
        public async Task NavPage(MMainMenu parameters)
        {
            string module;
            module = parameters.Module;

            if (module.Contains("Entry, datapicker"))
            {
                await Navigation.PushAsync(new Page1());
            }

            if (module.Contains("CollectionView"))
            {
                await Navigation.PushAsync(new Page2());
            }

            if (module.Contains("CRUD Pokedex"))
            {
                await Navigation.PushAsync(new PokemonList());
            }
        }
      
        #endregion


        #region COMMANDS
        //public ICommand Backcommand => new Command(async () => await Back());
        public ICommand NavPageCommand => new Command<MMainMenu>(async (p) => await NavPage(p));
        public ICommand Backcommand => new Command(async () => await Back());
        //public ICommand SimpleProcesscommand => new Command(SimpleProcess);
        #endregion
    }
}

