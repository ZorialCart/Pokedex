using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xama1.Model;
using Xamarin.Forms;

namespace Xama1.ViewModel
{
    public class VMDetailsPokemon : BaseViewModel
    {
        #region VARIABLES
        string _Text;
        string _PowerColor;
        string _Background;
        public MPokemon parametersRec {  get; set; }
        #endregion

        #region BUILDER
        public VMDetailsPokemon(INavigation navigation, MPokemon parametersBring)
        {
            Navigation = navigation;
            parametersRec = parametersBring;
            _PowerColor = parametersRec.PowerColor;
            _Background = parametersRec.Background;
        }
        #endregion

        #region OBJECT
        public string Text
        {
            get { return _Text; }
            set { SetValue(ref _Text, value); }
        }

        public string PowerColor
        {
            get { return _PowerColor; }
            set
            {
                SetValue(ref _PowerColor, value);
                OnPropertyChanged(nameof(PowerColor));
            }
        }
        public string Background
        {
            get { return _Background; }
            set
            {
                SetValue(ref _PowerColor, value);
                OnPropertyChanged(nameof(Background));
            }
        }
        #endregion

        #region PROCESS
        public async Task Back()
        {
            await Navigation.PopAsync();
        }
        public async Task AsyncProcess()
        {
        }
        public void SimpleProcess()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand AsyncProcesscommand => new Command(async () => await AsyncProcess());
        public ICommand SimpleProcesscommand => new Command(SimpleProcess);
        public ICommand Backcommand => new Command (async () => await Back());
    
        #endregion
    }
}
