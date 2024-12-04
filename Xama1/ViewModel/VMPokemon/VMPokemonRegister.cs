using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xama1.Model;
using Xama1.Data;

namespace Xama1.ViewModel.VMPokemon
{
    public class VMPokemonRegister : BaseViewModel
    {
        #region VARIABLES
        string _TxtBackground;
        string _TxtPowerColor;
        string _TxtName;
        string _TxtNo;
        string _TxtPower;
        string _TxIcon;

        #endregion

        #region BUILDER
        public VMPokemonRegister(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJECT
        public string TxtBackground
        {
            get { return _TxtBackground; }
            set { SetValue(ref _TxtBackground, value); }
        }
        public string TxtPowerColor
        {
            get { return _TxtPowerColor; }
            set { SetValue(ref _TxtPowerColor, value); }
        }
        public string TxtName
        {
            get { return _TxtName; }
            set { SetValue(ref _TxtName, value); }
        }
        public string TxtNo
        {
            get { return _TxtNo; }
            set { SetValue(ref _TxtNo, value); }
        }
        public string TxtPower
        {
            get { return _TxtPower; }
            set { SetValue(ref _TxtPower, value); }
        }
        public string TxIcon
        {
            get { return _TxIcon; }
            set { SetValue(ref _TxIcon, value); }
        }
        #endregion

        #region PROCESS
        public async Task Insert()
        {
            var funcion = new DPokemon();
            var parameters = new MPokemon();
            parameters.Background = TxtBackground;
            parameters.PowerColor = TxtPowerColor;
            parameters.Icon = TxIcon;
            parameters.Name = TxtName;
            parameters.No = TxtNo;
            parameters.Power = TxtPower;

            await funcion.InsertPokemon(parameters);
            await Back();
        }
        public async Task Back()
        {
            await Navigation.PopAsync();

        }
        public void SimpleProcess()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand BackCommand => new Command(async () => await Back());
        public ICommand SimpleProcesscommand => new Command(SimpleProcess);
        public ICommand InsertCommand => new Command(async () => await Insert());
        #endregion
    }
}
